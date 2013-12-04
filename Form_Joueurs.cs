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
        private void Getinfos()
        {
            try
            {
                string SQL = "SELECT * FROM DISQUES";

                OracleDataAdapter Oraad = new OracleDataAdapter(SQL, conn);

                if (Data.Tables.Contains("Resultats"))
                {
                    Data.Tables["Resultat"].Clear();
                }
                Oraad.Fill(Data, "Resultats");
                Oraad.Dispose();

                BindingSource Source = new BindingSource(Data, "Resultats");

                DataDisques.DataSource = Source;
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message.ToString());
            }

        }
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
        private void UpdateTextBox()
        {
            TB_NoDisque.DataBindings.Add("text", Data, "Resultats.NoDisque");
            TB_Titre.DataBindings.Add("text", Data, "Resultats.TitreDisque");
            TB_Duree.DataBindings.Add("text", Data, "Resultats.DureeMinuteDisque");
            TB_Annee.DataBindings.Add("text", Data, "Resultats.AnneeDisque");
            TB_NOCIE.DataBindings.Add("text", Data, "Resultats.Nocie");
        }
        private void ClearBindings()
        {
            TB_NoDisque.DataBindings.Clear();
            TB_NoDisque.Clear();
            TB_Titre.DataBindings.Clear();
            TB_Titre.Clear();
            TB_Duree.DataBindings.Clear();
            TB_Duree.Clear();
            TB_Annee.DataBindings.Clear();
            TB_Annee.Clear();
            TB_NOCIE.DataBindings.Clear();
            TB_NOCIE.Clear();

        }
        private void premier_Click(object sender, EventArgs e)
        {
            this.BindingContext[Data, "Resultats"].Position = 0;
        }

        private void dernier_Click(object sender, EventArgs e)
        {
            this.BindingContext[Data, "Resultats"].Position =
            this.BindingContext[Data, "Resultats"].Count - 1;

        }
        private void suivant_Click(object sender, EventArgs e)
        {
            this.BindingContext[Data, "Resultats"].Position++;

        }

        private void precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[Data, "Resultats"].Position--;
        }
         */
    }
         
             
}
