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
    public partial class SalesBillform : Form
    {
        public SalesBillform()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainform mm = new GUI.mainform();
            this.Hide();
            mm.Show();

        }

        private void SalesBillform_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Product Name";
            dataGridView1.Columns[1].Name = "Product Price";
            dataGridView1.Columns[2].Name = "Product Quantity";
            dataGridView1.Columns[3].Name = "Total";

            
           
            for (int i=0;i< customerform.pName.Count; i++)
            {
                string[] arr = new string[] { customerform.pName[i], customerform.pPrice[i].ToString(), customerform.pAmount[i].ToString(), customerform.pTotalPrice[i].ToString() };
                dataGridView1.Rows.Add(arr);

            }
            EmployeeNameLabel.Text = login.currentEmployeeName;
            BranchNameLabel.Text = login.currentBranchName;
            TotalPriceLabel.Text = customerform.allPrice.ToString();
            customerform.pName.Clear();
            customerform.pTotalPrice.Clear();
            customerform.pPrice.Clear();
            customerform.pAmount.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            customerform cu = new customerform();
            this.Hide();
            cu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
