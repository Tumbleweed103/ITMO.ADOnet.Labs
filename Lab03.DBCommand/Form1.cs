﻿using System;
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

        private void simpleQueryButton_Click(object sender, EventArgs e)
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

        private void multiQueryButton_Click(object sender, EventArgs e)
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

        private void procedureQueryButton_Click(object sender, EventArgs e)
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
    }
}
