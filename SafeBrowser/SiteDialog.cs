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
    public partial class SiteDialog : Form
    {
        public string SiteName;
        public string SiteURL;


        public SiteDialog()
        {
            InitializeComponent();
        }


        #region Form Events

        private void SiteDialog_Load(object sender, EventArgs e)
        {
            txtName.Text    = SiteName;
            txtURL.Text     = SiteURL;
        }

        #endregion


        #region Button Events

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                SiteName        = txtName.Text.Trim();
                SiteURL         = txtURL.Text.Trim();
                DialogResult    = DialogResult.OK;
            }
        }

        #endregion


        #region ValidateControls()

        private bool ValidateControls()
        {
            try
            {
                if (txtName.Text.Trim() == "")
                    throw new Exception("Name is required.");

                if (txtURL.Text.Trim() == "")
                    throw new Exception("URL is required.");
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
