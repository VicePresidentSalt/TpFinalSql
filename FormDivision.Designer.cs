namespace TPFinalSQLDEVCoteFrancisStlaurentDarenKen
{
    partial class FormDivision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDivision));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dS_Division = new TPFinalSQLDEVCoteFrancisStlaurentDarenKen.DS_Division();
            this.dIVISIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIVISIONSTableAdapter = new TPFinalSQLDEVCoteFrancisStlaurentDarenKen.DS_DivisionTableAdapters.DIVISIONSTableAdapter();
            this.nOMDIVISIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATECREATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Division = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Deconnexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Division)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIVISIONSBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMDIVISIONDataGridViewTextBoxColumn,
            this.dATECREATIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dIVISIONSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 126);
            this.dataGridView1.TabIndex = 0;
            // 
            // dS_Division
            // 
            this.dS_Division.DataSetName = "DS_Division";
            this.dS_Division.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dIVISIONSBindingSource
            // 
            this.dIVISIONSBindingSource.DataMember = "DIVISIONS";
            this.dIVISIONSBindingSource.DataSource = this.dS_Division;
            // 
            // dIVISIONSTableAdapter
            // 
            this.dIVISIONSTableAdapter.ClearBeforeFill = true;
            // 
            // nOMDIVISIONDataGridViewTextBoxColumn
            // 
            this.nOMDIVISIONDataGridViewTextBoxColumn.DataPropertyName = "NOMDIVISION";
            this.nOMDIVISIONDataGridViewTextBoxColumn.HeaderText = "NOMDIVISION";
            this.nOMDIVISIONDataGridViewTextBoxColumn.Name = "nOMDIVISIONDataGridViewTextBoxColumn";
            // 
            // dATECREATIONDataGridViewTextBoxColumn
            // 
            this.dATECREATIONDataGridViewTextBoxColumn.DataPropertyName = "DATECREATION";
            this.dATECREATIONDataGridViewTextBoxColumn.HeaderText = "DATECREATION";
            this.dATECREATIONDataGridViewTextBoxColumn.Name = "dATECREATIONDataGridViewTextBoxColumn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Division});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(392, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Division
            // 
            this.TSMI_Division.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déconnexionToolStripMenuItem,
            this.toolStripMenuItem1,
            this.quitterToolStripMenuItem});
            this.TSMI_Division.Name = "TSMI_Division";
            this.TSMI_Division.Size = new System.Drawing.Size(54, 20);
            this.TSMI_Division.Text = "Fichier";
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.BTN_Deconnexion_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(301, 44);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 2;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(301, 98);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modifier.TabIndex = 3;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Location = new System.Drawing.Point(301, 147);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_Delete.TabIndex = 4;
            this.BTN_Delete.Text = "Supprimer";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            // 
            // BTN_Deconnexion
            // 
            this.BTN_Deconnexion.Location = new System.Drawing.Point(76, 185);
            this.BTN_Deconnexion.Name = "BTN_Deconnexion";
            this.BTN_Deconnexion.Size = new System.Drawing.Size(96, 23);
            this.BTN_Deconnexion.TabIndex = 5;
            this.BTN_Deconnexion.Text = "Déconnexion";
            this.BTN_Deconnexion.UseVisualStyleBackColor = true;
            this.BTN_Deconnexion.Click += new System.EventHandler(this.BTN_Deconnexion_Click);
            // 
            // FormDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 229);
            this.Controls.Add(this.BTN_Deconnexion);
            this.Controls.Add(this.BTN_Delete);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDivision";
            this.Text = "FormDivision";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDivision_FormClosed);
            this.Load += new System.EventHandler(this.FormDivision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Division)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIVISIONSBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DS_Division dS_Division;
        private System.Windows.Forms.BindingSource dIVISIONSBindingSource;
        private DS_DivisionTableAdapters.DIVISIONSTableAdapter dIVISIONSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDIVISIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATECREATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Division;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Delete;
        private System.Windows.Forms.Button BTN_Deconnexion;
    }
}