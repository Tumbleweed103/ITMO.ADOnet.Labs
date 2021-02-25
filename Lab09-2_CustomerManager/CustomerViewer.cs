﻿using Lab09_2_CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_2_CustomerManager
{
    public partial class CustomerViewer : Form
    {
        public CustomerViewer()
        {
            InitializeComponent();
        }

        SampleContext context = new SampleContext();
        byte[] photo;

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    FirstName = this.textBoxName.Text,
                    LastName = this.textBoxLastName.Text,
                    Email = this.textBoxMail.Text,
                    Age = Int32.Parse(this.textBoxAge.Text),
                    Photo = photo,
                    Orders = orderListBox.SelectedItems.OfType<Order>().ToList()
            };
                context.Customers.Add(customer);
                context.SaveChanges();
                Output();
                textBoxName.Text = String.Empty;
                textBoxLastName.Text = String.Empty;
                textBoxMail.Text = String.Empty;
                textBoxAge.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image bitmap = new Bitmap(dialog.OpenFile());

                ImageConverter converter = new ImageConverter();
                photo = (byte[])converter.ConvertTo(bitmap, typeof(byte[]));
            }
        }

        private void Output()
        {
            if (customerRadioButton.Checked == true)
            {
                GridView.DataSource = context.Customers.ToList();
            }
            else if (orderRadioButton.Checked == true)
            {
                GridView.DataSource = context.Orders.ToList();
            }
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            Output();
            var query = from b in context.Customers
                        orderby b.FirstName
                        select b;

            customerList.DataSource = query.ToList();
        }

        private void CustomerViewer_Load(object sender, EventArgs e)
        {
            context.Orders.Add(new Order
            {
                ProductName = "Аудио",
                Quantity = 12,
                PurchaseDate = DateTime.Parse("12.01.2016")
            });
            context.Orders.Add(new Order
            {
                ProductName = "Видео",
                Quantity = 22,
                PurchaseDate = DateTime.Parse("10.01.2016")
            });
            context.SaveChanges();
            orderListBox.DataSource = context.Orders.ToList();
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridView.CurrentRow == null) return;
            var customer = GridView.CurrentRow.DataBoundItem as Customer;
            if (customer == null) return;

            labelId.Text = Convert.ToString(customer.CustomerId);
            textBoxCustomer.Text = customer.ToString();
            textBoxName.Text = customer.FirstName;
            textBoxLastName.Text = customer.LastName;
            textBoxMail.Text = customer.Email;
            textBoxAge.Text = Convert.ToString(customer.Age);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (labelId.Text == String.Empty) return;

            var id = Convert.ToInt32(labelId.Text);
            var customer = context.Customers.Find(id);
            if (customer == null) return;

            customer.FirstName = this.textBoxName.Text;
            customer.LastName = this.textBoxLastName.Text;
            customer.Email = this.textBoxMail.Text;
            customer.Age = Int32.Parse(this.textBoxAge.Text);

            context.Entry(customer).State = EntityState.Modified;

            context.SaveChanges();
            Output();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (labelId.Text == String.Empty) return;

            var id = Convert.ToInt32(labelId.Text);
            var customer = context.Customers.Find(id);

            context.Entry(customer).State = EntityState.Deleted;
            context.SaveChanges();
            Output();
        }
    }
}
