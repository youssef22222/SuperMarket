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
using project.GUI;
namespace project.GUI
{
    public partial class customerform : Form
    {
        public static List<string> pName=new List<string>();
        public static List<int> pPrice = new List<int>();
        public static List<int> pTotalPrice=new List<int>();
        public static List<int> pAmount=new List<int>();
        string[] billProducts;
        int totalPrice=0;
        public static int allPrice;
        public static int Bill_id; 
        public customerform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainform mm = new GUI.mainform();
            this.Hide();
            mm.Show();

        }

        private void customerform_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Product ID";
            dataGridView1.Columns[1].Name = "Product Name";
            dataGridView1.Columns[2].Name = "Product Type";
            dataGridView1.Columns[3].Name = "Product Price";
            dataGridView1.Columns[4].Name = "Product Quantity";
            dataGridView1.Columns[5].Name = "Total";
            MySqlDataReader dataReader = null;
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand(string.Format("select product_name from product"));
            List<string> productNames = new List<string>();
            while (dataReader.Read())
            {
                productNames.Add(dataReader[0].ToString());
            }
            comboBox1.DataSource = productNames;
            crq.closeConnection();


        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            MySqlDataReader dataReader = null;
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand(string.Format("select * from product where product_name=\"{0}\" and product_quantity >={1}", comboBox1.SelectedItem.ToString(), AmountTextBox.Text));
            while (dataReader.Read())
            {
                billProducts = new string[] { dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), AmountTextBox.Text, (int.Parse(dataReader[3].ToString()) * int.Parse(AmountTextBox.Text)).ToString() };
                dataGridView1.Rows.Add(billProducts);
                totalPrice += (int.Parse(dataReader[3].ToString()) * int.Parse(AmountTextBox.Text));
                TotalTextBox.Text = totalPrice.ToString();
                pName.Add(dataReader[1].ToString());
                pPrice.Add(int.Parse(dataReader[3].ToString()));
                pAmount.Add(int.Parse(AmountTextBox.Text));
                pTotalPrice.Add(int.Parse((int.Parse(dataReader[3].ToString()) * int.Parse(AmountTextBox.Text)).ToString()));


            }

            crq.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            allPrice = totalPrice;
            ConnectionReturnQuery conn = new ConnectionReturnQuery();
            conn.openConnection();
            conn.excuteNotReturnCommand(string.Format("insert into bill values (null,\"{0}\",{1},\"{2}\")",DateTime.Now.ToString(),totalPrice,login.currentBranchName));
            conn.closeConnection();
            ConnectionReturnQuery conn2 = new ConnectionReturnQuery();
            conn2.openConnection();
            Bill_id=conn2.excuteReturnCount(string.Format("select max(Bill_id) from bill"));
            conn2.closeConnection();

            foreach (DataGridViewRow dataRow in dataGridView1.Rows)
            {
                if (dataRow.Cells[0].Value == null)
                    break;

              
                try
                {
                    ConnectionReturnQuery crq = new ConnectionReturnQuery();
                    crq.openConnection();
                    crq.excuteNotReturnCommand(string.Format("update product set product_quantity = product.product_quantity-{0} where Product_id = {1} ", int.Parse(dataRow.Cells[4].Value.ToString()), dataRow.Cells[0].Value.ToString()));
                    crq.closeConnection();
                }
                catch (Exception ex)
                {

                }


            }
            foreach (DataGridViewRow dataRow in dataGridView1.Rows)
            {
               if(dataRow.Cells[0].Value==null)
                    break;
               
               try
                {
                    ConnectionReturnQuery crq = new ConnectionReturnQuery();
                    crq.openConnection();
                    crq.excuteNotReturnCommand(string.Format("insert into buy values ({0},{1},{2})",Bill_id, int.Parse(dataRow.Cells[0].Value.ToString()), dataRow.Cells[4].Value.ToString()));
                    crq.closeConnection();
                }
                catch(Exception ex)
                {

                }
                

            }
            SalesBillform printBill = new SalesBillform();
            this.Hide();
            printBill.Show();
        }
    }
}
