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
    public partial class Form_Stats : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        private DataSet StatsDataSet = null;
        public string numJoueurs = null;
        public Form_Stats()
        {
            InitializeComponent();
        }

        public string numeroJoueurs
        {
            get
            {
                return TB_NumeroJoueur.Text;
            }
            set
            {
                TB_NumeroJoueur.Text = value;
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

        public string equipeJoueur
        {
            get
            {
                return TB_EquipeJoueur.Text;
            }
            set
            {
                TB_EquipeJoueur.Text = value;
            }
        }

        public string nbButs
        {
            get
            {
                return TB_NbButs.Text;
            }
            set
            {
                TB_NbButs.Text = value;
            }
        }

        public string nbPasses
        {
            get
            {
                return TB_NbPasses.Text;
            }
            set
            {
                TB_NbPasses.Text = value;
            }
        }
        public string nbPointsTotal
        {
            get
            {
                return TB_NbPoints.Text;
            }
            set
            {
                TB_NbPoints.Text = value;
            }
        }
        public string tempsPunition
        {
            get
            {
                return TB_TempsPunition.Text;
            }
            set
            {
                TB_TempsPunition.Text = value;
            }
        }

        private void Form_Stats_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void Form_Stats_Load(object sender, EventArgs e)
        {
            if (numJoueurs != null) ;
            {
                try
                {
                    OracleCommand oraStats = conn.CreateCommand();
                    oraStats.CommandText = " Select * From Fiches where NumeroJoueurs = " + numJoueurs;
                    OracleDataAdapter oraAdapter = new OracleDataAdapter(oraStats);
                    StatsDataSet = new DataSet();
                    oraAdapter.Fill(StatsDataSet);
                    DGV_Stats.DataSource = StatsDataSet.Tables[0];

                    TB_NumeroJoueur.Text = DGV_Stats.Rows[0].Cells[0].Value.ToString();
                    TB_NomJoueur.Text = DGV_Stats.Rows[0].Cells[1].Value.ToString();
                    TB_PrenomJoueur.Text = DGV_Stats.Rows[0].Cells[2].Value.ToString();
                    TB_EquipeJoueur.Text = DGV_Stats.Rows[0].Cells[3].Value.ToString();
                    TB_NbButs.Text = DGV_Stats.Rows[0].Cells[4].Value.ToString();
                    TB_NbPasses.Text = DGV_Stats.Rows[0].Cells[5].Value.ToString();
                    TB_NbPoints.Text = DGV_Stats.Rows[0].Cells[6].Value.ToString();
                    TB_TempsPunition.Text = DGV_Stats.Rows[0].Cells[7].Value.ToString();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
