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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendrier_Match
            // 
            this.Calendrier_Match.Location = new System.Drawing.Point(105, 18);
            this.Calendrier_Match.Name = "Calendrier_Match";
            this.Calendrier_Match.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // BTN_OK
            // 
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(174, 362);
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
            this.ClientSize = new System.Drawing.Size(427, 397);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Calendrier_Match);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Calendrier_Match";
            this.Text = "Match Par Calendrier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Calendrier_Match_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendrier_Match;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_OK;
    }
}