using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseTutorial
{
    public partial class SignIn : Form
    {
        public static string id, name, email, password, country;

        DBAccess dbAccess = new DBAccess();
        DataTable dtUsers = new DataTable();

        public SignIn()
        {
            InitializeComponent();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            string userEmail = txt_EmailSignIn.Text;
            string userPassword = txt_PasswordSignIn.Text;

            if (userEmail.Equals(""))
                MessageBox.Show("Enter Email");
            else if (userEmail.Equals(""))
                MessageBox.Show("Enter Password");
            else
            {
                string query = "SELECT * FROM Users WHERE Email= '" + userEmail + "' AND Password= '" + userPassword + "'";

                dbAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count > 0)
                {
                    id = dtUsers.Rows[0]["UserID"].ToString();
                    name = dtUsers.Rows[0]["Name"].ToString();
                    email = dtUsers.Rows[0]["Email"].ToString();
                    password = dtUsers.Rows[0]["Password"].ToString();
                    country = dtUsers.Rows[0]["Country"].ToString();

                    MessageBox.Show("Login complete!");
                    dbAccess.closeConn();

                    if (dtUsers.Rows[0]["GroupPolicy"].Equals("admin"))
                    {
                        this.Hide();
                        CommandBuilder cb = new CommandBuilder();
                        cb.Show();
                    }
                    else
                    {
                        this.Hide();
                        Home home = new Home();
                        home.Show();
                    }
                }
                else
                    MessageBox.Show("Invalid Inputs. Try Again");
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }
    }
}
