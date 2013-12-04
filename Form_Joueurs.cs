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
    public partial class Form_Joueurs : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        private DataSet joueurDataSet = null;
        
        public Form_Joueurs()
        {
            InitializeComponent();
        }

        private void Form_Joueurs_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void Form_Joueurs_Load(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void ReloadForm()
        {
            
        }
        /*
        private void FillForm()
        {
            
            string sql = "SELECT * FROM Joueurs ";
            OracleDataAdapter oraAdapter = new OracleDataAdapter(sql, conn);
            
            if (joueurDataSet.Tables.Contains("Joueur"))
            {
                joueurDataSet.Tables["LB_Lister_Cie"].Clear();
            }

            oraDisque.Fill(monDataSet, "LB_Lister_Cie");
            oraDisque.Dispose();
            BindingSource maSource;
            maSource = new BindingSource(monDataSet, "LB_Lister_Cie");
            DGV_Disques.DataSource = maSource;
            
            
            
            TB_NumeroJoueur.DataBindings.Add("Text", joueurDataSet, "TB_N.NoDisque");
            TB_Nom.DataBindings.Add("Text", joueurDataSet, "LB_Lister_Cie.TitreDisque");
            TB_Prenom.DataBindings.Add("Text", joueurDataSet, "LB_Lister_Cie.DureeMinutesDisque");
            DTP_DateNaissance.DataBindings.Add("Calendrier", joueurDataSet, "LB_Lister_Cie.AnnéeDisque");
            TB_NumeroMaillot.DataBindings.Add("Text", joueurDataSet, "LB_Lister_Cie.Nocie");
            TB_EquipeJoueur.DataBindings.Add("Text", joueurDataSet, "LB_Lister_Cie.Nocie");
            TB_PositionJoueur.DataBindings.Add("Text", joueurDataSet, "LB_Lister_Cie.Nocie");
            
        }


        private void Vider()
        {
            textNoDisque.DataBindings.Clear();
            textTitre.DataBindings.Clear();
            textDuree.DataBindings.Clear();
            textAnnee.DataBindings.Clear();
            textCie.DataBindings.Clear();
        }
             */
    }
         
             
}
