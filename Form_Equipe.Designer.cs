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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Equipe));
            this.DGV_Equipes = new System.Windows.Forms.DataGridView();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.PB_Equipes = new System.Windows.Forms.PictureBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.CMS_Equipe = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.voirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipes)).BeginInit();
            this.CMS_Equipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Equipes
            // 
            this.DGV_Equipes.AllowUserToAddRows = false;
            this.DGV_Equipes.AllowUserToDeleteRows = false;
            this.DGV_Equipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Equipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Equipes.ContextMenuStrip = this.CMS_Equipe;
            this.DGV_Equipes.Location = new System.Drawing.Point(12, 12);
            this.DGV_Equipes.MultiSelect = false;
            this.DGV_Equipes.Name = "DGV_Equipes";
            this.DGV_Equipes.ReadOnly = true;
            this.DGV_Equipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Equipes.Size = new System.Drawing.Size(451, 268);
            this.DGV_Equipes.TabIndex = 0;
            this.DGV_Equipes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Equipe_CellContentDoubleClick);
            this.DGV_Equipes.SelectionChanged += new System.EventHandler(this.DGV_Equipes_SelectionChanged);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Ajouter.Location = new System.Drawing.Point(494, 132);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 1;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Modifier.Location = new System.Drawing.Point(494, 161);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modifier.TabIndex = 2;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_Delete.Location = new System.Drawing.Point(494, 190);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 3;
            this.BTN_Delete.Text = "Supprimer";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // PB_Equipes
            // 
            this.PB_Equipes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_Equipes.Location = new System.Drawing.Point(469, 12);
            this.PB_Equipes.Name = "PB_Equipes";
            this.PB_Equipes.Size = new System.Drawing.Size(117, 96);
            this.PB_Equipes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_Equipes.TabIndex = 4;
            this.PB_Equipes.TabStop = false;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_OK.Location = new System.Drawing.Point(509, 294);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(75, 23);
            this.BTN_OK.TabIndex = 5;
            this.BTN_OK.Text = "Ok";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // CMS_Equipe
            // 
            this.CMS_Equipe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.modifierToolStripMenuItem,
            this.sToolStripMenuItem});
            this.CMS_Equipe.Name = "CMS_Equipe";
            this.CMS_Equipe.Size = new System.Drawing.Size(168, 98);
            // 
            // voirToolStripMenuItem
            // 
            this.voirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.voirToolStripMenuItem.Name = "voirToolStripMenuItem";
            this.voirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.voirToolStripMenuItem.ShowShortcutKeys = false;
            this.voirToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.voirToolStripMenuItem.Text = "&Voir";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.modifierToolStripMenuItem.ShowShortcutKeys = false;
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.modifierToolStripMenuItem.Text = "&Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.sToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.sToolStripMenuItem.Text = "Supprimer";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.BTN_Delete_Click);
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
            this.Controls.Add(this.DGV_Equipes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Equipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Équipes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Equipe_FormClosing);
            this.Load += new System.EventHandler(this.FormEquipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Equipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Equipes)).EndInit();
            this.CMS_Equipe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Equipes;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.PictureBox PB_Equipes;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.ContextMenuStrip CMS_Equipe;
        private System.Windows.Forms.ToolStripMenuItem voirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
    }
}