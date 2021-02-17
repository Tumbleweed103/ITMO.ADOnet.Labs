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

namespace DBCommand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SimpleQueryButton_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            using (sqlConnection)
            {
                try
                {
                    sqlConnection.Open();
                    SqlDataReader reader = selectSqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i].ToString() + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }
                    ResultsTextBox.Text = results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MultiQueryButton_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            using (sqlConnection)
            {
                selectSqlCommand.CommandText = "SELECT CustomerID, CompanyName FROM Customers; " + "SELECT ProductName, UnitPrice, QuantityPerUnit FROM Products";
                try
                {
                    sqlConnection.Open();
                    SqlDataReader reader = selectSqlCommand.ExecuteReader();
                    bool moreResults = false;
                    do
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                results.Append(reader[i].ToString() + "\t");
                            }
                            results.Append(Environment.NewLine);
                        }
                        moreResults = reader.NextResult();
                    }
                    while (moreResults);
                    ResultsTextBox.Text = results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProcedureQueryButton_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            using (sqlConnection)
            {
                try
                {
                    sqlConnection.Open();
                    SqlDataReader reader = procedureSqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            results.Append(reader[i] + "\t");
                        }
                        results.Append(Environment.NewLine);
                    }
                    ResultsTextBox.Text = results.ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            using (sqlConnection)
            {
                createSqlCommand.CommandText = "CREATE TABLE SalesPersons(" +
                    "[SalesPersonID] [int] IDENTITY(1,1) NOT NULL, " +
                    "[FirstName] [nvarchar](50)  NULL, " +
                    "[LastName] [nvarchar](50)  NULL)";
                try
                {
                    sqlConnection.Open();
                    createSqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Таблица SalesPersons создана");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ParameterQueryButton_Click(object sender, EventArgs e)
        {
            StringBuilder results = new StringBuilder();
            try
            {
                parameterSqlCommand.Parameters["@City"].Value = CityTextBox.Text;
                sqlConnection.Open();
                SqlDataReader reader = parameterSqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        results.Append(reader[i].ToString() + "\t");
                    }
                    results.Append(Environment.NewLine);
                }
                ResultsTextBox.Text = results.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void ParameterProcedureButton_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                parameterProcedureSqlCommand.Parameters["@CategoryName"].Value = CategoryNameTextBox.Text;
                parameterProcedureSqlCommand.Parameters["@OrdYear"].Value = OrdYearTextBox.Text;
                sqlConnection.Open();
                SqlDataReader reader = parameterProcedureSqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        result.Append(reader[i] + "\t");
                    }
                    result.Append(Environment.NewLine);
                }
                ResultsTextBox.Text = result.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
