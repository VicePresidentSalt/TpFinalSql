namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class Form_Classement
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
            this.DGV_Classement = new System.Windows.Forms.DataGridView();
            this.BTN_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Classement)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Classement
            // 
            this.DGV_Classement.AllowUserToAddRows = false;
            this.DGV_Classement.AllowUserToDeleteRows = false;
            this.DGV_Classement.AllowUserToOrderColumns = true;
            this.DGV_Classement.AllowUserToResizeColumns = false;
            this.DGV_Classement.AllowUserToResizeRows = false;
            this.DGV_Classement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Classement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Classement.Location = new System.Drawing.Point(12, 15);
            this.DGV_Classement.Name = "DGV_Classement";
            this.DGV_Classement.ReadOnly = true;
            this.DGV_Classement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Classement.Size = new System.Drawing.Size(371, 150);
            this.DGV_Classement.TabIndex = 0;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(159, 181);
            this.BTN_Ok.MinimumSize = new System.Drawing.Size(75, 23);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 1;
            this.BTN_Ok.Text = "Ok";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // Form_Classement
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 216);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.DGV_Classement);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Classement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Classement";
            this.Load += new System.EventHandler(this.Form_Classement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Classement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Classement;
        private System.Windows.Forms.Button BTN_Ok;
    }
}