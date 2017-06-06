#define _CRT_SECURE_NO_WARNINGS

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DataBase
{
    public partial class Authentication : Form
    {
        private string LoginStr;
        private string PassStr;

        public Authentication()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                string oradb = "Data Source=XE;User Id=" + LoginText.Text + ";Password=" + PasswordText.Text + ";";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                Form2 secondform = new Form2(conn);
                secondform.Show();
                this.Hide();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show("Wrong Login or Password");
                this.Close();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show("Wrong Login or Password");
                this.Close();
            }
        }

        private void LoginText_TextChanged(object sender, EventArgs e)
        {
        }

        private void Authentication_Load(object sender, EventArgs e)
        {
        }
    }
}