using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace DatabaseTutorial
{
    public class DBAccess
    {
        private SqlConnection connection = new SqlConnection();
        private SqlCommand command = new SqlCommand();
        private SqlDataReader DbReader;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        public bool connected = false;
        public SqlTransaction DbTran;
        private string strConnString = null;

        public DBAccess()
        {
            XmlDocument dba = new XmlDocument();
            dba.LoadXml(File.ReadAllText("DBAccess.xml"));
            string datasource = dba.SelectSingleNode("/Connection/Database").InnerText;
            string catalog = dba.SelectSingleNode("/Connection/Catalog").InnerText;
            string username = dba.SelectSingleNode("/Connection/Login").InnerText;
            string password = dba.SelectSingleNode("/Connection/Password").InnerText;
            strConnString = @"Data Source=" + datasource + ";Initial Catalog=" + catalog + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
        }

        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                    connected = true;
                }
            }
            catch
            {
                connected = false;
                MessageBox.Show("Can't connect to Database");
            }
        }

        public void closeConn()
        {
            connection.Close();
            connected = false;
        }

        public int executeDataAdapter(DataTable tblName, string strSelectSql)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                    connected = true;
                }

                adapter.SelectCommand.CommandText = strSelectSql;
                adapter.SelectCommand.CommandType = CommandType.Text;
                SqlCommandBuilder DbCommandBuilder = new SqlCommandBuilder(adapter);

                string insert = DbCommandBuilder.GetInsertCommand().CommandText.ToString();
                string update = DbCommandBuilder.GetUpdateCommand().CommandText.ToString();
                string delete = DbCommandBuilder.GetDeleteCommand().CommandText.ToString();

                return adapter.Update(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                    connected = true;
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader readDatathroughReader(string query)
        {
            //DataReader used to sequentially read data from a data source
            SqlDataReader reader;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                    connected = true;
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int executeQuery(SqlCommand dbCommand)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                    connected = true;
                }

                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;

                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}