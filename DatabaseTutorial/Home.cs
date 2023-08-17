using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseTutorial
{
    public partial class Home : Form
    {
        DBAccess dbAccess = new DBAccess();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lbl_Welcome.Text = "Welcome " + SignIn.name;
            txt_NameHome.Text = SignIn.name;
            txt_EmailHome.Text = SignIn.email;
            txt_PasswordHome.Text = SignIn.password;
            cbo_CountryHome.Text = SignIn.country;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string newUserName = txt_NameHome.Text;
            string newPassword = txt_PasswordHome.Text;
            string newEmail = txt_EmailHome.Text;
            string newCountry = cbo_CountryHome.Text;

            if (newUserName.Equals(""))
                MessageBox.Show("Please enter a name.");
            else if (newUserName.Equals(""))
                MessageBox.Show("Please enter an email.");
            else if (newUserName.Equals(""))
                MessageBox.Show("Please enter a password.");
            else if (newUserName.Equals(""))
                MessageBox.Show("Please enter a country.");
            else
            {
                string query = "UPDATE Users Set Name = '" + @newUserName + "', Email = '" + @newEmail + "', Password = '" + @newPassword + "', Country = '" + @newCountry + "' WHERE UserID = " + SignIn.id;
                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@userName", @newUserName);
                updateCommand.Parameters.AddWithValue("@userEmail", @newEmail);
                updateCommand.Parameters.AddWithValue("@userPassword", @newPassword);
                updateCommand.Parameters.AddWithValue("@userCountry", @newCountry);

                int row = dbAccess.executeQuery(updateCommand);

                if (row > 0)
                {
                    MessageBox.Show("Account Updated Sucessfully.");
                    dbAccess.closeConn();

                    this.Hide();
                    SignIn signin = new SignIn();
                    signin.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                string query = "DELETE FROM Users WHERE UserID = " + SignIn.id;
                
                SqlCommand deleteCommand = new SqlCommand(query);

                int row = dbAccess.executeQuery(deleteCommand);

                if (row > 0)
                {
                    MessageBox.Show("Account deleted successfully.");

                    this.Hide();
                    SignIn sign = new SignIn();
                    sign.Show();
                }
                else
                    MessageBox.Show("Error occured. Try again.");
            }
        }
    }
}
