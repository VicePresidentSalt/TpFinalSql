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
    public partial class Form_Joueurs_Ajouter : Form
    {

        public Form callBackForm = null;
        public OracleConnection conn = null;

        public string numeroJoueurs
        {
            get
            {
                return TB_Numjoueur.Text;
            }
            set
            {
                TB_Numjoueur.Text = value;
            }
        }

        public string nomJoueurs
        {
            get
            {
                return TB_NomJoueur.Text;
            }
            set
            {
                TB_NomJoueur.Text = value;
            }
        }

        public string prenomJoueurs
        {
            get
            {
                return TB_PrenomJoueur.Text;
            }
            set
            {
                TB_PrenomJoueur.Text = value;
            }
        }

        public string DDN
        {
            get
            {
                return DTP_DateNaissanceJoueur.Value.ToString();
            }
            set
            {
                DTP_DateNaissanceJoueur.Value = DateTime.Parse(value);
            }
        }

        public string maillot
        {
            get
            {
                return TB_NumeroMaillotJoueur.Text;
            }
            set
            {
                TB_NumeroMaillotJoueur.Text = value;
            }
        }

        public string Equipe
        {
            get
            {
                return CB_EquipeJoueur.Text;
            }
            set
            {
                CB_EquipeJoueur.Text = value;
            }
        }
        public string Position
        {
            get
            {
                return CB_PositionJoueur.Text;
            }
            set
            {
                CB_PositionJoueur.Text = value;
            }
        }

        public Form_Joueurs_Ajouter()
        {
            InitializeComponent();
        }

        private void Form_Joueurs_Ajouter_Load(object sender, EventArgs e)
        {
            if (conn != null)
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
            }
        }

        private void Form_Joueurs_Ajouter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
            {
                callBackForm.Location = this.Location;
                callBackForm.Show();
            }
        }
    }
}
