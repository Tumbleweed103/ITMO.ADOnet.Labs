using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FinalTask02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        static string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorks"].ToString();
        static SqlConnection connection = new SqlConnection(connectionString);
        static string query = "SELECT ProductID, Name, ProductNumber " +
            "FROM Production.Product";
        static SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
        DataSet productsDataSet = new DataSet();
        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Fill(productsDataSet, "Product");
                gridView.DataSource = productsDataSet.Tables["Product"];
                addRowButton.Enabled = true;
                deleteRowButton.Enabled = true;
                saveChangesButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK);
            }
        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = productsDataSet.Tables["Product"].NewRow();
                MessageBox.Show("Новая строка добавлена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            try
            {
                productsDataSet.EndInit();
                var index = gridView.CurrentRow.Index;
                productsDataSet.Tables["Product"].Rows[index].Delete();
                MessageBox.Show("Выбранная строка удалена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                productsDataSet.EndInit();
                dataAdapter.Update(productsDataSet.Tables["Product"]);
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }
    }
}
