namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class Form_Calendrier_Match
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
            this.Calendrier_Match = new System.Windows.Forms.MonthCalendar();
            this.DGV_DateMatchCalendar = new System.Windows.Forms.DataGridView();
            this.BTN_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DateMatchCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendrier_Match
            // 
            this.Calendrier_Match.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendrier_Match.Location = new System.Drawing.Point(104, 32);
            this.Calendrier_Match.Name = "Calendrier_Match";
            this.Calendrier_Match.TabIndex = 0;
            this.Calendrier_Match.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendrier_Match_DateChanged);
            // 
            // DGV_DateMatchCalendar
            // 
            this.DGV_DateMatchCalendar.AllowUserToAddRows = false;
            this.DGV_DateMatchCalendar.AllowUserToDeleteRows = false;
            this.DGV_DateMatchCalendar.AllowUserToResizeColumns = false;
            this.DGV_DateMatchCalendar.AllowUserToResizeRows = false;
            this.DGV_DateMatchCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_DateMatchCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DateMatchCalendar.Location = new System.Drawing.Point(21, 206);
            this.DGV_DateMatchCalendar.Name = "DGV_DateMatchCalendar";
            this.DGV_DateMatchCalendar.ReadOnly = true;
            this.DGV_DateMatchCalendar.Size = new System.Drawing.Size(394, 150);
            this.DGV_DateMatchCalendar.TabIndex = 1;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(187, 362);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 2;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // Form_Calendrier_Match
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 398);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.DGV_DateMatchCalendar);
            this.Controls.Add(this.Calendrier_Match);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(443, 436);
            this.Name = "Form_Calendrier_Match";
            this.ShowIcon = false;
            this.Text = "Match Par Calendrier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Calendrier_Match_FormClosing);
            this.Load += new System.EventHandler(this.Form_Calendrier_Match_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DateMatchCalendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendrier_Match;
        private System.Windows.Forms.DataGridView DGV_DateMatchCalendar;
        private System.Windows.Forms.Button BTN_OK;
    }
}