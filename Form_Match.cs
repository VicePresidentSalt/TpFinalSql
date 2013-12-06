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
    public partial class Form_Match : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        public DataSet MatchDataSet = null;

        public Form_Match()
        {
            InitializeComponent();
        }

        private void Form_Match_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
        }
    }
}
