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
    public partial class Suppliersform : Form
    {
        public Suppliersform()
        {
            InitializeComponent();
        }

        private void Suppliersform_Load(object sender, EventArgs e)
        {
            MySqlDataReader dataReader = null;
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand("select * from supplier");
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dataGridView1.DataSource = dataTable;
            crq.closeConnection();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string choice = "";
            if (radioButtonPhone.Checked)
            {
                choice = string.Format(" where Supplier_phone=\"{0}\"", SearchPhoneTextBox.Text);
            }
            else if (radioButtonName.Checked)
            {

                choice = string.Format(" where Supplier_name like \"%{0}%\"", SearchNameTextBox.Text);
            }
           
            MySqlDataReader dataReader = null;
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand("select * from supplier" + choice);
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

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            crq.excuteNotReturnCommand(string.Format("update supplier set Supplier_phone =\"{0}\", Supplier_address = \"{1}\", Supplier_email =\"{2}\" where Supplier_id = {3} ", PhoneTextBox.Text, AddressTextBox.Text, EMailTextBox.Text, IDTextBox.Text));
            crq.closeConnection();

            //refresh product list

            MySqlDataReader dataReader = null;
            crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand("Show_suppliers");
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dataGridView1.DataSource = dataTable;
            crq.closeConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            newuser addSupplier = new newuser();
            this.Hide();
            addSupplier.Show();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string id = "1";
            try
            {
                if (dataGridView1.CurrentRow != null)
                    id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            }
            catch (Exception ex)
            {

            }
            MySqlDataReader dataReader = null;
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand(string.Format("select * from supplier where Supplier_id={0}", id));
            while (dataReader.Read())
            {
                IDTextBox.Text = dataReader[0].ToString();
               NameTextBox.Text = dataReader[1].ToString();
                PhoneTextBox.Text = dataReader[2].ToString();
                AddressTextBox.Text = dataReader[3].ToString();
                EMailTextBox.Text = dataReader[4].ToString();
            }

            crq.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            crq.excuteNotReturnCommand(string.Format("delete from supplier where Supplier_id = {0}", IDTextBox.Text));
            crq.closeConnection();

            //refresh product list

            MySqlDataReader dataReader = null;
            crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand("Show_suppliers");
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            dataGridView1.DataSource = dataTable;
            crq.closeConnection();
        }
    }
}
