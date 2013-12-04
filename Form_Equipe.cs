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
    public partial class Form_Equipe : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        public string division = null;
        private DataSet equipeDataSet = null;

        private void ReloadDGV()
        {
            OracleDataAdapter oraAdapter = new OracleDataAdapter("SELECT NomEquipe, DateIntroLigue,DivisionEquipe,VilleEquipe FROM Equipes E inner join Divisions D on D.NomDivision = E.DivisionEquipe "+
            "where DivisionEquipe = '" + division+"'", conn);
            equipeDataSet = new DataSet();
            oraAdapter.Fill(equipeDataSet);
            DGV_Equipe.DataSource = equipeDataSet.Tables[0];
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
                string sqlAjout = "insert into Equipes (NomEquipe,DateIntroLigue,DivisionEquipe,VilleEquipe)" +
                    " VALUES(:NomEquipe,:DateIntroLigue,:DivisionEquipe,:VilleEquipe)";
                try 
                {
                    OracleParameter OraParaNomEquipe = new OracleParameter(":NomEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamDateIntroLigue = new OracleParameter(":DateIntroLigue", OracleDbType.Date);
                    OracleParameter OraParaDivEquipe = new OracleParameter(":DivisionEquipe", OracleDbType.Varchar2, 40);
                    OracleParameter OraParaVilleEquipe = new OracleParameter(":VilleEquipe", OracleDbType.Varchar2, 40);

                    OraParaNomEquipe.Value = Ajouter.nomEquipe;
                    OraParamDateIntroLigue.Value = DateTime.Parse(Ajouter.dateIntroLigue);
                    OraParaDivEquipe.Value = Ajouter.divisionEquipe;
                    OraParaVilleEquipe.Value = Ajouter.villeEquipe;

                    OracleCommand oraAjout = new OracleCommand(sqlAjout, conn);

                    oraAjout.Parameters.Add(OraParaNomEquipe);
                    oraAjout.Parameters.Add(OraParamDateIntroLigue);
                    oraAjout.Parameters.Add(OraParaDivEquipe);
                    oraAjout.Parameters.Add(OraParaVilleEquipe);

                    oraAjout.ExecuteNonQuery();

                    ReloadDGV();

                 
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }       
        
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            FormEquipe_Ajouter Modifier = new FormEquipe_Ajouter();
            Modifier.nomEquipe = DGV_Equipe.SelectedRows[0].Cells[0].Value.ToString();
            Modifier.dateIntroLigue = DGV_Equipe.SelectedRows[0].Cells[1].Value.ToString();
            Modifier.divisionEquipe = DGV_Equipe.SelectedRows[0].Cells[2].Value.ToString();
            Modifier.villeEquipe = DGV_Equipe.SelectedRows[0].Cells[3].Value.ToString();

            if (Modifier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string sqlModif = "Update Equipes set NomEquipe =:NomEquipe, DateIntroLigue =:DateIntroLigue, " +
                        "DivisionEquipe =:DivisionEquipe, VilleEquipe =:VilleEquipe where NomEquipe =:NomEquipe2";
                    //Why division2 ?? Updater la row avc l'ancien nom de division
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
                    OraParaNomEquipe2.Value = DGV_Equipe.SelectedRows[0].Cells[0].Value.ToString();


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
            paramNomEquipe.Value = DGV_Equipe.SelectedRows[0].Cells[0].Value.ToString();
            string sqlDelete = "Delete from Equipes Where NomEquipe =:paramNomEquipe";
            OracleCommand oraDelete = new OracleCommand(sqlDelete, conn);

            oraDelete.Parameters.Add(paramNomEquipe);
            oraDelete.ExecuteNonQuery();
            ReloadDGV();
        }
    }
}
