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
    public partial class FormDivision : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;

        private DataSet divisionDataSet = null;

        private void ReloadDGV()
        {
            OracleDataAdapter oraAdapter = new OracleDataAdapter("SELECT NomDivision, DateCreation FROM Divisions", conn);
            divisionDataSet = new DataSet();
            oraAdapter.Fill(divisionDataSet);
            DGV_Division.DataSource = divisionDataSet.Tables[0];
        }

        public FormDivision()
        {
            InitializeComponent();
        }
        private void SaveSettings()
        {
            try
            {
                Properties.Settings.Default.MainFormLocation = this.Location;
                Properties.Settings.Default.MainFormSize = this.Size;
                Properties.Settings.Default.Save();
            }
            catch
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
            }
        }
        private void LoadSettings()
        {
            try
            {
                this.Location = Properties.Settings.Default.MainFormLocation;
                this.Size = Properties.Settings.Default.MainFormSize;
            }
            catch
            {
                Properties.Settings.Default.Reset();
            }
        }

        private void FormDivision_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }

        private void FormDivision_Load(object sender, EventArgs e)
        {
            ReloadDGV();
            LoadSettings();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            callBackForm.Close();
        }

        private void BTN_Deconnexion_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
            callBackForm.Show();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            FormDivision_Ajouter Ajouter = new FormDivision_Ajouter();
            if (Ajouter.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string sqlAjout = "insert into Divisions (NomDivision,DateCreation)" +
                    " VALUES(:NomDivision,:DateCreation)";
                try 
                {
                    OracleParameter OraParaNomDiv = new OracleParameter(":NomDivision", OracleDbType.Varchar2, 40);
                    OracleParameter OraParamDateCreation = new OracleParameter(":DateCreation", OracleDbType.Date);

                    OraParaNomDiv.Value = Ajouter.nomDivision;
                    OraParamDateCreation.Value = DateTime.Parse(Ajouter.dateCreation);

                    OracleCommand oraAjout = new OracleCommand(sqlAjout, conn);

                    oraAjout.Parameters.Add(OraParaNomDiv);
                    oraAjout.Parameters.Add(OraParamDateCreation);

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
            FormDivision_Ajouter Modifier = new FormDivision_Ajouter();
            Modifier.nomDivision = DGV_Division.SelectedRows[0].Cells[0].Value.ToString();
            Modifier.dateCreation = DGV_Division.SelectedRows[0].Cells[1].Value.ToString();
            if (Modifier.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string sqlModif = "Update Divisions set NomDivision =:NomDivision, DateCreation =:DateCreation " +
                        "where NomDivision =:NomDivision2";
                    //Why division2 ?? Updater la row avc l'ancien nom de division
                    OracleCommand oraUpdate = new OracleCommand(sqlModif, conn);

                    OracleParameter paramNomDivision = new OracleParameter(":NomDivision", OracleDbType.Varchar2, 40);
                    OracleParameter paramDateCreation = new OracleParameter(":DateCreation", OracleDbType.Date);
                    OracleParameter paramNomDivision2 = new OracleParameter(":NomDivision2", OracleDbType.Varchar2, 40);

                    paramNomDivision.Value = Modifier.nomDivision;
                    paramDateCreation.Value = DateTime.Parse(Modifier.dateCreation);
                    paramNomDivision2.Value = DGV_Division.SelectedRows[0].Cells[0].Value.ToString();


                    oraUpdate.Parameters.Add(paramNomDivision);
                    oraUpdate.Parameters.Add(paramDateCreation);
                    oraUpdate.Parameters.Add(paramNomDivision2);

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
            OracleParameter paramNomDivision = new OracleParameter(":NomDivision", OracleDbType.Varchar2, 40);
            paramNomDivision.Value = DGV_Division.SelectedRows[0].Cells[0].Value.ToString();
            string sqlDelete = "Delete from Divisions Where NomDivision =:paramNomDivision";
            OracleCommand oraDelete = new OracleCommand(sqlDelete, conn);

            oraDelete.Parameters.Add(paramNomDivision);
            oraDelete.ExecuteNonQuery();
            ReloadDGV();

        }

        private void FormDivision_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}
