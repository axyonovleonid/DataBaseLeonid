using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System;
using System.Data;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form2 : Form
    {
        private OracleConnection Connection;

        public void getArticles()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("Наименование");

                dataGridView1.DataSource = table;

                OracleCommand oraCommand = new OracleCommand("SELECT * FROM ARTICLES", Connection);

                OracleDataReader oraReader = null;
                oraReader = oraCommand.ExecuteReader();

                if (oraReader.HasRows)
                {
                    while (oraReader.Read())
                    {
                        double id_ = (double)(oraReader.GetDecimal(0));
                        string id = "";
                        id += id_;

                        table.Rows.Add(id, oraReader.GetString(1));
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show("Что то пошло не так!");
                this.Close();
            }
        }

        public void getOperations()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("Статья");
                table.Columns.Add("Дебет");
                table.Columns.Add("Кредит");
                table.Columns.Add("Время");
                table.Columns.Add("Баланс");

                dataGridView2.DataSource = table;

                OracleCommand oraCommand = new OracleCommand("SELECT OPERATIONS.*, ARTICLES.NAME FROM OPERATIONS JOIN ARTICLES ON ARTICLES.ID = OPERATIONS.ARTICLE_ID", Connection);

                OracleDataReader oraReader = null;
                oraReader = oraCommand.ExecuteReader();

                if (oraReader.HasRows)
                {
                    while (oraReader.Read())
                    {
                        double id_ = (double)(oraReader.GetDecimal(0));
                        string id = "";
                        id += id_;

                        double debit_ = (double)(oraReader.GetDecimal(2));
                        string debit = "" + debit_;
                        double credit_ = (double)(oraReader.GetDecimal(3));
                        string credit = "" + credit_;
                        string balance = "";
                        if (!oraReader.IsDBNull(5))
                        {
                            double balance_ = (double)(oraReader.GetDecimal(5));
                            balance = "" + balance_;
                        }

                        OracleTimeStamp timeSpan = oraReader.GetOracleTimeStamp(4);
                        string time = timeSpan.ToString();

                        table.Rows.Add(id_, oraReader.GetString(6), debit, credit, time, balance);
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show("Что то пошло не так!");
                this.Close();
            }
        }

        public void getBalance()
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("Время");
                table.Columns.Add("Дебит");
                table.Columns.Add("Кредит");
                table.Columns.Add("Прибыль");

                dataGridView3.DataSource = table;

                OracleCommand oraCommand = new OracleCommand("SELECT * FROM BALANCE", Connection);

                OracleDataReader oraReader = null;
                oraReader = oraCommand.ExecuteReader();

                if (oraReader.HasRows)
                {
                    while (oraReader.Read())
                    {
                        double id_ = (double)(oraReader.GetDecimal(0));
                        string id = "";
                        id += id_;

                        OracleTimeStamp timeSpan = oraReader.GetOracleTimeStamp(1);
                        string time = timeSpan.ToString();

                        double debit_ = (double)(oraReader.GetDecimal(2));
                        string debit = "" + debit_;
                        double credit_ = (double)(oraReader.GetDecimal(3));
                        string credit = "" + credit_;
                        double amount_ = (double)(oraReader.GetDecimal(4));
                        string amount = "" + amount_;

                        table.Rows.Add(id, time, debit, credit, amount);
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show("Что то пошло не так!");
                this.Close();
            }
        }

        public void getStats()
        {
            try
            {
                DataTable table = new DataTable();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection;
                table.Columns.Add("Максимальная прибыль");
                table.Columns.Add("Общая прибыль");
                table.Columns.Add("Наибольшая трата");
                table.Columns.Add("Самая затратная статья");

                dataGridView4.DataSource = table;

                cmd.CommandText = ("SELECT MAX(BALANCE.AMOUNT) FROM BALANCE  WHERE BALANCE.CREATE_DATE > sysdate - interval \'7\' day");
                cmd.CommandType = CommandType.Text;
                OracleDataReader oraReader = cmd.ExecuteReader();
                oraReader.Read();
                double max_amount = (double)(oraReader.GetDecimal(0));

                cmd.CommandText = ("SELECT SUM(BALANCE.AMOUNT) FROM BALANCE WHERE BALANCE.CREATE_DATE > sysdate - interval '7' day");
                cmd.CommandType = CommandType.Text;
                oraReader = cmd.ExecuteReader();
                oraReader.Read();
                double all_amount = (double)(oraReader.GetDecimal(0));

                cmd.CommandText = ("SELECT MAX(OPERATIONS.CREDIT) FROM OPERATIONS WHERE OPERATIONS.CREATE_DATE > sysdate - interval \'7\' day");
                cmd.CommandType = CommandType.Text;
                oraReader = cmd.ExecuteReader();
                oraReader.Read();
                double max_credit = (double)(oraReader.GetDecimal(0));

                cmd.CommandText = ("SELECT ARTICLES.NAME FROM ARTICLES WHERE ARTICLES.ID = (SELECT c2 FROM (SELECT  SUM(OPERATIONS.CREDIT) AS c1, OPERATIONS.ARTICLE_ID AS c2 FROM OPERATIONS GROUP BY OPERATIONS.ARTICLE_ID) WHERE c1 = (SELECT MAX(c1) FROM(" +
                "SELECT SUM(OPERATIONS.CREDIT)AS c1, OPERATIONS.ARTICLE_ID AS c2 FROM OPERATIONS WHERE OPERATIONS.CREATE_DATE > sysdate - interval '7' day GROUP BY OPERATIONS.ARTICLE_ID)))");
                cmd.CommandType = CommandType.Text;
                oraReader = cmd.ExecuteReader();
                oraReader.Read();
                string max_article = oraReader.GetString(0);

                table.Rows.Add(max_amount + "", all_amount + "", max_credit + "", max_article);
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                MessageBox.Show("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show("Что то пошло не так!");
                this.Close();
            }
        }

        public Form2(OracleConnection conn)
        {
            try
            {
                InitializeComponent();
                Connection = conn;

                this.getArticles();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 secondform = new Form3(Connection, this);
                secondform.Show();
                this.Hide();
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "select id from ARTICLES WHERE ID = " + a_id.Text;
                cmd.CommandType = CommandType.Text;
                OracleDataReader oraReader = cmd.ExecuteReader();

                if (oraReader.HasRows)
                {
                    oraReader.Read();
                    Form4 secondform = new Form4(Connection, this, a_id.Text);
                    secondform.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Не найдена статья с таким ID");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "Delete ARTICLES where id='" + a_id.Text + "'";
                OracleDataReader dr;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                this.getArticles();

                a_id.Text = "";
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e) //del
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "Delete OPERATIONS where id='" + o_id.Text + "'";
                OracleDataReader dr;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                this.getOperations();

                o_id.Text = "";
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "select id from OPERATIONS WHERE ID = " + o_id.Text;
                cmd.CommandType = CommandType.Text;
                OracleDataReader oraReader = cmd.ExecuteReader();

                if (oraReader.HasRows)
                {
                    oraReader.Read();
                    Form6 secondform = new Form6(Connection, this, o_id.Text);
                    secondform.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Не найдена операция с таким ID");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Form5 secondform = new Form5(Connection, this);
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "Delete BALANCE where id='" + g_id.Text + "'";
                OracleDataReader dr;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
                this.getBalance();

                g_id.Text = "";
            }
            catch (OracleException ex)
            {
                Console.WriteLine("Record is not inserted into the database table.");
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Exception Source: " + ex.Source);
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OracleCommand command = new OracleCommand("ADD_BALANCE_NEW", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            this.getBalance();
            this.getOperations();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.getArticles();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.getOperations();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.getBalance();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.getStats();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}