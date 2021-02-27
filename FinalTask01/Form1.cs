using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FinalTask01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks"].ToString();
        private SqlConnection connection;

        private void fillListViewButton_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(connectionString))
            {
                listView.Items.Clear();
                string dateBegin = beginDateTextBox.Text;
                string dateEnd = endDateTextBox.Text;
                string query = "SELECT PurchaseOrderID, OrderDate, TotalDue " +
                    "FROM Purchasing.PurchaseOrderHeader " +
                    "WHERE OrderDate BETWEEN '" + dateBegin + "' AND '" + dateEnd + "'";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    DateTime.Parse(dateBegin);
                    DateTime.Parse(dateEnd);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = listView.Items.Add(reader["PurchaseOrderID"].ToString());
                        item.SubItems.Add(reader["OrderDate"].ToString());
                        item.SubItems.Add(reader["TotalDue"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK);
                }
            }
        }
    }
}
