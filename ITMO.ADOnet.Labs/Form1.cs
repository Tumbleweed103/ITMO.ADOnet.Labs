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

namespace DBConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection();
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = Northwind; Integrated Security = True";

        private void ConnectMenuItem_Click(object sender, EventArgs e)
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

        private void DisconnectMenuItem_Click(object sender, EventArgs e)
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

        private async void AsyncConnectMenuItem_Click(object sender, EventArgs e)
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
    }
}
