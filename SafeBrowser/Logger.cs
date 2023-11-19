using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading;



namespace SafeBrowser
{
    public class Logger
    {
        static private Mutex m_LogLock = new Mutex();


        #region static Write(msg)

        static public void Write(string msg)
        {          
            try
            {

                // Make this thread safe

                lock (m_LogLock)
                {
                    // Open the log file in the isolated storage

                    using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForAssembly())
                    {
                        string filename = String.Format("SafeBrowserLog {0}.txt", DateTime.Now.ToString("yyyy-MM-dd"));

                        using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream(filename, FileMode.Create, store))
                        {

                            // Write the log message

                            using (StreamWriter writer = new StreamWriter(stream))
                            {
                                writer.WriteLine("{0}\t{1}", DateTime.Now.ToString("hh:mm:ss tt"), msg);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion

    }
}
