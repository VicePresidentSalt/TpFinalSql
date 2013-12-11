using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    public partial class Form_Classement : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        private DataSet ClassementDataSet = null;
        public string divisions = null;

        public Form_Classement()
        {
            InitializeComponent();
        }

        private void Form_Classement_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void LoadDGV()
        {
            try
            {
                if (divisions != null)
                {
                    OracleCommand oraSelect = conn.CreateCommand();
                    oraSelect.CommandText = "select sum(Nbpoints) as total, equipe from classement " +
                    "group by equipe having equipe in (select nomequipe from Equipes " +
                    "where DivisionEquipe = '" + divisions + "') order by total desc";

                    OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
                    ClassementDataSet = new DataSet();
                    oraAdapter.Fill(ClassementDataSet);
                    DGV_Classement.DataSource = ClassementDataSet.Tables[0];

                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}

