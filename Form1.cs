using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    public partial class Login : Form
    {
        private OracleConnection conn = new OracleConnection();

        public Login()
        {
            InitializeComponent();
        }

        private void BTN_Quitter_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        private void BTN_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                string Dsource = "(DESCRIPTION="
               + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
               + "(HOST=205.237.244.251)(PORT=1521)))"
               + "(CONNECT_DATA=(SERVICE_NAME=ORCL)))";

                String ChaineConnexion = "Data Source=" + Dsource
                + ";User Id=" + TB_Username.Text + " ; Password =" + TB_Password.Text;
                conn.ConnectionString = ChaineConnexion;

                conn.Open();

                 MessageBox.Show(conn.State.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
