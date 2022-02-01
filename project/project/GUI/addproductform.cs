using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SuperMarket;

namespace project.GUI
{
    public partial class addproductform : Form
    {
        public addproductform()
        {
            InitializeComponent();
        }

        private void addproductform_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainform mm = new GUI.mainform();
            this.Hide();
            mm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            crq.excuteNotReturnCommand(string.Format("insert into product values(null,\"{0}\",\"{1}\",{2},{3},{4})", NameTextBox.Text, TypeTextBox.Text, PriceTextBox.Text, MarketPriceTextBox.Text, AmountTextBox.Text));
            crq.closeConnection();
            MessageBox.Show("Product Added Successfuly!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productlistform allProduct = new productlistform();
            this.Hide();
            allProduct.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MarketPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
