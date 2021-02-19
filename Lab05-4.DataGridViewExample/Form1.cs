using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_4.DataGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            DataColumn Location = new DataColumn("Location");
            Location.Expression = "City + ',' + Country";
            northwindDataSet.Customers.Columns.Add(Location);
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            DataGridViewColumn LocationColumn = new DataGridViewColumn();
            LocationColumn.Name = "LocationColumn";
            LocationColumn.HeaderText = "Location";
            LocationColumn.DataPropertyName = "Location";
            customersDataGridView.Columns.Add(LocationColumn);
        }

        private void DeleteColumnButton_Click(object sender, EventArgs e)
        {
            try
            {
                customersDataGridView.Columns.Remove("LocationColumn");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
