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
    public partial class newuser : Form
    {
        public newuser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainform mm = new GUI.mainform();
            this.Hide();
            mm.Show();

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            crq.excuteNotReturnCommand(string.Format("insert into supplier values(null,\"{0}\",\"{1}\",\"{2}\",\"{3}\")", NameTextBox.Text, PhoneTextBox.Text, AddressTextBox.Text, EMailTextBox.Text));
            crq.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suppliersform mm = new Suppliersform();
            this.Hide();
            mm.Show();
        }
    }
}
