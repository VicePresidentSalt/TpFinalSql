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
                return TB_EquipeHome.Text;
            }
            set
            {
                TB_EquipeHome.Text = value;
            }
        }
        public string equipeVisiteur
        {
            get
            {
                return TB_EquipeVisiteur.Text;
            }
            set
            {
                TB_EquipeVisiteur.Text = value;
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
        

    }
}
