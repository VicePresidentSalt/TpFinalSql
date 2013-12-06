namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class Form_Match
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Match));
            this.label1 = new System.Windows.Forms.Label();
            this.TB_EquipeVisiteur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_EquipeHomeScore = new System.Windows.Forms.TextBox();
            this.TB_EquipeVisiteurScore = new System.Windows.Forms.TextBox();
            this.DGV_Match = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.PB_EquipeVisiteurLogo = new System.Windows.Forms.PictureBox();
            this.PB_EquipeHomeLogo = new System.Windows.Forms.PictureBox();
            this.PB_Versus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeVisiteurLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeHomeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Versus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipe Home";
            // 
            // TB_EquipeVisiteur
            // 
            this.TB_EquipeVisiteur.AutoSize = true;
            this.TB_EquipeVisiteur.Location = new System.Drawing.Point(340, 9);
            this.TB_EquipeVisiteur.Name = "TB_EquipeVisiteur";
            this.TB_EquipeVisiteur.Size = new System.Drawing.Size(77, 13);
            this.TB_EquipeVisiteur.TabIndex = 2;
            this.TB_EquipeVisiteur.Text = "Equipe Visiteur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score Final";
            // 
            // TB_EquipeHomeScore
            // 
            this.TB_EquipeHomeScore.Location = new System.Drawing.Point(40, 144);
            this.TB_EquipeHomeScore.Name = "TB_EquipeHomeScore";
            this.TB_EquipeHomeScore.Size = new System.Drawing.Size(121, 20);
            this.TB_EquipeHomeScore.TabIndex = 4;
            // 
            // TB_EquipeVisiteurScore
            // 
            this.TB_EquipeVisiteurScore.Location = new System.Drawing.Point(319, 144);
            this.TB_EquipeVisiteurScore.Name = "TB_EquipeVisiteurScore";
            this.TB_EquipeVisiteurScore.Size = new System.Drawing.Size(121, 20);
            this.TB_EquipeVisiteurScore.TabIndex = 5;
            // 
            // DGV_Match
            // 
            this.DGV_Match.AllowUserToAddRows = false;
            this.DGV_Match.AllowUserToDeleteRows = false;
            this.DGV_Match.AllowUserToOrderColumns = true;
            this.DGV_Match.AllowUserToResizeRows = false;
            this.DGV_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Match.Location = new System.Drawing.Point(17, 180);
            this.DGV_Match.Name = "DGV_Match";
            this.DGV_Match.ReadOnly = true;
            this.DGV_Match.RowHeadersVisible = false;
            this.DGV_Match.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Match.Size = new System.Drawing.Size(438, 79);
            this.DGV_Match.TabIndex = 6;
            this.DGV_Match.SelectionChanged += new System.EventHandler(this.DGV_Match_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Flashbuton Precedent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Flashbuton Suivant";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(64, 305);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(108, 23);
            this.BTN_Ajouter.TabIndex = 10;
            this.BTN_Ajouter.Text = "Ajouter Rencontre";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(308, 305);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(108, 23);
            this.BTN_Modifier.TabIndex = 11;
            this.BTN_Modifier.Text = "Modifier Rencontre";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_OK
            // 
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(187, 356);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 12;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // PB_EquipeVisiteurLogo
            // 
            this.PB_EquipeVisiteurLogo.Location = new System.Drawing.Point(319, 22);
            this.PB_EquipeVisiteurLogo.Name = "PB_EquipeVisiteurLogo";
            this.PB_EquipeVisiteurLogo.Size = new System.Drawing.Size(121, 95);
            this.PB_EquipeVisiteurLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_EquipeVisiteurLogo.TabIndex = 14;
            this.PB_EquipeVisiteurLogo.TabStop = false;
            // 
            // PB_EquipeHomeLogo
            // 
            this.PB_EquipeHomeLogo.Location = new System.Drawing.Point(40, 22);
            this.PB_EquipeHomeLogo.Name = "PB_EquipeHomeLogo";
            this.PB_EquipeHomeLogo.Size = new System.Drawing.Size(121, 95);
            this.PB_EquipeHomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_EquipeHomeLogo.TabIndex = 13;
            this.PB_EquipeHomeLogo.TabStop = false;
            // 
            // PB_Versus
            // 
            this.PB_Versus.Image = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources.Logo___Versus_bmp1;
            this.PB_Versus.Location = new System.Drawing.Point(179, 22);
            this.PB_Versus.Name = "PB_Versus";
            this.PB_Versus.Size = new System.Drawing.Size(109, 95);
            this.PB_Versus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Versus.TabIndex = 0;
            this.PB_Versus.TabStop = false;
            // 
            // Form_Match
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 391);
            this.Controls.Add(this.PB_EquipeVisiteurLogo);
            this.Controls.Add(this.PB_EquipeHomeLogo);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGV_Match);
            this.Controls.Add(this.TB_EquipeVisiteurScore);
            this.Controls.Add(this.TB_EquipeHomeScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_EquipeVisiteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_Versus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Match";
            this.Text = "Afficheur De Match";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Match_FormClosed);
            this.Load += new System.EventHandler(this.Form_Match_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeVisiteurLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_EquipeHomeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Versus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Versus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TB_EquipeVisiteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_EquipeHomeScore;
        private System.Windows.Forms.TextBox TB_EquipeVisiteurScore;
        private System.Windows.Forms.DataGridView DGV_Match;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.PictureBox PB_EquipeHomeLogo;
        private System.Windows.Forms.PictureBox PB_EquipeVisiteurLogo;
    }
}