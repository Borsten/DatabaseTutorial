using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseTutorial
{
    public partial class SignUp : Form
    {
        DBAccess dbAccess = new DBAccess();

        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string userName = txt_Name.Text;
            string userEmail = txt_Email.Text;
            string userPassword = txt_Password.Text;
            string userCountry = cbo_Country.Text;

            if (userName.Equals(""))
            {
                MessageBox.Show("Please enter your user name.");
            }
            else if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email.");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your password.");
            }
            else if (userCountry.Equals(""))
            {
                MessageBox.Show("Please select your country.");
            }

            else
            {
                SqlCommand insertCommand = new SqlCommand("INSERT INTO Users(Name, Email, Password, Country, GroupPolicy) VALUES(@userName, @userEmail, @userPassword, @userCountry, @userGroupPolicy)");

                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
                insertCommand.Parameters.AddWithValue("@userCountry", userCountry);
                insertCommand.Parameters.AddWithValue("@userGroupPolicy", "user");

                int row = dbAccess.executeQuery(insertCommand);

                if (row > 0)
                {
                    MessageBox.Show("Account Created Sucessfully. Please login now");
                    dbAccess.closeConn();

                    this.Hide();
                    SignIn signIn = new SignIn();
                    signIn.Show();
                }
            }
        }
    }
}
