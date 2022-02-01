using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.GUI
{
    public partial class reportsform : Form
    {
        public reportsform()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainform mm = new GUI.mainform();
            this.Hide();
            mm.Show();
        }

        private void reportsform_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Product Name";
            dataGridView1.Columns[1].Name = "Product Price";
            dataGridView1.Columns[2].Name = "Product Quantity";
            dataGridView1.Columns[3].Name = "Total";


            int mn = Math.Min(purchasebillform.pName.Count,Math.Min(purchasebillform.pPrice.Count,Math.Min(purchasebillform.pAmount.Count,purchasebillform.pTotalPrice.Count)));
            for (int i = 0; i < mn; i++)
            {
                string[] arr = new string[] { purchasebillform.pName[i], purchasebillform.pPrice[i].ToString(), purchasebillform.pAmount[i].ToString(), purchasebillform.pTotalPrice[i].ToString() };
                dataGridView1.Rows.Add(arr);

            }
            EmployeeNameLabel.Text = login.currentEmployeeName;
            BranchNameLabel.Text = login.currentBranchName;
            TotalPriceLabel.Text = purchasebillform.allPrice.ToString();
            purchasebillform.pName.Clear();
            purchasebillform.pTotalPrice.Clear();
            purchasebillform.pPrice.Clear();
            purchasebillform.pAmount.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            purchasebillform supp = new purchasebillform();
            this.Hide();
            supp.Show();
        }
    }
}
