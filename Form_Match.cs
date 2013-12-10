using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    public partial class Form_Match : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        public DataSet MatchDataSet = null;

        public Form_Match()
        {
            InitializeComponent();
        }

        private void ReloadDGV()
        {
            int lastIndex = -1;
            if (DGV_Match.SelectedRows.Count > 0) lastIndex = DGV_Match.SelectedRows[0].Index;

            OracleCommand oraSelect = conn.CreateCommand();
            oraSelect.CommandText = "SELECT * FROM Match";
            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
            MatchDataSet = new DataSet();
            oraAdapter.Fill(MatchDataSet);
            DGV_Match.DataSource = MatchDataSet.Tables[0];

            if (lastIndex > -1 && DGV_Match.Rows.Count > 0) DGV_Match.Rows[Math.Min(lastIndex, DGV_Match.Rows.Count - 1)].Selected = true;
        }

        private void Form_Match_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            Form_Match_Ajouter Ajouter = new Form_Match_Ajouter();
            Ajouter.Text = "Ajout";
            Ajouter.conn = conn;
            string sql = "Select seqmatch.currval from dual ";
            OracleCommand oraCMD = new OracleCommand(sql,conn);
            oraCMD.CommandType = CommandType.Text;

           
            try
            {
                OracleDataReader oraRead = oraCMD.ExecuteReader();
                while (oraRead.Read())
                {
                    Ajouter.numeroMatch = oraRead.GetInt32(0) + 1.ToString();

                }
                oraRead.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            if (Ajouter.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlMatchAjout = "insert into Match (EquipeHome,EquipeVisiteur,DateRencontre,Lieu,ScoreHome,ScoreVisiteur)" +
                    " VALUES(:EquipeHome,:EquipeVisiteur,:DateRencontre,:Lieu)";

                try
                {
                    OracleCommand oraMatchAjout = new OracleCommand(sqlMatchAjout, conn);


                    OracleParameter OraParaEquipeHome = new OracleParameter(":EquipeHome", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaEquipeVisiteur = new OracleParameter(":EquipeVisiteur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaDateRencontre = new OracleParameter(":DateRencontre", OracleDbType.Date);
                    OracleParameter OraParaLieu = new OracleParameter(":Lieu", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaScoreHome = new OracleParameter(":ScoreHome", OracleDbType.Int32);
                    OracleParameter OraParaScoreVisiteur = new OracleParameter(":ScoreVisiteur", OracleDbType.Int32);

                    OraParaEquipeHome.Value = Ajouter.equipeHome;
                    OraParaEquipeVisiteur.Value = Ajouter.equipeVisiteur;
                    OraParaDateRencontre.Value = DateTime.Parse(Ajouter.dateRencontre);
                    OraParaLieu.Value = Ajouter.lieuRencontre;
                    OraParaScoreHome.Value = Ajouter.scoreHome;
                    OraParaScoreVisiteur.Value = Ajouter.scoreVisiteur;

                    oraMatchAjout.Parameters.Add(OraParaEquipeHome);
                    oraMatchAjout.Parameters.Add(OraParaEquipeVisiteur);
                    oraMatchAjout.Parameters.Add(OraParaDateRencontre);
                    oraMatchAjout.Parameters.Add(OraParaLieu);
                    oraMatchAjout.Parameters.Add(OraParaScoreHome);
                    oraMatchAjout.Parameters.Add(OraParaScoreVisiteur);

                    oraMatchAjout.ExecuteNonQuery();

                    ReloadDGV();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Form_Match_Load(object sender, EventArgs e)
        {
            ReloadDGV();
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            Form_Match_Ajouter Modifier = new Form_Match_Ajouter();
            Modifier.conn = conn;
            Modifier.Text = "Modification";
            Modifier.numeroMatch = DGV_Match.SelectedRows[0].Cells[0].Value.ToString();
            Modifier.equipeHome = DGV_Match.SelectedRows[0].Cells[1].Value.ToString();
            Modifier.equipeVisiteur = DGV_Match.SelectedRows[0].Cells[2].Value.ToString();
            Modifier.dateRencontre = DGV_Match.SelectedRows[0].Cells[3].Value.ToString();
            Modifier.lieuRencontre = DGV_Match.SelectedRows[0].Cells[4].Value.ToString();
            Modifier.scoreHome = DGV_Match.SelectedRows[0].Cells[5].Value.ToString();
            Modifier.scoreVisiteur = DGV_Match.SelectedRows[0].Cells[6].Value.ToString();

            if (Modifier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlModif = "Update Match set EquipeHome =:EquipeHome, EquipeVisiteur =:EquipeVisiteur, DateRencontre =:DateRencontre, " +
                    "Lieu =:Lieu, ScoreHome =:ScoreHome, ScoreVisiteur =:ScoreVisiteur where NumeroMatch =:NumeroMatch";

                try
                {
                    OracleCommand oraMatchModif = new OracleCommand(sqlModif, conn);

                    OracleParameter OraParaNumMatch = new OracleParameter(":NumeroMatch", OracleDbType.Int32);
                    OracleParameter OraParaEquipeHome = new OracleParameter(":EquipeHome", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaEquipeVisiteur = new OracleParameter(":EquipeVisiteur", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaDateRencontre = new OracleParameter(":DateRencontre", OracleDbType.Date);
                    OracleParameter OraParaLieu = new OracleParameter(":Lieu", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaScoreHome = new OracleParameter(":ScoreHome", OracleDbType.Int32);
                    OracleParameter OraParaScoreVisiteur = new OracleParameter(":ScoreVisiteur", OracleDbType.Int32);

                    
                    OraParaEquipeHome.Value = Modifier.equipeHome;
                    OraParaEquipeVisiteur.Value = Modifier.equipeVisiteur;
                    OraParaDateRencontre.Value = DateTime.Parse(Modifier.dateRencontre);
                    OraParaLieu.Value = Modifier.lieuRencontre;
                    OraParaNumMatch.Value = Modifier.numeroMatch;
                    OraParaScoreHome.Value = Modifier.scoreHome;
                    OraParaScoreVisiteur.Value = Modifier.scoreVisiteur;

                    
                    oraMatchModif.Parameters.Add(OraParaEquipeHome);
                    oraMatchModif.Parameters.Add(OraParaEquipeVisiteur);
                    oraMatchModif.Parameters.Add(OraParaDateRencontre);
                    oraMatchModif.Parameters.Add(OraParaLieu);
                    oraMatchModif.Parameters.Add(OraParaNumMatch);
                    oraMatchModif.Parameters.Add(OraParaScoreHome);
                    oraMatchModif.Parameters.Add(OraParaScoreVisiteur);

                    oraMatchModif.ExecuteNonQuery();

                    ReloadDGV();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void DGV_Match_SelectionChanged(object sender, EventArgs e)
        {
            // Such Will
            PB_EquipeHomeLogo.Image = null;
            PB_EquipeVisiteurLogo.Image = null;

            if (DGV_Match.SelectedRows.Count > 0) {
                OracleCommand oraImage = conn.CreateCommand();
                oraImage.CommandText = "SELECT (SELECT LogoEquipe FROM Equipes WHERE NomEquipe=:NomEquipe1), (SELECT LogoEquipe FROM Equipes WHERE NomEquipe=:NomEquipe2) FROM DUAL";
                oraImage.Parameters.Add(new OracleParameter(":NomEquipe1", DGV_Match.SelectedRows[0].Cells[1].Value.ToString()));
                oraImage.Parameters.Add(new OracleParameter(":NomEquipe2", DGV_Match.SelectedRows[0].Cells[2].Value.ToString()));
                using (OracleDataReader oraReader = oraImage.ExecuteReader()) {
                    if (oraReader.Read()) {
                        OracleBlob oraBlob = oraReader.GetOracleBlob(0);
                        if (!oraBlob.IsNull) {
                            using (MemoryStream ms = new MemoryStream()) {
                                byte[] buffer = new byte[8 * 1024];
                                int read = 0;
                                while ((read = oraBlob.Read(buffer, 0, 8 * 1024)) > 0) {
                                    ms.Write(buffer, 0, read);
                                }
                                PB_EquipeHomeLogo.Image = Image.FromStream(ms);
                            }
                        }

                        oraBlob = oraReader.GetOracleBlob(1);
                        if (!oraBlob.IsNull) {
                            using (MemoryStream ms = new MemoryStream()) {
                                byte[] buffer = new byte[8 * 1024];
                                int read = 0;
                                while ((read = oraBlob.Read(buffer, 0, 8 * 1024)) > 0) {
                                    ms.Write(buffer, 0, read);
                                }
                                PB_EquipeVisiteurLogo.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
        }

    }



}




