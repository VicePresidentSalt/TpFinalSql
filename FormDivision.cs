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
        public FormDivision()
        {
            InitializeComponent();
        }

        private void FormDivision_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }
    }
}
