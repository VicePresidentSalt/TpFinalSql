namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class Form_Equipe
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
            this.DGV_Equipe = new System.Windows.Forms.DataGridView();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.PB_Equipes = new System.Windows.Forms.PictureBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Equipe
            // 
            this.DGV_Equipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Equipe.Location = new System.Drawing.Point(12, 12);
            this.DGV_Equipe.Name = "DGV_Equipe";
            this.DGV_Equipe.Size = new System.Drawing.Size(451, 268);
            this.DGV_Equipe.TabIndex = 0;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(493, 129);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 1;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(493, 193);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modifier.TabIndex = 2;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(493, 257);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 3;
            this.BTN_Delete.Text = "Supprimer";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // PB_Equipes
            // 
            this.PB_Equipes.Location = new System.Drawing.Point(469, 12);
            this.PB_Equipes.Name = "PB_Equipes";
            this.PB_Equipes.Size = new System.Drawing.Size(117, 96);
            this.PB_Equipes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_Equipes.TabIndex = 4;
            this.PB_Equipes.TabStop = false;
            // 
            // BTN_OK
            // 
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(509, 294);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 5;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // Form_Equipe
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 329);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.PB_Equipes);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.DGV_Equipe);
            this.Name = "Form_Equipe";
            this.Text = "Form_Equipe";
            this.Load += new System.EventHandler(this.FormEquipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Equipe;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.PictureBox PB_Equipes;
        private System.Windows.Forms.Button BTN_OK;
    }
}