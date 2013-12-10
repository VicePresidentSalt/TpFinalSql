using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Types;

namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    public partial class Form_Equipe : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        public string division = null;
        private DataSet equipeDataSet = null;
        private byte[] image = null;

        private void ReloadDGV()
        {
            int lastIndex = -1;
            if (DGV_Equipes.SelectedRows.Count > 0) lastIndex = DGV_Equipes.SelectedRows[0].Index;

            OracleCommand oraSelect = conn.CreateCommand();
            oraSelect.CommandText = "SELECT NomEquipe, DateIntroLigue, DivisionEquipe, VilleEquipe FROM Equipes E inner join Divisions D on D.NomDivision = E.DivisionEquipe " +
            "where DivisionEquipe=:Division";
            oraSelect.Parameters.Add(new OracleParameter(":Division", division));

            OracleDataAdapter oraAdapter = new OracleDataAdapter(oraSelect);
            equipeDataSet = new DataSet();
            oraAdapter.Fill(equipeDataSet);
            DGV_Equipes.DataSource = equipeDataSet.Tables[0];

            if (lastIndex > -1 && DGV_Equipes.Rows.Count > 0) DGV_Equipes.Rows[Math.Min(lastIndex, DGV_Equipes.Rows.Count - 1)].Selected = true;
        }
        
        public Form_Equipe(string Division)
        {
            InitializeComponent();
            division = Division;
        }

        private void FormEquipe_Load(object sender, EventArgs e)
        { 
            ReloadDGV();
        }
        
        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            FormEquipe_Ajouter Ajouter = new FormEquipe_Ajouter();
            Ajouter.conn = conn;
            Ajouter.Text = "Ajout";
            Ajouter.divisionEquipe = division;
            if (Ajouter.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlAjout = "insert into Equipes (NomEquipe,DateIntroLigue,LogoEquipe,DivisionEquipe,VilleEquipe)" + // Rajout de LogoEquipe dans la commande ...incomming crashs bitches !
                    " VALUES(:NomEquipe,:DateIntroLigue,:LogoEquipe,:DivisionEquipe,:VilleEquipe)";
                try 
                {
                    
                    OracleCommand oraAjout = new OracleCommand(sqlAjout, conn);
                    
                    OracleParameter OraParaNomEquipe = new OracleParameter(":NomEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamDateIntroLigue = new OracleParameter(":DateIntroLigue", OracleDbType.Date);
                    OracleParameter OraParamLogoEquipe = new OracleParameter(":LogoEquipe", OracleDbType.Blob);  //Ajout
                    OracleParameter OraParaDivEquipe = new OracleParameter(":DivisionEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaVilleEquipe = new OracleParameter(":VilleEquipe", OracleDbType.Varchar2, 40);

                    OraParaNomEquipe.Value = Ajouter.nomEquipe;
                    OraParamDateIntroLigue.Value = DateTime.Parse(Ajouter.dateIntroLigue);
                    OraParamLogoEquipe.Value = null;
                    OraParaDivEquipe.Value = Ajouter.divisionEquipe;
                    OraParaVilleEquipe.Value = Ajouter.villeEquipe;

                    // petit_wily
                    if (Ajouter.image != null)
                    {
                        OraParamLogoEquipe.Value = Ajouter.image;
                    }

                    oraAjout.Parameters.Add(OraParaNomEquipe);
                    oraAjout.Parameters.Add(OraParamDateIntroLigue);
                    oraAjout.Parameters.Add(OraParamLogoEquipe);
                    oraAjout.Parameters.Add(OraParaDivEquipe);
                    oraAjout.Parameters.Add(OraParaVilleEquipe);

                    oraAjout.ExecuteNonQuery();

                    ReloadDGV();
                }

                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }       
        
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            FormEquipe_Ajouter Modifier = new FormEquipe_Ajouter();
            Modifier.conn = conn;
            Modifier.Text = "Modification";
            Modifier.nomEquipe = DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString();
            Modifier.dateIntroLigue = DGV_Equipes.SelectedRows[0].Cells[1].Value.ToString();
            Modifier.divisionEquipe = DGV_Equipes.SelectedRows[0].Cells[2].Value.ToString();
            Modifier.villeEquipe = DGV_Equipes.SelectedRows[0].Cells[3].Value.ToString();
            Modifier.image = image;

            if (Modifier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlModif = "Update Equipes set NomEquipe =:NomEquipe, DateIntroLigue =:DateIntroLigue, LogoEquipe =:LogoEquipe, " +
                        "DivisionEquipe =:DivisionEquipe, VilleEquipe =:VilleEquipe where NomEquipe =:NomEquipe2";
                try 
                {

                    OracleCommand oraModif = new OracleCommand(sqlModif, conn);
                    
                    OracleParameter OraParaNomEquipe = new OracleParameter(":NomEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamDateIntroLigue = new OracleParameter(":DateIntroLigue", OracleDbType.Date);
                    OracleParameter OraParamLogoEquipe = new OracleParameter(":LogoEquipe", OracleDbType.Blob);  //Ajout
                    OracleParameter OraParaDivEquipe = new OracleParameter(":DivisionEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaVilleEquipe = new OracleParameter(":VilleEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaNomEquipe2 = new OracleParameter(":NomEquipe2", OracleDbType.Varchar2, 40);

                    OraParaNomEquipe.Value = Modifier.nomEquipe;
                    OraParamDateIntroLigue.Value = DateTime.Parse(Modifier.dateIntroLigue);
                    OraParamLogoEquipe.Value = image;
                    OraParaDivEquipe.Value = Modifier.divisionEquipe;
                    OraParaVilleEquipe.Value = Modifier.villeEquipe;
                    OraParaNomEquipe2.Value = DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString();

                    // Willy-kun
                    if (Modifier.image != null)
                    {
                        OraParamLogoEquipe.Value = Modifier.image;
                    }

                    oraModif.Parameters.Add(OraParaNomEquipe);
                    oraModif.Parameters.Add(OraParamDateIntroLigue);
                    oraModif.Parameters.Add(OraParamLogoEquipe);
                    oraModif.Parameters.Add(OraParaDivEquipe);
                    oraModif.Parameters.Add(OraParaVilleEquipe);
                    oraModif.Parameters.Add(OraParaNomEquipe2);

                    oraModif.ExecuteNonQuery();

                    ReloadDGV();
                
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                OracleParameter paramNomEquipe = new OracleParameter(":NomEquipe", OracleDbType.Varchar2, 40);
                paramNomEquipe.Value = DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString();
                string sqlDelete = "Delete from Equipes Where NomEquipe =:paramNomEquipe";
                OracleCommand oraDelete = new OracleCommand(sqlDelete, conn);
                oraDelete.Parameters.Add(paramNomEquipe);
                oraDelete.ExecuteNonQuery();

                ReloadDGV();
            }
            catch (OracleException ex)
            {
                if (ex.Number == 2292)
                {
                    MessageBox.Show("L'équipe ne doit pas contenir de joueurs.", "Erreur 2292", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form_Equipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void DGV_Equipes_SelectionChanged(object sender, EventArgs e)
        {
            // Such Will
            image = null;
            PB_Equipes.Image = null;

            if (DGV_Equipes.SelectedRows.Count > 0)
            {
                OracleCommand oraImage = conn.CreateCommand();
                oraImage.CommandText = "SELECT LogoEquipe FROM Equipes WHERE NomEquipe=:NomEquipe";
                oraImage.Parameters.Add(new OracleParameter(":NomEquipe", DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString()));
                using (OracleDataReader oraReader = oraImage.ExecuteReader())
                {
                    if (oraReader.Read())
                    {
                        OracleBlob oraBlob = oraReader.GetOracleBlob(0);
                        if (!oraBlob.IsNull)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                byte[] buffer = new byte[8 * 1024];
                                int read = 0;
                                while ((read = oraBlob.Read(buffer, 0, 8 * 1024)) > 0)
                                {
                                    ms.Write(buffer, 0, read);
                                }
                                image = ms.ToArray();
                                PB_Equipes.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
        }

        private void Callformjoueurs()
        {
            Form_Joueurs fj = new Form_Joueurs(DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString());
            fj.conn = conn;

            this.Hide();
            fj.callBackForm = this;
            fj.ShowDialog();
        }

        private void voirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Callformjoueurs();
        }

        private void DGV_Equipes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Callformjoueurs();
            }
        }

        private void FB_Top5_Click(object sender, EventArgs e)
        {
            Form_Top5 Top5 = new Form_Top5();
            Top5.conn = conn;

            Top5.ShowDialog();
        }
    }
}
