using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    public partial class FormDivision : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        public FormDivision()
        {
            InitializeComponent();
        }

        private void FormDivision_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void FormDivision_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Division.DIVISIONS'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.dIVISIONSTableAdapter.Fill(this.dS_Division.DIVISIONS);

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            callBackForm.Close();
        }

        private void BTN_Deconnexion_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
            callBackForm.Show();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            FormDivision_Ajouter Ajouter = new FormDivision_Ajouter();
            if (Ajouter.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlAjout = "insert into Division (NomDivision,DateCreation)" +
                    " VALUES(:NomDivision,:DateCreation)";
                try 
                {
                    OracleParameter OraParaNomDiv = new OracleParameter(":NomDivision", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamDateCreation = new OracleParameter(":DateCreation", OracleDbType.Date);

                    OraParaNomDiv.Value = Ajouter.nomDivision;
                    OraParamDateCreation.Value = Ajouter.dateCreation;
                
                }
            }
          

               
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
