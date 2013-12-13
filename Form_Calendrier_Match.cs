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
    public partial class Form_Calendrier_Match : Form
    {
        public Form callBackForm = null;
        public OracleConnection conn = null;
        public Form_Calendrier_Match()
        {
            InitializeComponent();
        }

        private void Form_Calendrier_Match_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (callBackForm != null)
                callBackForm.Show();
            
        }

        private void Form_Calendrier_Match_Load(object sender, EventArgs e)
        {
            ReloadDGV();
        }

        private void ReloadDGV()
        { 
           // if(Calendrier_Match.
        }

        
    }
}
