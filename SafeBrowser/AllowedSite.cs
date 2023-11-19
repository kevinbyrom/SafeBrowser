using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;


namespace SafeBrowser
{
    [Serializable]
	public class AllowedSite : ICloneable
	{
        public string Name;
		public string URL;


        #region Constructors

        public AllowedSite()
		{
            Name    = "";
			URL		= "";
		}

        public AllowedSite(string name, string url)
        {
            Name    = name;
            URL     = url;
        }

        #endregion


        #region ICloneable Members

        public object Clone()
        {
            return new AllowedSite(Name, URL);
        }

        #endregion

    }
}
