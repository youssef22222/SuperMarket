using project.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarket;
using MySql.Data.MySqlClient;

namespace project
{
    public partial class login : Form
    {
        public static int employeeID;
        public static int branchID;
        public static string currentEmployeeName;
        public static string currentBranchName;
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlDataReader dataReader = null;
            ConnectionReturnQuery crq = new ConnectionReturnQuery();
            crq.openConnection();
            dataReader = crq.excuteReturnCommand(string.Format("select * from log_in where E_id=\"{0}\" and E_Password=\"{1}\"", NameTextBox.Text, PassTextBox.Text));
            bool f = false;
            if (dataReader != null)
            {


                f = true;

                employeeID = int.Parse(NameTextBox.Text);
            }
            crq.closeConnection();



            if (f)
            {
                crq.openConnection();
                dataReader = crq.excuteReturnCommand(string.Format("select * from employee where Employee_id={0}", employeeID));
                while (dataReader.Read())
                {
                    currentEmployeeName = dataReader[1].ToString();
                    branchID = int.Parse(dataReader[4].ToString());
                }
                crq.closeConnection();
                //////
                crq.openConnection();
                dataReader = crq.excuteReturnCommand(string.Format("select * from branch where Branch_id={0}", branchID));
                while (dataReader.Read())
                {
                    currentBranchName = dataReader[2].ToString();

                }
                mainform mm = new GUI.mainform();
            this.Hide();
            mm.Show();
            }
            else
            {
                MessageBox.Show("Wrong password or User Name");
            }
        }
    }
}
