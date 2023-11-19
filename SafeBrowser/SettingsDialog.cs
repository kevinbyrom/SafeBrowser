using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SafeBrowser
{
    public partial class SettingsDialog : Form
    {
        private Settings m_Settings = new Settings();


        #region Public Properties

        public Settings Settings
        {
            get
            {
                return m_Settings;
            }
            set
            {
                m_Settings = (Settings)value.Clone();
            }
        }

        #endregion


        public SettingsDialog()
        {
            InitializeComponent();
        }


        #region Form Events

        private void SettingsDialog_Load(object sender, EventArgs e)
        {
            foreach (AllowedSite site in m_Settings.AllowedSites)
            {
                ListViewItem item = new ListViewItem(site.Name);
                item.SubItems.Add(site.URL);
                lstSites.Items.Add(item);
            }
        }

        #endregion


        #region ListView events

        private void lstSites_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuEditSite.Enabled     = (lstSites.SelectedItems.Count == 1);
            mnuRemoveSite.Enabled   = (lstSites.SelectedItems.Count > 0);
        }

        #endregion


        #region Button Events

        private void btnOK_Click(object sender, EventArgs e)
        {            
            if (ValidatePassword())
            {

                // Set the password

                if (txtPassword.Text.Trim() != "")
                {                    
                    m_Settings.Password = txtPassword.Text.Trim();
                    MessageBox.Show("Password has been successfully changed.");
                }


                // Fill the allowed sites

                m_Settings.AllowedSites.Clear();

                foreach (ListViewItem item in lstSites.Items)
                {
                    m_Settings.AllowedSites.Add(new AllowedSite(item.SubItems[0].Text, item.SubItems[1].Text));
                }

                DialogResult = DialogResult.OK;

            }
        }

        #endregion


        #region Menu Events

        private void mnuAddSite_Click(object sender, EventArgs e)
        {
            SiteDialog dlg = new SiteDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ListViewItem listitem = new ListViewItem(dlg.SiteName);
                listitem.SubItems.Add(dlg.SiteURL);
                lstSites.Items.Add(listitem);
            }
        }

        private void mnuEditSite_Click(object sender, EventArgs e)
        {
            SiteDialog dlg  = new SiteDialog();
            int pos         = lstSites.SelectedIndices[0];

            dlg.SiteName    = lstSites.Items[pos].SubItems[0].Text;
            dlg.SiteURL     = lstSites.Items[pos].SubItems[1].Text;
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                lstSites.Items[pos].SubItems[0].Text    = dlg.SiteName;
                lstSites.Items[pos].SubItems[1].Text    = dlg.SiteURL;
            }
        }

        private void mnuRemoveSite_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove this site?", "Attention", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                for (int i = lstSites.SelectedIndices.Count - 1; i >= 0; i--)
                    lstSites.Items.RemoveAt(i);
            }
        }

        #endregion


        #region ValidatePassword()

        private bool ValidatePassword()
        {
            try
            {
                if (txtPassword.Text.Trim() != "" && txtPassword.Text.Trim() != txtPassword2.Text.Trim())
                    throw new Exception("The repeat password must match the new password.");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        #endregion

    }
}
