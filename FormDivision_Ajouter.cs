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
    public partial class FormDivision_Ajouter : Form
    {
        public string nomDivision
        {
            get
            {
                return TB_NomDivision.Text;
            }
            set
            {
                TB_NomDivision.Text = value;
            }
        }
        public string dateCreation
        {
            get 
            {
                return DTP_Ajout.Value.ToShortDateString();
            }
            set
            {
                DTP_Ajout.Value = DateTime.Parse(value);
            }
        }
        public FormDivision_Ajouter()
        {
            InitializeComponent();
        }

        private void FormDivision_Ajouter_Load(object sender, EventArgs e)
        {

        }
    }
}
