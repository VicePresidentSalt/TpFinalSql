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
        private DataSet joueurDataSet = new DataSet();
        private string Equipe;
        
        public Form_Joueurs(string equipe)
        {
            InitializeComponent();
            Equipe = equipe;
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
        
        private void Getinfos()
        {
            try
            {
                string SQL = "SELECT * FROM JOUEURS";

                OracleDataAdapter Oraad = new OracleDataAdapter(SQL, conn);

                if (joueurDataSet.Tables.Contains("Joueur"))
                {
                    joueurDataSet.Tables["Joueur"].Clear();
                }
                Oraad.Fill(joueurDataSet, "Joueur");
                Oraad.Dispose();
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
                joueurDataSet.Tables["Joueur"].Clear();
                
            }

            oraAdapter.Fill(joueurDataSet, "Joueur");
            oraAdapter.Dispose();

            UpdateTextBox();
            
        }
        private void UpdateTextBox()
        {
            TB_NumeroJoueur.DataBindings.Add("Text", joueurDataSet, "Joueur.NumeroJoueurs");
            TB_NomJoueur.DataBindings.Add("Text", joueurDataSet, "Joueur.NomJoueurs");
            TB_PrenomJoueur.DataBindings.Add("Text", joueurDataSet, "Joueur.PrenomJoueur");
            DTP_DateNaissanceJoueur.DataBindings.Add("Calendrier", joueurDataSet, "Joueur.DateNaissance");
            TB_NumeroMaillotJoueur.DataBindings.Add("Text", joueurDataSet, "Joueur.NumeroMaillot");
            TB_EquipeJoueur.DataBindings.Add("Text", joueurDataSet, "Joueur.EquipeJoueur");
            TB_PositionJoueur.DataBindings.Add("Text", joueurDataSet, "Joueur.PositionJoueur");
        }
        private void ClearBindings()
        {
            TB_NumeroJoueur.DataBindings.Clear();
            TB_NumeroJoueur.Clear();
            TB_NomJoueur.DataBindings.Clear();
            TB_NomJoueur.Clear();
            TB_PrenomJoueur.DataBindings.Clear();
            TB_PrenomJoueur.Clear();
            DTP_DateNaissanceJoueur.DataBindings.Clear();
            DTP_DateNaissanceJoueur.Value = new DateTime();
            TB_NumeroMaillotJoueur.DataBindings.Clear();
            TB_NumeroMaillotJoueur.Clear();
            TB_EquipeJoueur.DataBindings.Clear();
            TB_EquipeJoueur.Clear();
            TB_PositionJoueur.DataBindings.Clear();
            TB_PositionJoueur.Clear();
        }
        private void premier_Click(object sender, EventArgs e)
        {
            //this.BindingContext[Data, "Resultats"].Position = 0;
        }

        private void dernier_Click(object sender, EventArgs e)
        {
            //this.BindingContext[Data, "Resultats"].Position =
            //this.BindingContext[Data, "Resultats"].Count - 1;

        }
        private void suivant_Click(object sender, EventArgs e)
        {
            //this.BindingContext[Data, "Resultats"].Position++;

        }

        private void precedent_Click(object sender, EventArgs e)
        {
            //this.BindingContext[Data, "Resultats"].Position--;
        }
    }
         
             
}
