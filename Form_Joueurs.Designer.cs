namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class Form_Joueurs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Joueurs));
            this.BTN_OK = new System.Windows.Forms.Button();
            this.TB_NumeroJoueur = new System.Windows.Forms.TextBox();
            this.TB_NomJoueur = new System.Windows.Forms.TextBox();
            this.TB_PrenomJoueur = new System.Windows.Forms.TextBox();
            this.TB_NumeroMaillotJoueur = new System.Windows.Forms.TextBox();
            this.DTP_DateNaissanceJoueur = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_EquipeJoueur = new System.Windows.Forms.ComboBox();
            this.CB_PositionJoueur = new System.Windows.Forms.ComboBox();
            this.BF_Dernier = new BoutonFlèche.BoutonFlèche();
            this.BF_Debut = new BoutonFlèche.BoutonFlèche();
            this.BF_Suivant = new BoutonFlèche.BoutonFlèche();
            this.BF_Precedent = new BoutonFlèche.BoutonFlèche();
            this.SuspendLayout();
            // 
            // BTN_OK
            // 
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(120, 302);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 25);
            this.BTN_OK.TabIndex = 17;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // TB_NumeroJoueur
            // 
            this.TB_NumeroJoueur.Enabled = false;
            this.TB_NumeroJoueur.Location = new System.Drawing.Point(162, 29);
            this.TB_NumeroJoueur.Name = "TB_NumeroJoueur";
            this.TB_NumeroJoueur.Size = new System.Drawing.Size(129, 20);
            this.TB_NumeroJoueur.TabIndex = 1;
            // 
            // TB_NomJoueur
            // 
            this.TB_NomJoueur.Location = new System.Drawing.Point(162, 68);
            this.TB_NomJoueur.Name = "TB_NomJoueur";
            this.TB_NomJoueur.Size = new System.Drawing.Size(129, 20);
            this.TB_NomJoueur.TabIndex = 3;
            // 
            // TB_PrenomJoueur
            // 
            this.TB_PrenomJoueur.Location = new System.Drawing.Point(162, 107);
            this.TB_PrenomJoueur.Name = "TB_PrenomJoueur";
            this.TB_PrenomJoueur.Size = new System.Drawing.Size(129, 20);
            this.TB_PrenomJoueur.TabIndex = 5;
            // 
            // TB_NumeroMaillotJoueur
            // 
            this.TB_NumeroMaillotJoueur.Location = new System.Drawing.Point(162, 181);
            this.TB_NumeroMaillotJoueur.Name = "TB_NumeroMaillotJoueur";
            this.TB_NumeroMaillotJoueur.Size = new System.Drawing.Size(129, 20);
            this.TB_NumeroMaillotJoueur.TabIndex = 9;
            // 
            // DTP_DateNaissanceJoueur
            // 
            this.DTP_DateNaissanceJoueur.Location = new System.Drawing.Point(162, 143);
            this.DTP_DateNaissanceJoueur.Name = "DTP_DateNaissanceJoueur";
            this.DTP_DateNaissanceJoueur.Size = new System.Drawing.Size(129, 20);
            this.DTP_DateNaissanceJoueur.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero Joueur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom du Joueur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prénom du joueur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date de Naissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Numero de maillot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Équipe du joueur";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Position du joueur";
            // 
            // CB_EquipeJoueur
            // 
            this.CB_EquipeJoueur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_EquipeJoueur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_EquipeJoueur.FormattingEnabled = true;
            this.CB_EquipeJoueur.Location = new System.Drawing.Point(162, 215);
            this.CB_EquipeJoueur.Name = "CB_EquipeJoueur";
            this.CB_EquipeJoueur.Size = new System.Drawing.Size(129, 21);
            this.CB_EquipeJoueur.TabIndex = 11;
            // 
            // CB_PositionJoueur
            // 
            this.CB_PositionJoueur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_PositionJoueur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_PositionJoueur.FormattingEnabled = true;
            this.CB_PositionJoueur.Items.AddRange(new object[] {
            "Attaquant",
            "Defenseur",
            "Gardien"});
            this.CB_PositionJoueur.Location = new System.Drawing.Point(162, 256);
            this.CB_PositionJoueur.Name = "CB_PositionJoueur";
            this.CB_PositionJoueur.Size = new System.Drawing.Size(129, 21);
            this.CB_PositionJoueur.TabIndex = 13;
            // 
            // BF_Dernier
            // 
            this.BF_Dernier.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Triangle;
            this.BF_Dernier.ClickColor = System.Drawing.Color.White;
            this.BF_Dernier.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Droit;
            this.BF_Dernier.EnterColor = System.Drawing.Color.LightGray;
            this.BF_Dernier.LeaveColor = System.Drawing.Color.Black;
            this.BF_Dernier.Location = new System.Drawing.Point(253, 296);
            this.BF_Dernier.Name = "BF_Dernier";
            this.BF_Dernier.Size = new System.Drawing.Size(37, 31);
            this.BF_Dernier.TabIndex = 21;
            this.BF_Dernier.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BF_Dernier_MouseClick);
            // 
            // BF_Debut
            // 
            this.BF_Debut.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Triangle;
            this.BF_Debut.ClickColor = System.Drawing.Color.White;
            this.BF_Debut.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Gauche;
            this.BF_Debut.EnterColor = System.Drawing.Color.LightGray;
            this.BF_Debut.LeaveColor = System.Drawing.Color.Black;
            this.BF_Debut.Location = new System.Drawing.Point(25, 296);
            this.BF_Debut.Name = "BF_Debut";
            this.BF_Debut.Size = new System.Drawing.Size(37, 31);
            this.BF_Debut.TabIndex = 22;
            this.BF_Debut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BF_Debut_MouseClick);
            // 
            // BF_Suivant
            // 
            this.BF_Suivant.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Aigu;
            this.BF_Suivant.ClickColor = System.Drawing.Color.White;
            this.BF_Suivant.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Droit;
            this.BF_Suivant.EnterColor = System.Drawing.Color.LightGray;
            this.BF_Suivant.LeaveColor = System.Drawing.Color.Black;
            this.BF_Suivant.Location = new System.Drawing.Point(210, 296);
            this.BF_Suivant.Name = "BF_Suivant";
            this.BF_Suivant.Size = new System.Drawing.Size(37, 31);
            this.BF_Suivant.TabIndex = 23;
            this.BF_Suivant.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BF_Suivant_MouseClick);
            // 
            // BF_Precedent
            // 
            this.BF_Precedent.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Aigu;
            this.BF_Precedent.ClickColor = System.Drawing.Color.White;
            this.BF_Precedent.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Gauche;
            this.BF_Precedent.EnterColor = System.Drawing.Color.LightGray;
            this.BF_Precedent.LeaveColor = System.Drawing.Color.Black;
            this.BF_Precedent.Location = new System.Drawing.Point(68, 296);
            this.BF_Precedent.Name = "BF_Precedent";
            this.BF_Precedent.Size = new System.Drawing.Size(37, 31);
            this.BF_Precedent.TabIndex = 24;
            this.BF_Precedent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BF_Precedent_MouseClick);
            // 
            // Form_Joueurs
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 382);
            this.Controls.Add(this.BF_Precedent);
            this.Controls.Add(this.BF_Suivant);
            this.Controls.Add(this.BF_Debut);
            this.Controls.Add(this.BF_Dernier);
            this.Controls.Add(this.CB_PositionJoueur);
            this.Controls.Add(this.CB_EquipeJoueur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTP_DateNaissanceJoueur);
            this.Controls.Add(this.TB_NumeroMaillotJoueur);
            this.Controls.Add(this.TB_PrenomJoueur);
            this.Controls.Add(this.TB_NomJoueur);
            this.Controls.Add(this.TB_NumeroJoueur);
            this.Controls.Add(this.BTN_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Joueurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiche des Joueurs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Joueurs_FormClosed);
            this.Load += new System.EventHandler(this.Form_Joueurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.TextBox TB_NumeroJoueur;
        private System.Windows.Forms.TextBox TB_NomJoueur;
        private System.Windows.Forms.TextBox TB_PrenomJoueur;
        private System.Windows.Forms.TextBox TB_NumeroMaillotJoueur;
        private System.Windows.Forms.DateTimePicker DTP_DateNaissanceJoueur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_EquipeJoueur;
        private System.Windows.Forms.ComboBox CB_PositionJoueur;
        private BoutonFlèche.BoutonFlèche BF_Dernier;
        private BoutonFlèche.BoutonFlèche BF_Debut;
        private BoutonFlèche.BoutonFlèche BF_Suivant;
        private BoutonFlèche.BoutonFlèche BF_Precedent;

    }
}