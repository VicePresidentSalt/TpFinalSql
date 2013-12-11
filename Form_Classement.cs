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
    public partial class Form_Classement : Form
    {
        public OracleConnection conn = null;
        public Form callBackForm = null;
        private DataSet ClassementDataSet = null;

        public Form_Classement()
        {
            InitializeComponent();
        }
    }
}
