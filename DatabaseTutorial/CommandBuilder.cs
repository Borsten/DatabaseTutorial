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
    public partial class CommandBuilder : Form
    {

        DBAccess dbAccess = new DBAccess();
        DataTable dtUsers = new DataTable();
        public CommandBuilder()
        {
            InitializeComponent();
        }

        private void CommandBuilder_Load(object sender, EventArgs e)
        {
            string query = "Select * from Users";

            dbAccess.readDatathroughAdapter(query, dtUsers);

            dgv_UserData.DataSource = dtUsers;
            dgv_UserData.Columns[0].ReadOnly = true;
            dbAccess.closeConn();
        }

        private void btn_operate_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Users";

            int changes = dbAccess.executeDataAdapter(dtUsers, query);

            MessageBox.Show(changes + " changes performed.");
        }
    }
}
