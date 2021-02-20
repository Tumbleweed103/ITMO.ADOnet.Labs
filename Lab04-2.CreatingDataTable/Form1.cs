using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_2CreatingDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += new EventHandler(Form1_Shown);
        }

        private DataSet dataSet;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;

        private void MakeParentTable()
        {
            DataTable table = new DataTable("ParentTable");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Id";
            column.ReadOnly = true;
            column.Unique = true;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ParentItem";
            column.AutoIncrement = false;
            column.Caption = "ParentItem";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            table.Columns.Add("Total", typeof(Double));
            table.Columns.Add("SalesTax", typeof(Double), "Total * 0.13");

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = table.Columns["Id"];
            table.PrimaryKey = PrimaryKeyColumns;

            dataSet = new DataSet();
            dataSet.Tables.Add(table);

            for (int i = 0; i <= 2; i++)
            {
                row = table.NewRow();
                row["Id"] = i;
                row["ParentItem"] = "ParentItem " + i;
                row["Total"] = 2 * i + 0.5;
                table.Rows.Add(row);
            }
        }

        private void MakeChildTable()
        {
            DataTable table = new DataTable("ChildTable");
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ChildId";
            column.AutoIncrement = true;
            column.Caption = "Id";
            column.ReadOnly = true;
            column.Unique = true;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ChildItem";
            column.AutoIncrement = false;
            column.Caption = "ChildItem";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "ParentId";
            column.AutoIncrement = false;
            column.Caption = "ParentId";
            column.ReadOnly = false;
            column.Unique = false;
            table.Columns.Add(column);

            dataSet.Tables.Add(table);

            for (int i = 0; i <= 4; i++)
            {
                row = table.NewRow();
                row["ChildId"] = i;
                row["ChildItem"] = "Item " + i;
                row["ParentId"] = 0;
                table.Rows.Add(row);
            }

            for (int i = 0; i <= 4; i++)
            {
                row = table.NewRow();
                row["ChildId"] = i + 5;
                row["ChildItem"] = "Item " + i;
                row["ParentId"] = 1;
                table.Rows.Add(row);
            }

            for (int i = 0; i <= 4; i++)
            {
                row = table.NewRow();
                row["ChildId"] = i + 10;
                row["ChildItem"] = "Item " + i;
                row["ParentId"] = 2;
                table.Rows.Add(row);
            }
        }
        private void MakeDataRelation()
        {
            DataColumn parentColumn = dataSet.Tables["ParentTable"].Columns["Id"];
            DataColumn childColumn = dataSet.Tables["ChildTable"].Columns["ParentId"];

            DataRelation relation = new DataRelation("parent2Child", parentColumn, childColumn);
            dataSet.Tables["ChildTable"].ParentRelations.Add(relation);
        }

        private void BindToDataGrid()
        {
            bindingSource1 = new BindingSource();
            bindingSource2 = new BindingSource();
            bindingSource1.DataSource = dataSet.Tables["ChildTable"];
            bindingSource2.DataSource = dataSet.Tables["ParentTable"];
        }

        private void fillChildTableButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
        }

        private void fillParentTableButton_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = bindingSource2;
        }

        private void MakeDataTables()
        {
            MakeParentTable();
            MakeChildTable();
            MakeDataRelation();
            BindToDataGrid();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MakeDataTables();
        }
    }
}
