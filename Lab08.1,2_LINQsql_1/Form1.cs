using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Lab08_1_2_LINQsql_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            db = new DataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True");
        }

        DataContext db;

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            var results =
                from customer in db.GetTable<Customer>()
                where customer.City == "London"
                select customer;

            foreach (var customer in results)
            {
                listBox1.Items.Add(customer.ToString());
            }
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerID = "WINGT";
            customer.City = "London";
            customer.CompanyName = "Steve Lasker";

            db.GetTable<Customer>().InsertOnSubmit(customer);
            db.SubmitChanges();
        }

        private void DeleteObjectButton_Click(object sender, EventArgs e)
        {
            var deleteCustomer =
                from customer in db.GetTable<Customer>()
                where customer.CustomerID == "WINGT"
                select customer;

            if (deleteCustomer.Count() > 0)
            {
                db.GetTable<Customer>().DeleteOnSubmit(deleteCustomer.First());
                db.SubmitChanges();
            }
        }

        private void LoadAssociatedDataButton_Click(object sender, EventArgs e)
        {
            var custQuery =
               from cust in db.GetTable<Customer>()
               where cust.Orders.Any()
               select cust;

            foreach (var custObj in custQuery)
            {
                ListViewItem item =
                    listView1.Items.Add(custObj.CustomerID.ToString());
                item.SubItems.Add(custObj.City.ToString());
                item.SubItems.Add(custObj.Orders.Count.ToString());
            }
        }
    }
}
