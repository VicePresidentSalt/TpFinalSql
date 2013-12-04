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
            this.DGV_Joueurs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Joueurs
            // 
            this.DGV_Joueurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Joueurs.Location = new System.Drawing.Point(25, 22);
            this.DGV_Joueurs.Name = "DGV_Joueurs";
            this.DGV_Joueurs.Size = new System.Drawing.Size(449, 283);
            this.DGV_Joueurs.TabIndex = 0;
            // 
            // Form_Joueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 412);
            this.Controls.Add(this.DGV_Joueurs);
            this.Name = "Form_Joueurs";
            this.Text = "Form_Joueurs";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Joueurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Joueurs;
    }
}