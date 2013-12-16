namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class Form_Ajouter_Stats
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
            this.BTN_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.CB_NumJoueurs = new System.Windows.Forms.ComboBox();
            this.TB_NumMatch = new System.Windows.Forms.TextBox();
            this.TB_NbButs = new System.Windows.Forms.TextBox();
            this.TB_NbPasses = new System.Windows.Forms.TextBox();
            this.TB_TempsPunition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_OK
            // 
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(36, 228);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 0;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Match";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Joueurs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nb Buts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nb Passes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Temps Punition";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(143, 228);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BTN_Cancel.TabIndex = 2;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // CB_NumJoueurs
            // 
            this.CB_NumJoueurs.FormattingEnabled = true;
            this.CB_NumJoueurs.Location = new System.Drawing.Point(103, 63);
            this.CB_NumJoueurs.Name = "CB_NumJoueurs";
            this.CB_NumJoueurs.Size = new System.Drawing.Size(121, 21);
            this.CB_NumJoueurs.TabIndex = 3;
            // 
            // TB_NumMatch
            // 
            this.TB_NumMatch.Location = new System.Drawing.Point(103, 24);
            this.TB_NumMatch.Name = "TB_NumMatch";
            this.TB_NumMatch.ReadOnly = true;
            this.TB_NumMatch.Size = new System.Drawing.Size(121, 20);
            this.TB_NumMatch.TabIndex = 4;
            // 
            // TB_NbButs
            // 
            this.TB_NbButs.Location = new System.Drawing.Point(103, 104);
            this.TB_NbButs.Name = "TB_NbButs";
            this.TB_NbButs.Size = new System.Drawing.Size(121, 20);
            this.TB_NbButs.TabIndex = 4;
            this.TB_NbButs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_Ajouter_Stats_KeyPress);
            // 
            // TB_NbPasses
            // 
            this.TB_NbPasses.Location = new System.Drawing.Point(103, 142);
            this.TB_NbPasses.Name = "TB_NbPasses";
            this.TB_NbPasses.Size = new System.Drawing.Size(121, 20);
            this.TB_NbPasses.TabIndex = 4;
            this.TB_NbPasses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_Ajouter_Stats_KeyPress);
            // 
            // TB_TempsPunition
            // 
            this.TB_TempsPunition.Location = new System.Drawing.Point(103, 180);
            this.TB_TempsPunition.Name = "TB_TempsPunition";
            this.TB_TempsPunition.Size = new System.Drawing.Size(121, 20);
            this.TB_TempsPunition.TabIndex = 4;
            this.TB_TempsPunition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_Ajouter_Stats_KeyPress);
            // 
            // Form_Ajouter_Stats
            // 
            this.AcceptButton = this.BTN_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(261, 263);
            this.Controls.Add(this.TB_TempsPunition);
            this.Controls.Add(this.TB_NbPasses);
            this.Controls.Add(this.TB_NbButs);
            this.Controls.Add(this.TB_NumMatch);
            this.Controls.Add(this.CB_NumJoueurs);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_OK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Ajouter_Stats";
            this.Text = "Ajouter Statistiques";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Ajouter_Stats_FormClosing);
            this.Load += new System.EventHandler(this.Form_Ajouter_Stats_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_Ajouter_Stats_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.ComboBox CB_NumJoueurs;
        private System.Windows.Forms.TextBox TB_NumMatch;
        private System.Windows.Forms.TextBox TB_NbButs;
        private System.Windows.Forms.TextBox TB_NbPasses;
        private System.Windows.Forms.TextBox TB_TempsPunition;
    }
}