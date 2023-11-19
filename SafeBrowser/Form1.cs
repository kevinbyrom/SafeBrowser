using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml;


namespace SafeBrowser
{
	public partial class Form1 : Form
	{
        protected Settings m_Settings = new Settings();


		public Form1()
		{
			InitializeComponent();
		}


		#region Form Events

		private void Form1_Load(object sender, EventArgs e)
		{
			Logger.Write("****Program started****");


            // Load the settings

            LoadSettings();


            // Fill the URL combobox with allowed URLs

            FillURLCombo();
			

			// Hook a handler to the Navigated event

            webBrowser1.Dock = DockStyle.Fill;
			webBrowser1.Navigated += new WebBrowserNavigatedEventHandler(webBrowser1_Navigated);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Logger.Write("****Program closing****");
			e.Cancel = false;
		}

		#endregion


        #region Menu Events

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            PasswordDialog pwdlg = new PasswordDialog();

            pwdlg.Password = m_Settings.Password;

            if (m_Settings.Password == "" || pwdlg.ShowDialog() == DialogResult.OK)
            {
                SettingsDialog dlg = new SettingsDialog();

                dlg.Settings = m_Settings;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    m_Settings = dlg.Settings;
                    SaveSettings();
                    FillURLCombo();
                }
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Button Events

        private void btnNavigate_Click(object sender, EventArgs e)
		{
			if (cmbURL.SelectedIndex != -1)
			{
				string url = m_Settings.AllowedSites[cmbURL.SelectedIndex].URL;
				webBrowser1.Navigate(url);
			}
		}

		#endregion

		
		#region WebBrowser Events

		void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			Logger.Write(String.Format("Navigated to : " + e.Url));
		}

		#endregion


		#region FillURLCombo()

		private void FillURLCombo()
		{

            // Clear any existing items

			cmbURL.Items.Clear();


            // Fill the combo with allowed urls

            foreach (AllowedSite site in m_Settings.AllowedSites)
                cmbURL.Items.Add(site.Name);


            // Select the first url

            if (cmbURL.Items.Count > 0)
                cmbURL.SelectedIndex = 0;

		}

		#endregion


        #region Save / Load Settings

        public void SaveSettings()
        {
            try
            {
                using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForAssembly())
                {
                    using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream("settings.dat", FileMode.Create, store))
                    {
                        BinaryFormatter binformat = new BinaryFormatter();

                        binformat.Serialize(stream, m_Settings);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadSettings()
        {
            try
            {
                using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForAssembly())
                {               
                    using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream("settings.dat", FileMode.Open, FileAccess.Read, store))
                    {
                        BinaryFormatter binformat = new BinaryFormatter();

                        m_Settings = binformat.Deserialize(stream) as Settings;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

    }
}
