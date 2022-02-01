using System;
using project.GUI;
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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suppliersform sp = new Suppliersform();
            this.Hide();
            sp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            customerform cu = new customerform();
            this.Hide();
            cu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            productlistform pr = new productlistform();
            this.Hide();
            pr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customerform bi = new customerform();
            this.Hide();
            bi.Show();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliersform sp = new Suppliersform();
            this.Hide();
            sp.Show();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addproductform add = new addproductform();
            this.Hide();
            add.Show();
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            productlistform pr = new productlistform();
            this.Hide();
            pr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            login lo = new login();
            this.Hide();
            lo.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newuser ne = new newuser();
            this.Hide();
            ne.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Suppliersform sp = new Suppliersform();
            this.Hide();
            sp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productlistform pr = new productlistform();
            this.Hide();
            pr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            customerform cu = new customerform();
            this.Hide();
            cu.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            customerform bi = new customerform();
            this.Hide();
            bi.Show();
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            purchasebillform nm = new purchasebillform();
            this.Hide();
            nm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            purchasebillform nm = new purchasebillform();
            this.Hide();
            nm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reportsform bn = new reportsform();
            this.Hide();
            bn.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            reportsform bn = new reportsform();
            this.Hide();
            bn.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            productlistform pr = new productlistform();
            this.Hide();
            pr.Show();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            EmployeeLabel.Text = login.currentEmployeeName;
            BranchLabel.Text = login.currentBranchName;
        }

        private void BranchLabel_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Application.Exit();
        }

        private void purchaseBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchasebillform nm = new purchasebillform();
            this.Hide();
            nm.Show();
        }

        private void salesBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerform bi = new customerform();
            this.Hide();
            bi.Show();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newuser addSupplier = new newuser();
            this.Hide();
            addSupplier.Show();
        }

        private void manageSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliersform sp = new Suppliersform();
            this.Hide();
            sp.Show();
        }

        private void editSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliersform sp = new Suppliersform();
            this.Hide();
            sp.Show();
        }
    }
}
