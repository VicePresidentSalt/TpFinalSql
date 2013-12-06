namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class FormEquipe_Ajouter
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
            this.DTP_DateCreationEquipe = new System.Windows.Forms.DateTimePicker();
            this.TB_NomEquipe = new System.Windows.Forms.TextBox();
            this.TB_VilleEquipe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_ChargerImage = new System.Windows.Forms.Button();
            this.PB_Equipes = new System.Windows.Forms.PictureBox();
            this.CB_DivisionEquipe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipes)).BeginInit();
            this.SuspendLayout();
            // 
            // DTP_DateCreationEquipe
            // 
            this.DTP_DateCreationEquipe.Location = new System.Drawing.Point(117, 45);
            this.DTP_DateCreationEquipe.Name = "DTP_DateCreationEquipe";
            this.DTP_DateCreationEquipe.Size = new System.Drawing.Size(138, 20);
            this.DTP_DateCreationEquipe.TabIndex = 3;
            // 
            // TB_NomEquipe
            // 
            this.TB_NomEquipe.Location = new System.Drawing.Point(117, 12);
            this.TB_NomEquipe.Name = "TB_NomEquipe";
            this.TB_NomEquipe.Size = new System.Drawing.Size(138, 20);
            this.TB_NomEquipe.TabIndex = 1;
            // 
            // TB_VilleEquipe
            // 
            this.TB_VilleEquipe.Location = new System.Drawing.Point(117, 112);
            this.TB_VilleEquipe.Name = "TB_VilleEquipe";
            this.TB_VilleEquipe.Size = new System.Drawing.Size(138, 20);
            this.TB_VilleEquipe.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de l\'équipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date de création";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Division de l\'équipe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ville de l\'équipe";
            // 
            // BTN_OK
            // 
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(24, 152);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 9;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(167, 152);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 10;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // BTN_ChargerImage
            // 
            this.BTN_ChargerImage.Location = new System.Drawing.Point(273, 110);
            this.BTN_ChargerImage.Name = "BTN_ChargerImage";
            this.BTN_ChargerImage.Size = new System.Drawing.Size(100, 23);
            this.BTN_ChargerImage.TabIndex = 8;
            this.BTN_ChargerImage.Text = "Charger Image";
            this.BTN_ChargerImage.UseVisualStyleBackColor = true;
            this.BTN_ChargerImage.Click += new System.EventHandler(this.BTN_ChargerImage_Click);
            // 
            // PB_Equipes
            // 
            this.PB_Equipes.Location = new System.Drawing.Point(273, 12);
            this.PB_Equipes.Name = "PB_Equipes";
            this.PB_Equipes.Size = new System.Drawing.Size(100, 85);
            this.PB_Equipes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Equipes.TabIndex = 11;
            this.PB_Equipes.TabStop = false;
            // 
            // CB_DivisionEquipe
            // 
            this.CB_DivisionEquipe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_DivisionEquipe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_DivisionEquipe.FormattingEnabled = true;
            this.CB_DivisionEquipe.Location = new System.Drawing.Point(117, 77);
            this.CB_DivisionEquipe.Name = "CB_DivisionEquipe";
            this.CB_DivisionEquipe.Size = new System.Drawing.Size(138, 21);
            this.CB_DivisionEquipe.TabIndex = 5;
            // 
            // FormEquipe_Ajouter
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(403, 187);
            this.Controls.Add(this.CB_DivisionEquipe);
            this.Controls.Add(this.PB_Equipes);
            this.Controls.Add(this.BTN_ChargerImage);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_VilleEquipe);
            this.Controls.Add(this.TB_NomEquipe);
            this.Controls.Add(this.DTP_DateCreationEquipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEquipe_Ajouter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormEquipe_Ajouter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_DateCreationEquipe;
        private System.Windows.Forms.TextBox TB_NomEquipe;
        private System.Windows.Forms.TextBox TB_VilleEquipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_ChargerImage;
        private System.Windows.Forms.PictureBox PB_Equipes;
        private System.Windows.Forms.ComboBox CB_DivisionEquipe;
    }
}