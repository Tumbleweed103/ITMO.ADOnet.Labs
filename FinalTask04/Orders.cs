using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using static FinalTask4.Model;

namespace FinalTask4
{
    public partial class OrdersForm : Form
    {
        OrdersContext context = new OrdersContext();

        public OrdersForm()
        {
            InitializeComponent();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = new Order
                {
                    Product = productTextBox.Text,
                    Quantity = Convert.ToInt32(quantityTextBox.Text),
                    Price = Convert.ToInt32(priceTextBox.Text),
                    DeliveryType = deliveryTypeTextBox.Text,
                    Address = addressTextBox.Text,
                    PaymentType = paymentTypeTextBox.Text,
                    OrderDate = DateTime.Now
                };

                context.Orders.Add(order);
                context.SaveChanges();
                BindDataSource();
                Refresh();

                productTextBox.Text = "";
                quantityTextBox.Text = "";
                priceTextBox.Text = "";
                deliveryTypeTextBox.Text = "";
                paymentTypeTextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void viewOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                BindDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = ordersGridView.CurrentCell.RowIndex;
                ordersGridView.Rows.RemoveAt(index);
                MessageBox.Show("Запись удалена!");
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
                context.SaveChanges();
                Refresh();
                MessageBox.Show("Изменения сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
            }
        }

        private void BindDataSource()
        {
            var orders = from o in context.Orders
                         select o;
            ordersGridView.DataSource = new BindingList<Order>(orders.ToList());
            ordersGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
            context.Dispose();
        }
    }
}