namespace SafeBrowser
{
    partial class SettingsDialog
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
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabAllowedSites = new System.Windows.Forms.TabPage();
            this.lstSites = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colURL = new System.Windows.Forms.ColumnHeader();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAddSite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditSite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveSite = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.tabSettings.SuspendLayout();
            this.tabAllowedSites.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSettings.Controls.Add(this.tabAllowedSites);
            this.tabSettings.Controls.Add(this.tabPage1);
            this.tabSettings.Location = new System.Drawing.Point(8, 8);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(432, 224);
            this.tabSettings.TabIndex = 0;
            // 
            // tabAllowedSites
            // 
            this.tabAllowedSites.Controls.Add(this.lstSites);
            this.tabAllowedSites.Location = new System.Drawing.Point(4, 22);
            this.tabAllowedSites.Name = "tabAllowedSites";
            this.tabAllowedSites.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllowedSites.Size = new System.Drawing.Size(424, 198);
            this.tabAllowedSites.TabIndex = 0;
            this.tabAllowedSites.Text = "Allowed Sites";
            this.tabAllowedSites.UseVisualStyleBackColor = true;
            // 
            // lstSites
            // 
            this.lstSites.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSites.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colURL});
            this.lstSites.ContextMenuStrip = this.contextMenuStrip1;
            this.lstSites.FullRowSelect = true;
            this.lstSites.Location = new System.Drawing.Point(8, 8);
            this.lstSites.Name = "lstSites";
            this.lstSites.Size = new System.Drawing.Size(408, 184);
            this.lstSites.TabIndex = 0;
            this.lstSites.UseCompatibleStateImageBehavior = false;
            this.lstSites.View = System.Windows.Forms.View.Details;
            this.lstSites.SelectedIndexChanged += new System.EventHandler(this.lstSites_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 136;
            // 
            // colURL
            // 
            this.colURL.Text = "URL";
            this.colURL.Width = 254;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(248, 248);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cance&l";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(344, 248);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(91, 40);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "O&K";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddSite,
            this.mnuEditSite,
            this.mnuRemoveSite});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 70);
            // 
            // mnuAddSite
            // 
            this.mnuAddSite.Name = "mnuAddSite";
            this.mnuAddSite.Size = new System.Drawing.Size(157, 22);
            this.mnuAddSite.Text = "Add Site...";
            this.mnuAddSite.Click += new System.EventHandler(this.mnuAddSite_Click);
            // 
            // mnuEditSite
            // 
            this.mnuEditSite.Enabled = false;
            this.mnuEditSite.Name = "mnuEditSite";
            this.mnuEditSite.Size = new System.Drawing.Size(157, 22);
            this.mnuEditSite.Text = "Edit Site...";
            this.mnuEditSite.Click += new System.EventHandler(this.mnuEditSite_Click);
            // 
            // mnuRemoveSite
            // 
            this.mnuRemoveSite.Enabled = false;
            this.mnuRemoveSite.Name = "mnuRemoveSite";
            this.mnuRemoveSite.Size = new System.Drawing.Size(157, 22);
            this.mnuRemoveSite.Text = "Remove Site...";
            this.mnuRemoveSite.Click += new System.EventHandler(this.mnuRemoveSite_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPassword2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(424, 198);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Security";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(144, 16);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(264, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Repeat New Password";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(144, 48);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(264, 20);
            this.txtPassword2.TabIndex = 3;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 300);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabSettings);
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings...";
            this.Load += new System.EventHandler(this.SettingsDialog_Load);
            this.tabSettings.ResumeLayout(false);
            this.tabAllowedSites.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabAllowedSites;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListView lstSites;
        private System.Windows.Forms.ColumnHeader colURL;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAddSite;
        private System.Windows.Forms.ToolStripMenuItem mnuEditSite;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveSite;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
    }
}