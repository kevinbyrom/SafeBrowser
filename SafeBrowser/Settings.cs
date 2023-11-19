using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;


namespace SafeBrowser
{
    [Serializable]
    public class Settings : ICloneable  
    {
        public List<AllowedSite> AllowedSites;
        public string Password;


        #region Constructors

        public Settings()
        {
            AllowedSites    = new List<AllowedSite>();
            Password        = "";
        }

        public Settings(List<AllowedSite> allowedsites, string password)
        {

            // Set the allowed sites

            AllowedSites = new List<AllowedSite>();

            foreach (AllowedSite site in allowedsites)
                AllowedSites.Add(site);


            // Set the password

            Password = password;
        }

        #endregion


        #region ICloneable Members

        public object Clone()
        {
            return new Settings(AllowedSites, Password);
        }

        #endregion

    }
}
