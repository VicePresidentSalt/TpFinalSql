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
    public partial class Form_Calendrier_Match : Form
    {
        public Form callBackForm = null;
        public OracleConnection conn = null;
        private DataSet dateMatch = null;
        private DateTime Date = DateTime.Today;
        public Form_Calendrier_Match()
        {
            InitializeComponent();
        }

        private void Form_Calendrier_Match_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
            
        }

        private void Form_Calendrier_Match_Load(object sender, EventArgs e)
        {
            ReloadDGV();
        }

        private void ReloadDGV()
        {   
 
            try
            {

                OracleCommand oraSelect = conn.CreateCommand();
                oraSelect.CommandText = "Select * From Match where DATERENCONTRE = :Daterencontre";

                OracleParameter OraParaDateRencontre = new OracleParameter(":Daterencontre", OracleDbType.Date);
                OraParaDateRencontre.Value = Date;
                oraSelect.Parameters.Add(OraParaDateRencontre);
                OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
                dateMatch = new DataSet();
                oraAdapter.Fill(dateMatch);
                DGV_DateMatchCalendar.DataSource = dateMatch.Tables[0];
                 
                 
            }
            catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
        }

        private void Calendrier_Match_DateChanged(object sender, DateRangeEventArgs e)
        {
            Date = Calendrier_Match.SelectionRange.Start;
            ReloadDGV();
        }

        
    } 
}
