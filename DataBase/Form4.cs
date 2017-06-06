using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form4 : Form
    {
        private OracleConnection Connection;
        private Form2 old;
        private String id;

        public Form4(OracleConnection conn, Form2 f, String _id)
        {
            try
            {
                InitializeComponent();
                Connection = conn;
                old = f;
                id = _id;

                OracleCommand oraCommand = new OracleCommand("SELECT * FROM ARTICLES WHERE ID = " + this.id, Connection);
                OracleDataReader oraReader = oraCommand.ExecuteReader();

                if (oraReader.HasRows)
                {
                    oraReader.Read();

                    au_name.Text = oraReader.GetString(1);
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show(ex.Message);
                old.Show();
                //this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pu_add_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "UPDATE ARTICLES set NAME = '" + au_name.Text + "' WHERE ID = " + this.id;
                OracleDataReader dr;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                this.pu_cancel_Click(sender, e);
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show(ex.Message);
                old.Show();
                //this.Close();
            }
        }

        private void pu_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                old.Show();
                old.getArticles();
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

        private void Form4_Load(object sender, EventArgs e)
        {
        }
    }
}