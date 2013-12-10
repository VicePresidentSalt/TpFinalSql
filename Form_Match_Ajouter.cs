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
    public partial class Form_Match_Ajouter : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        private DataSet matchDataSet = new DataSet();
        
        public Form_Match_Ajouter()
        {
            InitializeComponent();
        }

        private void Form_Match_Ajouter_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }
        public string numeroMatch
        {
            get
            {
                return TB_NumeroMatch.Text;
            }

            set
            {
                TB_NumeroMatch.Text = value;
            }
        
        }
        public string equipeHome
        {
            get
            {
                return CB_HOME.Text;
            }
            set
            {
                CB_HOME.Text = value;
            }
        }
        public string equipeVisiteur
        {
            get
            {
                return CB_Visiteur.Text;
            }
            set
            {
                CB_Visiteur.Text = value;
            }
        }
        public string dateRencontre
        {
            get
            {
                return DTP_DateRencontre.Value.ToShortDateString();
            }
            set
            {
                DTP_DateRencontre.Value = DateTime.Parse(value);
            }
        }
        public string lieuRencontre
        {
            get
            {
                return TB_Lieu.Text;
            }
            set
            {
                TB_Lieu.Text = value;
            }
        }
        public string scoreHome
        {
            get
            {
                return TB_ScoreHome.Text;
            }
            set
            {
                TB_ScoreHome.Text = value;
            }
        }
        public string scoreVisiteur
        {
            get
            {
                return TB_ScoreVisiteur.Text;
            }
            set
            {
                TB_ScoreVisiteur.Text = value;

            }
        }

        private void Form_Match_Ajouter_Load(object sender, EventArgs e)
        {
            OracleCommand oraSelect = conn.CreateCommand();
            oraSelect.CommandText = "SELECT nomequipe FROM equipes";
            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    string items = oraReader.GetString(0);
                    CB_HOME.Items.Add(items);
                    CB_Visiteur.Items.Add(items);
                }
            }
        }
        

    }
}
