using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.connection.StateChange += new StateChangeEventHandler(this.connection_StateChange);
        }

        SqlConnection connection = new SqlConnection();
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = Northwind; Integrated Security = True";

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
            {
                returnValue = settings.ConnectionString;
            }
            return returnValue;
        }

        string connectionString = GetConnectionStringByName("DBConnection.NorthwindConnectionString");

        private void connectMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Соединение с БД " + connection.Database + " выполнено успешно"
                        + "\nСервер: " + connection.DataSource);
                }
                else
                {
                    MessageBox.Show("Соединение с БД уже установлено");
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnectMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с БД закрыто");
            }
            else
            {
                MessageBox.Show("Соединение с БД уже закрыто");
            }
        }

        private async void asyncConnectMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    await connection.OpenAsync();
                    MessageBox.Show("Соединение с БД " + connection.Database + " выполнено успешно"
                        + "\nСервер: " + connection.DataSource);
                }
                else
                {
                    MessageBox.Show("Соединение с БД уже установлено");
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            connectMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            asyncConnectMenuItem.Enabled = (e.CurrentState == ConnectionState.Closed);
            disconnectMenuItem.Enabled = (e.CurrentState == ConnectionState.Open);
        }

        private void connectionListMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    string str = String.Format($"Name = {cs.Name}\nProviderName = {cs.ProviderName}" +
                        $"\nConnectionString = {cs.ConnectionString}");
                    MessageBox.Show(str, "Параметры подключений");
                }
            }
        }
    }
}
