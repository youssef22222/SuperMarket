using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace SuperMarket
{
    class ConnectionReturnQuery
    {
        public string myConnectionString = "server=localhost;uid=root;" +
                 "pwd=rootroot;database=SuperMarket";
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dataReader;
        public ConnectionReturnQuery()
        {

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void openConnection()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n openConnection");
            }

        }
        public void closeConnection()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n closeConnection");
            }

        }
        public void excuteNotReturnCommand(string command)
        {
            //cmd = new MySqlCommand(command, conn);
            //cmd.ExecuteNonQuery();
            try
            {
                cmd = new MySqlCommand(command, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message + "\nexcuteNotReturnCommand");
            }
        }
        public MySqlDataReader excuteReturnCommand(string command)
        {
            try
            {
                cmd = new MySqlCommand(command, conn);
                dataReader = cmd.ExecuteReader();

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + "\nexcuteReturnCommand");
            }
            return dataReader;
        }

        public int excuteReturnCount(string command)
        {
            int count=0;
            try
            {
                cmd = new MySqlCommand(command, conn);
                count =int.Parse( cmd.ExecuteScalar().ToString());

            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message + "\nexcuteReturnCommand");
            }
            return count;
        }
    }
}
