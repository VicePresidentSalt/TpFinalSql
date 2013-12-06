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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_EquipeVisiteur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_EquipeHome = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DGV_Match = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources.Logo___Versus_bmp;
            this.pictureBox1.Location = new System.Drawing.Point(179, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipe Home";
            // 
            // TB_EquipeVisiteur
            // 
            this.TB_EquipeVisiteur.AutoSize = true;
            this.TB_EquipeVisiteur.Location = new System.Drawing.Point(340, 55);
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
            // TB_EquipeHome
            // 
            this.TB_EquipeHome.Location = new System.Drawing.Point(40, 144);
            this.TB_EquipeHome.Name = "TB_EquipeHome";
            this.TB_EquipeHome.Size = new System.Drawing.Size(121, 20);
            this.TB_EquipeHome.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 5;
            // 
            // DGV_Match
            // 
            this.DGV_Match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Match.Location = new System.Drawing.Point(64, 204);
            this.DGV_Match.Name = "DGV_Match";
            this.DGV_Match.Size = new System.Drawing.Size(353, 33);
            this.DGV_Match.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DGV avec les infos personnelle d\'un joueur but/passe/timepunition";
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
            this.BTN_Ajouter.Location = new System.Drawing.Point(40, 305);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(108, 23);
            this.BTN_Ajouter.TabIndex = 10;
            this.BTN_Ajouter.Text = "Ajouter Rencontre";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            // 
            // Form_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 349);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGV_Match);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TB_EquipeHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_EquipeVisiteur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Match";
            this.Text = "Form_Match";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Match)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TB_EquipeVisiteur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_EquipeHome;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView DGV_Match;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Ajouter;
    }
}