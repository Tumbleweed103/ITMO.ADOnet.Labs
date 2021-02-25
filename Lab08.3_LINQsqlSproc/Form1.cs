using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_3_LINQsqlSproc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Northwind db = new Northwind(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = Northwind; Integrated Security = True");

        private void button1_Click(object sender, EventArgs e)
        {
            string param = textBox1.Text;
            var custQuery = db.CustOrdersDetail(Convert.ToInt32(param));
            string msg = "";

            foreach (CustOrdersDetailResult custOrdersDetail in custQuery)
            {
                msg = msg + custOrdersDetail.ProductName + "\n";
            }
            if (msg == "")
            {
                msg = "No results.";
            }
            MessageBox.Show(msg);
            param = "";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string param = textBox2.Text;
            var custQuery = db.CustOrderHist(param);
            string msg = "";

            foreach (CustOrderHistResult custOrdHist in custQuery)
            {
                msg = msg + custOrdHist.ProductName + "\n";
            }
            MessageBox.Show(msg);
            param = "";
            textBox2.Text = "";
        }
    }
}
