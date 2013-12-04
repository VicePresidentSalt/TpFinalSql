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

namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    public partial class Form_Equipe : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        public string division = null;
        private DataSet equipeDataSet = null;
        string nomFichier;

        private void ReloadDGV()
        {
            OracleDataAdapter oraAdapter = new OracleDataAdapter("SELECT NomEquipe, DateIntroLigue,DivisionEquipe,VilleEquipe FROM Equipes E inner join Divisions D on D.NomDivision = E.DivisionEquipe "+
            "where DivisionEquipe = '" + division+"'", conn);
            string sql = "SELECT LOGOEQUIPE FROM EQUIPES";
            OracleDataAdapter oraAdapterLogo= new OracleDataAdapter(sql,conn);
            oraAdapterLogo.Fill(equipeDataSet, "Logo");
            equipeDataSet = new DataSet();
            oraAdapter.Fill(equipeDataSet);
            DGV_Equipes.DataSource = equipeDataSet.Tables[0];
            PB_Equipes.DataBindings.Add("Image", equipeDataSet, "Logo.LogoEquipe",true);
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
            if (Ajouter.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                nomFichier = Ajouter.nomFichier;
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
                    OraParamLogoEquipe.Value = Ajouter.nomFichier;
                    OraParaDivEquipe.Value = Ajouter.divisionEquipe;
                    OraParaVilleEquipe.Value = Ajouter.villeEquipe;

                    // récuper le fichier nomFichier et le convertir en Byte. 
                    //le résultat est dans buffer1
                    // oracle stocke les images sous forme de Bytes.
                    if (nomFichier != null)
                    {
                        FileStream Streamp = new FileStream(nomFichier, FileMode.Open, FileAccess.Read);
                        byte[] buffer1 = new byte[Streamp.Length];
                        Streamp.Read(buffer1, 0, System.Convert.ToInt32(Streamp.Length));
                        Streamp.Close();

                        // ajout de la photo dans la BD.

                        OraParamLogoEquipe.Value = buffer1;
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
            Modifier.nomEquipe = DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString();
            Modifier.dateIntroLigue = DGV_Equipes.SelectedRows[0].Cells[1].Value.ToString();
            Modifier.divisionEquipe = DGV_Equipes.SelectedRows[0].Cells[2].Value.ToString();
            Modifier.villeEquipe = DGV_Equipes.SelectedRows[0].Cells[3].Value.ToString();

            if (Modifier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string sqlModif = "Update Equipes set NomEquipe =:NomEquipe, DateIntroLigue =:DateIntroLigue, " +
                        "DivisionEquipe =:DivisionEquipe, VilleEquipe =:VilleEquipe where NomEquipe =:NomEquipe2";
                    //Why NomEquipe2 ?? Updater la row avc l'ancien nom de l'équipe
                    OracleCommand oraUpdate = new OracleCommand(sqlModif, conn);

                    OracleParameter OraParaNomEquipe = new OracleParameter(":NomEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamDateIntroLigue = new OracleParameter(":DateIntroLigue", OracleDbType.Date);
                    OracleParameter OraParaDivEquipe = new OracleParameter(":DivisionEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaVilleEquipe = new OracleParameter(":VilleEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaNomEquipe2 = new OracleParameter(":NomEquipe2", OracleDbType.Varchar2, 40);


                    OraParaNomEquipe.Value = Modifier.nomEquipe;
                    OraParamDateIntroLigue.Value = DateTime.Parse(Modifier.dateIntroLigue);
                    OraParaDivEquipe.Value = Modifier.divisionEquipe;
                    OraParaVilleEquipe.Value = Modifier.villeEquipe;
                    OraParaNomEquipe2.Value = DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString();


                    oraUpdate.Parameters.Add(OraParaNomEquipe);
                    oraUpdate.Parameters.Add(OraParamDateIntroLigue);
                    oraUpdate.Parameters.Add(OraParaDivEquipe);
                    oraUpdate.Parameters.Add(OraParaVilleEquipe);
                    oraUpdate.Parameters.Add(OraParaNomEquipe2);


                    oraUpdate.ExecuteNonQuery();

                    ReloadDGV();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            OracleParameter paramNomEquipe = new OracleParameter(":NomEquipe", OracleDbType.Varchar2, 40);
            paramNomEquipe.Value = DGV_Equipes.SelectedRows[0].Cells[0].Value.ToString();
            string sqlDelete = "Delete from Equipes Where NomEquipe =:paramNomEquipe";
            OracleCommand oraDelete = new OracleCommand(sqlDelete, conn);

            oraDelete.Parameters.Add(paramNomEquipe);
            oraDelete.ExecuteNonQuery();
            ReloadDGV();
        }

        private string RechercherFichier()
        {

            OpenFileDialog fImage = new OpenFileDialog();

            fImage.Title = "selectionner une image";
            fImage.CheckFileExists = true;
            fImage.InitialDirectory = @":C\";

            //fImage.InitialDirectory = Application.StartupPath;
            fImage.Filter = "Fichiers images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            fImage.FilterIndex = 1;
            fImage.RestoreDirectory = true;

            if (fImage.ShowDialog() == DialogResult.OK)
            {
                nomFichier = fImage.FileName;
                Bitmap bitmap1 = new Bitmap(nomFichier);
            }
            else
            {
                nomFichier = null;
            }
            return nomFichier;
        }

        private void Form_Equipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void DGV_Equipe_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }



    }
}
