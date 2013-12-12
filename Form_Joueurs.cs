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
            OracleCommand oraSelect = conn.CreateCommand();
            oraSelect.CommandText = "SELECT * FROM Joueurs WHERE EquipeJoueur=:NomEquipe";
            oraSelect.Parameters.Add(new OracleParameter(":NomEquipe", Equipe));
            using (OracleDataAdapter oraAdapter = new OracleDataAdapter()) {
                joueurDataSet.AcceptChanges();
                oraAdapter.Update(joueurDataSet, "Joueur");
            }
            
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void Form_Joueurs_Load(object sender, EventArgs e)
        {
            OracleCommand oraSelect = conn.CreateCommand();
            oraSelect.CommandText = "SELECT NomEquipe FROM Equipes";
            using (OracleDataReader oraReader = oraSelect.ExecuteReader())
            {
                while (oraReader.Read())
                {
                    CB_EquipeJoueur.Items.Add(oraReader.GetString(0));
                }
            }

            ReloadForm();
        }

        private void ReloadForm()
        {
            FillForm();
        }
        
        private void FillForm()
        {
            OracleCommand oraSelect = conn.CreateCommand();
            oraSelect.CommandText = "SELECT * FROM Joueurs WHERE EquipeJoueur=:NomEquipe";
            oraSelect.Parameters.Add(new OracleParameter(":NomEquipe", Equipe));
            using (OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect)) {
                if (joueurDataSet.Tables.Contains("Joueur")) {
                    joueurDataSet.Tables["Joueur"].Clear();

                }

                oraAdapter.Fill(joueurDataSet, "Joueur");
            }

            UpdateTextBox();
            
        }
        private void UpdateTextBox()
        {
            TB_NumeroJoueur.DataBindings.Add("Text", joueurDataSet, "Joueur.NumeroJoueurs");
            TB_NomJoueur.DataBindings.Add("Text", joueurDataSet, "Joueur.NomJoueurs");
            TB_PrenomJoueur.DataBindings.Add("Text", joueurDataSet, "Joueur.PrenomJoueur");
            DTP_DateNaissanceJoueur.DataBindings.Add("Text", joueurDataSet, "Joueur.DateNaissance");
            TB_NumeroMaillotJoueur.DataBindings.Add("Text", joueurDataSet, "Joueur.NumeroMaillot");
            CB_EquipeJoueur.DataBindings.Add("SelectedItem", joueurDataSet, "Joueur.EquipeJoueur");
            CB_PositionJoueur.DataBindings.Add("SelectedItem", joueurDataSet, "Joueur.PositionJoueur");
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
            DTP_DateNaissanceJoueur.Value = DateTime.Now;
            TB_NumeroMaillotJoueur.DataBindings.Clear();
            TB_NumeroMaillotJoueur.Clear();
            CB_EquipeJoueur.DataBindings.Clear();
            CB_EquipeJoueur.ResetText();
            CB_PositionJoueur.DataBindings.Clear();
            CB_PositionJoueur.ResetText();
        }
        private void BF_Debut_MouseClick(object sender, MouseEventArgs e)
        {
            this.BindingContext[joueurDataSet, "Joueur"].Position = 0;
        }

        private void BF_Precedent_MouseClick(object sender, MouseEventArgs e)
        {
            this.BindingContext[joueurDataSet, "Joueur"].Position--;
        }

        private void BF_Suivant_MouseClick(object sender, MouseEventArgs e)
        {
            this.BindingContext[joueurDataSet, "Joueur"].Position++;
        }

        private void BF_Dernier_MouseClick(object sender, MouseEventArgs e)
        {
            this.BindingContext[joueurDataSet, "Joueur"].Position =
            this.BindingContext[joueurDataSet, "Joueur"].Count - 1;
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {

        }
    }
         
             
}
