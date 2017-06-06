using Oracle.DataAccess.Client;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form6 : Form
    {
        private OracleConnection Connection;
        private Form2 old;
        private String id;

        public Form6(OracleConnection conn, Form2 f, string _id)
        {
            InitializeComponent();
            Connection = conn;
            old = f;
            id = _id;

            OracleCommand oraCommand = new OracleCommand("SELECT NAME FROM ARTICLES", Connection);
            OracleDataReader oraReader = oraCommand.ExecuteReader();

            if (oraReader.HasRows)
            {
                ArrayList array = new ArrayList();
                array.Add("");

                while (oraReader.Read())
                {
                    array.Add(oraReader.GetString(0));
                }
                ou_article.DataSource = array;
            }

            OracleCommand oraCommand2 = new OracleCommand("SELECT * FROM ( SELECT OPERATIONS.*, ARTICLES.NAME FROM OPERATIONS JOIN ARTICLES ON ARTICLES.ID = OPERATIONS.ARTICLE_ID ) WHERE ID = " + this.id, Connection);

            OracleDataReader oraReader2 = oraCommand2.ExecuteReader();

            if (oraReader2.HasRows)
            {
                double debit_ = (double)(oraReader2.GetDecimal(2));
                string debit = "" + debit_;
                double credit_ = (double)(oraReader2.GetDecimal(3));
                string credit = "" + credit_;

                ou_article.Text = oraReader2.GetString(6);
                ou_credit.Text = credit;
                ou_debit.Text = debit;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string article = "NULL";

                OracleCommand oraCommand = new OracleCommand("SELECT ID FROM ARTICLES WHERE NAME = '" + ou_article.Text + "'", Connection);
                OracleDataReader oraReader = oraCommand.ExecuteReader();
                if (oraReader.HasRows)
                {
                    oraReader.Read();
                    article = "" + (double)(oraReader.GetDecimal(0));
                }

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "UPDATE OPERATIONS set DEBIT = '" + ou_debit.Text + "', CREDIT = '" + ou_credit.Text + "', ARTICLE_ID = " + article + " WHERE ID = " + this.id;
                OracleDataReader dr;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                this.button2_Click_1(sender, e);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                old.Show();
                old.getOperations();
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

        private void su_name_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        }

        private void ou_article_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}