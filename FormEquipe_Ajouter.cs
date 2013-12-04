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
    public partial class FormEquipe_Ajouter : Form
    {
        public string nomEquipe
        {
            get
            {
                return TB_NomEquipe.Text;
            }
            set 
            {
                TB_NomEquipe.Text = value;
            }
        }
        public string dateIntroLigue
        {
            get
            {
                return DTP_DateCreationEquipe.Value.ToShortDateString();
            }
            set
            {
                DTP_DateCreationEquipe.Value = DateTime.Parse(value);
            } 
        }
        public string divisionEquipe
        {
            get
            {
                return TB_DivisionEquipe.Text;
            }
            set
            {
                TB_DivisionEquipe.Text = value;
            }
        }
        public string villeEquipe
        {
            get
            {
                return TB_VilleEquipe.Text;
            }
            set
            {
                TB_VilleEquipe.Text = value;
            }
        }
        
        public FormEquipe_Ajouter()
        {
            InitializeComponent();
        }
    }
}
