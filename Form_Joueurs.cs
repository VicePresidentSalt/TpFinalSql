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
        private bool Currval = false;
        private string sqlnum = null;

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

        private void updateControls()
        {
            if (TB_NumeroJoueur.Text == "")
            {
                BTN_modifier.Enabled = false;
                BF_Debut.Enabled = false;
                BF_Dernier.Enabled = false;
                BF_Precedent.Enabled = false;
                BF_Suivant.Enabled = false;
                BTN_delete.Enabled = false;
            }
            else
            {
                BTN_modifier.Enabled = true;
                BF_Debut.Enabled = true;
                BF_Dernier.Enabled = true;
                BF_Precedent.Enabled = true;
                BF_Suivant.Enabled = true;
                BTN_delete.Enabled = true;
            }
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
            updateControls();
        }

        public void FillForm()
        {
            OracleCommand oraSelect = conn.CreateCommand();
            oraSelect.CommandText = "SELECT * FROM Joueurs WHERE EquipeJoueur=:NomEquipe";
            oraSelect.Parameters.Add(new OracleParameter(":NomEquipe", Equipe));
            using (OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect))
            {
                if (joueurDataSet.Tables.Contains("Joueur"))
                {
                    joueurDataSet.Tables["Joueur"].Clear();
                }

                oraAdapter.Fill(joueurDataSet, "Joueur");
            }

            UpdateTextBox();

        }
        private void UpdateTextBox()
        {
            ClearBindings();
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
            Form_Joueurs_Ajouter fja = new Form_Joueurs_Ajouter();
            fja.callBackForm = this;
            fja.Location = this.Location;
            fja.conn = conn;
            this.Hide();
            fja.Text = "Ajout de joueurs";

            if (!Currval)
            {
                sqlnum = "Select MAX(numerojoueurs) from joueurs ";
            }
            else
            {
                sqlnum = "Select seqjoueurs.currval from dual ";
            }
            OracleCommand oraCMD = new OracleCommand(sqlnum, conn);
            oraCMD.CommandType = CommandType.Text;


            try
            {
                OracleDataReader oraRead = oraCMD.ExecuteReader();
                while (oraRead.Read())
                {
                    fja.numeroJoueurs = (oraRead.GetInt32(0) + 1).ToString();

                }
                oraRead.Close();
            }

            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


            if (fja.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlAjout = "insert into Joueurs (Nomjoueurs,Prenomjoueur,datenaissance,numeromaillot,equipejoueur,positionjoueur)" +
                    " VALUES(:Nomjoueurs,:Prenomjoueur,:datenaissance,:numeromaillot,:equipejoueur,:positionjoueur)";
                Currval = true;
                try
                {

                    OracleCommand oraAjout = new OracleCommand(sqlAjout, conn);

                    OracleParameter OraParaNomjoueurs = new OracleParameter(":Nomjoueurs", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamPrenomjoueurs = new OracleParameter(":Prenomjoueurs", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamdatenaissance = new OracleParameter(":datenaissance", OracleDbType.Date);  //Ajout
                    OracleParameter OraParanumeromaillot = new OracleParameter(":numeromaillot", OracleDbType.Int32);
                    OracleParameter OraParaequipejoueurs = new OracleParameter(":equipejoueur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParpositionjoueur = new OracleParameter(":positionjoueur", OracleDbType.Varchar2, 40);

                    OraParaNomjoueurs.Value = fja.nomJoueurs;
                    OraParamPrenomjoueurs.Value = fja.prenomJoueurs;
                    OraParamdatenaissance.Value = DateTime.Parse(fja.DDN);
                    OraParanumeromaillot.Value = fja.maillot;
                    OraParaequipejoueurs.Value = fja.Equipe;
                    OraParpositionjoueur.Value = fja.Position;

                    oraAjout.Parameters.Add(OraParaNomjoueurs);
                    oraAjout.Parameters.Add(OraParamPrenomjoueurs);
                    oraAjout.Parameters.Add(OraParamdatenaissance);
                    oraAjout.Parameters.Add(OraParanumeromaillot);
                    oraAjout.Parameters.Add(OraParaequipejoueurs);
                    oraAjout.Parameters.Add(OraParpositionjoueur);

                    oraAjout.ExecuteNonQuery();
                    FillForm();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BTN_modifier_Click(object sender, EventArgs e)
        {
            Form_Joueurs_Ajouter fjm = new Form_Joueurs_Ajouter();
            fjm.callBackForm = this;
            fjm.conn = conn;
            fjm.Text = "Modification du joueur";
            fjm.numeroJoueurs = TB_NumeroJoueur.Text;
            fjm.nomJoueurs = TB_NomJoueur.Text;
            fjm.prenomJoueurs = TB_PrenomJoueur.Text;
            fjm.DDN = DTP_DateNaissanceJoueur.Value.ToString();
            fjm.maillot = TB_NumeroMaillotJoueur.Text;
            fjm.Equipe = CB_EquipeJoueur.SelectedItem.ToString();
            fjm.Position = CB_PositionJoueur.SelectedItem.ToString();
            fjm.Location = this.Location;
            fjm.BTN_OK.Text = "Modifier";
            this.Hide();

            if (fjm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlModif = "Update joueurs set Nomjoueurs =:Nomjoueurs, Prenomjoueur =:Prenomjoueur, datenaissance =:datenaissance, " +
                                       "numeromaillot =:numeromaillot, equipejoueur =:equipejoueur , positionjoueur=:positionjoueur where numerojoueurs =:numerojoueurs";
                try
                {

                    OracleCommand oraAjout = new OracleCommand(sqlModif, conn);

                    OracleParameter OraParaNomjoueurs = new OracleParameter(":Nomjoueurs", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamPrenomjoueurs = new OracleParameter(":Prenomjoueur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamdatenaissance = new OracleParameter(":datenaissance", OracleDbType.Date);  //Ajout
                    OracleParameter OraParanumeromaillot = new OracleParameter(":numeromaillot", OracleDbType.Int32);
                    OracleParameter OraParaequipejoueurs = new OracleParameter(":equipejoueur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParpositionjoueur = new OracleParameter(":positionjoueur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParnumerojoueurs = new OracleParameter(":numerojoueurs", OracleDbType.Int32);

                    OraParaNomjoueurs.Value = fjm.nomJoueurs;
                    OraParamPrenomjoueurs.Value = fjm.prenomJoueurs;
                    OraParamdatenaissance.Value = DateTime.Parse(fjm.DDN);
                    OraParanumeromaillot.Value = fjm.maillot;
                    OraParaequipejoueurs.Value = fjm.Equipe;
                    OraParpositionjoueur.Value = fjm.Position;
                    OraParnumerojoueurs.Value = fjm.numeroJoueurs;

                    oraAjout.Parameters.Add(OraParaNomjoueurs);
                    oraAjout.Parameters.Add(OraParamPrenomjoueurs);
                    oraAjout.Parameters.Add(OraParamdatenaissance);
                    oraAjout.Parameters.Add(OraParanumeromaillot);
                    oraAjout.Parameters.Add(OraParaequipejoueurs);
                    oraAjout.Parameters.Add(OraParpositionjoueur);
                    oraAjout.Parameters.Add(OraParnumerojoueurs);

                    oraAjout.ExecuteNonQuery();

                    FillForm();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {
            DialogResult Confirmation;
            Confirmation = MessageBox.Show("Voulez-vous vraiment effacer cette entrée ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Confirmation == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    OracleParameter paramNomEquipe = new OracleParameter(":numjoueur", OracleDbType.Int32);
                    paramNomEquipe.Value = TB_NumeroJoueur.Text;
                    string sqlDelete = "Delete from joueurs Where numerojoueurs =:numjoueur";
                    OracleCommand oraDelete = new OracleCommand(sqlDelete, conn);
                    oraDelete.Parameters.Add(paramNomEquipe);
                    oraDelete.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
         
             

