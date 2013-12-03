namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BTN_Connect = new System.Windows.Forms.Button();
            this.BTN_Quitter = new System.Windows.Forms.Button();
            this.LB_Username = new System.Windows.Forms.Label();
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.LB_MDP = new System.Windows.Forms.Label();
            this.LB_Error = new System.Windows.Forms.Label();
            this.BTN_About = new System.Windows.Forms.Button();
            this.PB_Login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Connect
            // 
            this.BTN_Connect.Location = new System.Drawing.Point(315, 104);
            this.BTN_Connect.Name = "BTN_Connect";
            this.BTN_Connect.Size = new System.Drawing.Size(75, 23);
            this.BTN_Connect.TabIndex = 0;
            this.BTN_Connect.Text = "Connexion";
            this.BTN_Connect.UseVisualStyleBackColor = true;
            this.BTN_Connect.Click += new System.EventHandler(this.BTN_Connect_Click);
            // 
            // BTN_Quitter
            // 
            this.BTN_Quitter.Location = new System.Drawing.Point(234, 104);
            this.BTN_Quitter.Name = "BTN_Quitter";
            this.BTN_Quitter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Quitter.TabIndex = 0;
            this.BTN_Quitter.Text = "Quitter";
            this.BTN_Quitter.UseVisualStyleBackColor = true;
            this.BTN_Quitter.Click += new System.EventHandler(this.BTN_Quitter_Click);
            // 
            // LB_Username
            // 
            this.LB_Username.AutoSize = true;
            this.LB_Username.Location = new System.Drawing.Point(246, 8);
            this.LB_Username.Name = "LB_Username";
            this.LB_Username.Size = new System.Drawing.Size(41, 13);
            this.LB_Username.TabIndex = 2;
            this.LB_Username.Text = "Usager";
            // 
            // TB_Username
            // 
            this.TB_Username.Location = new System.Drawing.Point(249, 25);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(100, 20);
            this.TB_Username.TabIndex = 3;
            this.TB_Username.Text = "cotefran";
            this.TB_Username.TextChanged += new System.EventHandler(this.TB_TextChanged);
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(249, 65);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(100, 20);
            this.TB_Password.TabIndex = 5;
            this.TB_Password.Text = "oracle1";
            this.TB_Password.UseSystemPasswordChar = true;
            this.TB_Password.TextChanged += new System.EventHandler(this.TB_TextChanged);
            this.TB_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Password_KeyDown);
            // 
            // LB_MDP
            // 
            this.LB_MDP.AutoSize = true;
            this.LB_MDP.Location = new System.Drawing.Point(246, 48);
            this.LB_MDP.Name = "LB_MDP";
            this.LB_MDP.Size = new System.Drawing.Size(71, 13);
            this.LB_MDP.TabIndex = 4;
            this.LB_MDP.Text = "Mot de passe";
            // 
            // LB_Error
            // 
            this.LB_Error.AutoSize = true;
            this.LB_Error.ForeColor = System.Drawing.Color.Red;
            this.LB_Error.Location = new System.Drawing.Point(249, 87);
            this.LB_Error.Name = "LB_Error";
            this.LB_Error.Size = new System.Drawing.Size(0, 13);
            this.LB_Error.TabIndex = 6;
            // 
            // BTN_About
            // 
            this.BTN_About.Location = new System.Drawing.Point(369, 2);
            this.BTN_About.Name = "BTN_About";
            this.BTN_About.Size = new System.Drawing.Size(30, 24);
            this.BTN_About.TabIndex = 7;
            this.BTN_About.Text = "?";
            this.BTN_About.UseVisualStyleBackColor = true;
            this.BTN_About.Click += new System.EventHandler(this.BTN_About_Click);
            // 
            // PB_Login
            // 
            this.PB_Login.Image = global::TPFinalSQLDEVCoteFrancisStlaurentDarenKen.Properties.Resources.Hockey_Plus_logo1;
            this.PB_Login.InitialImage = ((System.Drawing.Image)(resources.GetObject("PB_Login.InitialImage")));
            this.PB_Login.Location = new System.Drawing.Point(12, 12);
            this.PB_Login.Name = "PB_Login";
            this.PB_Login.Size = new System.Drawing.Size(209, 97);
            this.PB_Login.TabIndex = 1;
            this.PB_Login.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 134);
            this.Controls.Add(this.BTN_About);
            this.Controls.Add(this.LB_Error);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.LB_MDP);
            this.Controls.Add(this.TB_Username);
            this.Controls.Add(this.LB_Username);
            this.Controls.Add(this.PB_Login);
            this.Controls.Add(this.BTN_Quitter);
            this.Controls.Add(this.BTN_Connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion à Hockey Plus";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Connect;
        private System.Windows.Forms.Button BTN_Quitter;
        private System.Windows.Forms.PictureBox PB_Login;
        private System.Windows.Forms.Label LB_Username;
        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label LB_MDP;
        private System.Windows.Forms.Label LB_Error;
        private System.Windows.Forms.Button BTN_About;
    }
}

