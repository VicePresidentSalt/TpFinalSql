namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class Form_Joueurs_Ajouter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Joueurs_Ajouter));
            this.BF_Precedent = new BoutonFlèche.BoutonFlèche();
            this.BF_Suivant = new BoutonFlèche.BoutonFlèche();
            this.BF_Debut = new BoutonFlèche.BoutonFlèche();
            this.BF_Dernier = new BoutonFlèche.BoutonFlèche();
            this.CB_PositionJoueur = new System.Windows.Forms.ComboBox();
            this.CB_EquipeJoueur = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_DateNaissanceJoueur = new System.Windows.Forms.DateTimePicker();
            this.TB_NumeroMaillotJoueur = new System.Windows.Forms.TextBox();
            this.TB_PrenomJoueur = new System.Windows.Forms.TextBox();
            this.TB_NomJoueur = new System.Windows.Forms.TextBox();
            this.TB_NumeroJoueur = new System.Windows.Forms.TextBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BF_Precedent
            // 
            this.BF_Precedent.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Aigu;
            this.BF_Precedent.ClickColor = System.Drawing.Color.White;
            this.BF_Precedent.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Gauche;
            this.BF_Precedent.Enabled = false;
            this.BF_Precedent.EnterColor = System.Drawing.Color.LightGray;
            this.BF_Precedent.LeaveColor = System.Drawing.Color.Black;
            this.BF_Precedent.Location = new System.Drawing.Point(52, 249);
            this.BF_Precedent.Name = "BF_Precedent";
            this.BF_Precedent.Size = new System.Drawing.Size(37, 31);
            this.BF_Precedent.TabIndex = 43;
            // 
            // BF_Suivant
            // 
            this.BF_Suivant.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Aigu;
            this.BF_Suivant.ClickColor = System.Drawing.Color.White;
            this.BF_Suivant.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Droit;
            this.BF_Suivant.Enabled = false;
            this.BF_Suivant.EnterColor = System.Drawing.Color.LightGray;
            this.BF_Suivant.LeaveColor = System.Drawing.Color.Black;
            this.BF_Suivant.Location = new System.Drawing.Point(194, 249);
            this.BF_Suivant.Name = "BF_Suivant";
            this.BF_Suivant.Size = new System.Drawing.Size(37, 31);
            this.BF_Suivant.TabIndex = 42;
            // 
            // BF_Debut
            // 
            this.BF_Debut.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Triangle;
            this.BF_Debut.ClickColor = System.Drawing.Color.White;
            this.BF_Debut.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Gauche;
            this.BF_Debut.Enabled = false;
            this.BF_Debut.EnterColor = System.Drawing.Color.LightGray;
            this.BF_Debut.LeaveColor = System.Drawing.Color.Black;
            this.BF_Debut.Location = new System.Drawing.Point(9, 249);
            this.BF_Debut.Name = "BF_Debut";
            this.BF_Debut.Size = new System.Drawing.Size(37, 31);
            this.BF_Debut.TabIndex = 41;
            // 
            // BF_Dernier
            // 
            this.BF_Dernier.Apparence = BoutonFlèche.BoutonFlèche.ApparenceType.Triangle;
            this.BF_Dernier.ClickColor = System.Drawing.Color.White;
            this.BF_Dernier.Direction = BoutonFlèche.BoutonFlèche.DirectionType.Droit;
            this.BF_Dernier.Enabled = false;
            this.BF_Dernier.EnterColor = System.Drawing.Color.LightGray;
            this.BF_Dernier.LeaveColor = System.Drawing.Color.Black;
            this.BF_Dernier.Location = new System.Drawing.Point(237, 249);
            this.BF_Dernier.Name = "BF_Dernier";
            this.BF_Dernier.Size = new System.Drawing.Size(37, 31);
            this.BF_Dernier.TabIndex = 40;
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
            this.CB_PositionJoueur.Location = new System.Drawing.Point(146, 209);
            this.CB_PositionJoueur.Name = "CB_PositionJoueur";
            this.CB_PositionJoueur.Size = new System.Drawing.Size(129, 21);
            this.CB_PositionJoueur.TabIndex = 38;
            // 
            // CB_EquipeJoueur
            // 
            this.CB_EquipeJoueur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_EquipeJoueur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_EquipeJoueur.FormattingEnabled = true;
            this.CB_EquipeJoueur.Location = new System.Drawing.Point(146, 168);
            this.CB_EquipeJoueur.Name = "CB_EquipeJoueur";
            this.CB_EquipeJoueur.Size = new System.Drawing.Size(129, 21);
            this.CB_EquipeJoueur.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Position du joueur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Équipe du joueur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Numero de maillot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Date de Naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Prénom du joueur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nom du Joueur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, -18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Numero Joueur";
            // 
            // DTP_DateNaissanceJoueur
            // 
            this.DTP_DateNaissanceJoueur.Location = new System.Drawing.Point(146, 96);
            this.DTP_DateNaissanceJoueur.Name = "DTP_DateNaissanceJoueur";
            this.DTP_DateNaissanceJoueur.Size = new System.Drawing.Size(129, 20);
            this.DTP_DateNaissanceJoueur.TabIndex = 32;
            // 
            // TB_NumeroMaillotJoueur
            // 
            this.TB_NumeroMaillotJoueur.Location = new System.Drawing.Point(146, 134);
            this.TB_NumeroMaillotJoueur.Name = "TB_NumeroMaillotJoueur";
            this.TB_NumeroMaillotJoueur.Size = new System.Drawing.Size(129, 20);
            this.TB_NumeroMaillotJoueur.TabIndex = 34;
            // 
            // TB_PrenomJoueur
            // 
            this.TB_PrenomJoueur.Location = new System.Drawing.Point(146, 60);
            this.TB_PrenomJoueur.Name = "TB_PrenomJoueur";
            this.TB_PrenomJoueur.Size = new System.Drawing.Size(129, 20);
            this.TB_PrenomJoueur.TabIndex = 30;
            // 
            // TB_NomJoueur
            // 
            this.TB_NomJoueur.Location = new System.Drawing.Point(146, 21);
            this.TB_NomJoueur.Name = "TB_NomJoueur";
            this.TB_NomJoueur.Size = new System.Drawing.Size(129, 20);
            this.TB_NomJoueur.TabIndex = 28;
            // 
            // TB_NumeroJoueur
            // 
            this.TB_NumeroJoueur.Enabled = false;
            this.TB_NumeroJoueur.Location = new System.Drawing.Point(146, -18);
            this.TB_NumeroJoueur.Name = "TB_NumeroJoueur";
            this.TB_NumeroJoueur.Size = new System.Drawing.Size(129, 20);
            this.TB_NumeroJoueur.TabIndex = 26;
            // 
            // BTN_OK
            // 
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(52, 286);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 25);
            this.BTN_OK.TabIndex = 39;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Cancel.Location = new System.Drawing.Point(156, 286);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 25);
            this.BTN_Cancel.TabIndex = 39;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // Form_Joueurs_Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 323);
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
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(299, 339);
            this.Name = "Form_Joueurs_Ajouter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BoutonFlèche.BoutonFlèche BF_Precedent;
        private BoutonFlèche.BoutonFlèche BF_Suivant;
        private BoutonFlèche.BoutonFlèche BF_Debut;
        private BoutonFlèche.BoutonFlèche BF_Dernier;
        private System.Windows.Forms.ComboBox CB_PositionJoueur;
        private System.Windows.Forms.ComboBox CB_EquipeJoueur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP_DateNaissanceJoueur;
        private System.Windows.Forms.TextBox TB_NumeroMaillotJoueur;
        private System.Windows.Forms.TextBox TB_PrenomJoueur;
        private System.Windows.Forms.TextBox TB_NomJoueur;
        private System.Windows.Forms.TextBox TB_NumeroJoueur;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}