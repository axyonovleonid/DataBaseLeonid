using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form3 : Form
    {
        private OracleConnection Connection;
        private Form2 old;

        public Form3(OracleConnection conn, Form2 f)
        {
            InitializeComponent();
            Connection = conn;
            old = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "Insert into ARTICLES(NAME) values('" + ai_name.Text + "')";
                OracleDataReader dr;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                this.button2_Click(sender, e);
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show(ex.Message);
                old.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                old.getArticles();
                old.Show();
                this.Close();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show("Wrong Login or Password");
                old.Show();
                this.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void group_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void pi_l_name_TextChanged(object sender, EventArgs e)
        {
        }
    }
}