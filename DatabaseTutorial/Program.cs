using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;

namespace DatabaseTutorial
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DBSingIn dBSingIn = new DBSingIn();
            if (File.Exists("DBAccess.xml"))
            {
                DBAccess dba_old = new DBAccess();
                dba_old.createConn();
                if (dba_old.connected== true )
                {
                    dba_old.closeConn();
                    Application.Run(new SignIn());
                }
                else
                {
                    MessageBox.Show("Saved Login Credentials are false");
                    File.Delete("DBAccess.xml");
                    Application.Run(dBSingIn);
                }
            }
            else
            {
                Application.Run(dBSingIn);
            }
        }
    }
}
