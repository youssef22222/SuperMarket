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
    public partial class productlistform : Form
    {
        public productlistform()
        {
            InitializeComponent();
        }

        private void productlistform_Load(object sender, EventArgs e)
        {
            MySqlDataReader dataReader = null;
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand("select * from product");
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dataGridView1.DataSource = dataTable;
            crq.closeConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainform mm = new GUI.mainform();
            this.Hide();
            mm.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            string choice = "";
            if (radioButtonAmount.Checked)
            {
                choice = string.Format(" where product_quantity={0}", AmountTextBox.Text);
            }
            else if (radioButtonName.Checked)
            {

                choice = string.Format(" where product_name=\"{0}\"", NameTextBox.Text);
            }
            else if (radioButtonPrice.Checked)
            {
                choice = string.Format(" where product_price={0}", PriceTextBox2.Text);
            }

            MySqlDataReader dataReader = null;
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand("select * from product" + choice);
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dataGridView1.DataSource = dataTable;
            crq.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            crq.excuteNotReturnCommand(string.Format("update product set product_price = {0}, product_Market_Price = {1}, product_quantity = {2} where Product_id = {3} ", EditPriceTextBox.Text, EditMarketPriceTextBox.Text, EditAmountTextBox.Text, IDTextBox.Text));
            crq.closeConnection();

            //refresh product list

            MySqlDataReader dataReader = null;
            crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand("Show_products");
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dataGridView1.DataSource = dataTable;
            crq.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            crq.excuteNotReturnCommand(string.Format("delete from product where Product_id = {0}", IDTextBox.Text));
            crq.closeConnection();

            //refresh product list

            MySqlDataReader dataReader = null;
            crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand("Show_products");
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dataGridView1.DataSource = dataTable;
            crq.closeConnection();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string id="1";
            try
            {
                if (dataGridView1.CurrentRow!= null)
                    id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            }
            catch(Exception ex)
            {

            }
           MySqlDataReader dataReader = null;
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand(string.Format("select * from product where Product_id={0}", id));
            while (dataReader.Read())
            {
                IDTextBox.Text = dataReader[0].ToString();
                EditNameTextBox.Text = dataReader[1].ToString();
                EditTypeTextBox.Text = dataReader[2].ToString();
                EditPriceTextBox.Text = dataReader[3].ToString();
                EditMarketPriceTextBox.Text = dataReader[4].ToString();
                EditAmountTextBox.Text = dataReader[5].ToString();
            }

            crq.closeConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addproductform add = new addproductform();
            this.Hide();
            add.Show();
        }
    }
}
