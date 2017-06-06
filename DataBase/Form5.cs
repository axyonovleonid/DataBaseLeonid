using Oracle.DataAccess.Client;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form5 : Form
    {
        private OracleConnection Connection;
        private Form2 old;

        public Form5(OracleConnection conn, Form2 f)
        {
            InitializeComponent();
            Connection = conn;
            old = f;

            oi_time.Format = DateTimePickerFormat.Custom;
            oi_time.CustomFormat = "MM/dd/yyyy hh:mm:ss";

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
                oi_article.DataSource = array;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string article = "NULL";

                OracleCommand oraCommand = new OracleCommand("SELECT ID FROM ARTICLES WHERE NAME = '" + oi_article.Text + "'", Connection);
                OracleDataReader oraReader = oraCommand.ExecuteReader();
                if (oraReader.HasRows)
                {
                    oraReader.Read();
                    article = "" + (double)(oraReader.GetDecimal(0));
                }

                string timestamp = oi_time.Value.ToString();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "Insert into OPERATIONS (ARTICLE_ID, DEBIT, CREDIT, CREATE_DATE ) values( " + article + ", '" + oi_debit.Text + "', '" + oi_credit.Text + "', TO_TIMESTAMP('" + timestamp + "', 'MM/DD/YYYY HH24:MI:SS') )";
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

        private void pu_l_name_TextChanged(object sender, EventArgs e)
        {
        }
    }
}