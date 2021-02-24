using Lab09_2_CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    Name = this.textBoxName.Text,
                    //LastName = this.textBoxLastName.Text,
                    Email = this.textBoxMail.Text,
                    Age = Int32.Parse(this.textBoxAge.Text),
                    Photo = photo
                };
                context.Customers.Add(customer);
                context.SaveChanges();
                Output();
                textBoxName.Text = String.Empty;
                //textBoxLastName.Text = String.Empty;
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
                        orderby b.Name
                        select b;

            customerList.DataSource = query.ToList();
        }
    }
}
