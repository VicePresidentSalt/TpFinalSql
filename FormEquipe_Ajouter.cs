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
        public string nomFichier =" ";
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

        private string RechercherFichier()
        {

            OpenFileDialog fImage = new OpenFileDialog();

            fImage.Title = "selectionner une image";
            fImage.CheckFileExists = true;
            fImage.InitialDirectory = @":C\";

            //fImage.InitialDirectory = Application.StartupPath;
            fImage.Filter = "Fichiers images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            fImage.FilterIndex = 1;
            fImage.RestoreDirectory = true;

            if (fImage.ShowDialog() == DialogResult.OK)
            {
                nomFichier = fImage.FileName;
                Bitmap bitmap1 = new Bitmap(nomFichier);


            }
            else
            {
                nomFichier = null;
            }
            return nomFichier;
        }
        
        private void BTN_ChargerImage_Click(object sender, EventArgs e)
        {

            string nomFichier;
            nomFichier = RechercherFichier();
            if (nomFichier != null)
            {
                PB_Equipes.Image = System.Drawing.Image.FromFile(nomFichier);
                PB_Equipes.ImageLocation = nomFichier;
            }
        }

    }
}
