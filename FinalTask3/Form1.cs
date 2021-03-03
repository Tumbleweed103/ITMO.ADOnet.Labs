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

namespace FinalTask3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customerGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private CustomerEntities customerContext;

        private void showCustomersButton_Click(object sender, EventArgs e)
        {
            customerContext = new CustomerEntities();
            var customers = from People in customerContext.People
                            join EmailAddresses in customerContext.EmailAddresses
                            on People.BusinessEntityID equals EmailAddresses.BusinessEntityID
                            join PersonPhones in customerContext.PersonPhones
                            on People.BusinessEntityID equals PersonPhones.BusinessEntityID
                            where People.PersonType == "IN"
                            orderby People.BusinessEntityID
                            let p = new CustomerOutput { 
                                ID = People.BusinessEntityID, 
                                FirstName = People.FirstName,
                                LastName = People.LastName,
                                Email = EmailAddresses.EmailAddress1,
                                Phone = PersonPhones.PhoneNumber }
                            select p;
            try
            {
                customerGridView.DataSource = new BindingList<CustomerOutput>(customers.ToList());
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
                customerContext.SaveChanges();
                MessageBox.Show("Изменения сохранены!");
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentCustomer = customerGridView.CurrentRow.DataBoundItem as Person;
            var id = Convert.ToInt32(currentCustomer.BusinessEntityID);
            var modifiedEntry = customerContext.People.Find(id);
            customerContext.Entry(modifiedEntry).State = EntityState.Modified;
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            Close();
            customerContext.Dispose();
        }
    }
}
