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
                return TB_DateCreation.Text;
            }
            set
            {
                TB_DateCreation.Text = value;
            }
        }
        public FormDivision_Ajouter()
        {
            InitializeComponent();
        }
    }
}
