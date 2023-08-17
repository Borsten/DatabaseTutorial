using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DatabaseTutorial
{
    public partial class DBSingIn : Form
    {
        public DBSingIn()
        {
            InitializeComponent();     
        }

        private void btn_DBSignIn_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode connection = xmlDoc.CreateElement("Connection");
            xmlDoc.AppendChild(connection);
            XmlNode database = xmlDoc.CreateElement("Database");
            database.AppendChild(xmlDoc.CreateTextNode(@txt_DBAccess.Text));
            connection.AppendChild(database);
            XmlNode catalog = xmlDoc.CreateElement("Catalog");
            catalog.AppendChild(xmlDoc.CreateTextNode(txt_Catalog.Text));
            connection.AppendChild(catalog);
            XmlNode user = xmlDoc.CreateElement("Login");
            user.AppendChild(xmlDoc.CreateTextNode(txt_User.Text));
            connection.AppendChild(user);
            XmlNode password = xmlDoc.CreateElement("Password");
            password.AppendChild(xmlDoc.CreateTextNode(txt_Password.Text));
            connection.AppendChild(password);

            File.WriteAllText("DBAccess.xml", xmlDoc.InnerXml);

            DBAccess dba_new = new DBAccess();
            TryAccess(dba_new);
        }


        public void TryAccess(DBAccess dba)
        {
            dba.createConn();
            if (dba.connected == true)
            {
                dba.closeConn();
                this.Hide();
                SignIn signin = new SignIn();
                signin.Show();
            }
            else
            {
                MessageBox.Show("Cant connect with these credentials");
                File.Delete("DBAccess.xml");
            }
        }
    }
}
