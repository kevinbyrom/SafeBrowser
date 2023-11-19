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
    public partial class PasswordDialog : Form
    {
        public string Password;


        public PasswordDialog()
        {
            InitializeComponent();
        }


        #region TextBox Events

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = (txtPassword.Text == Password);
        }

        #endregion

    }
}
