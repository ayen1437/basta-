using System.Collections;
using MySql.Data.MySqlClient;

namespace SLEEP_LOG
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost; database =sleep_log; user=root;password=;";
        MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();

            connection = new MySqlConnection(connectionString);

            for (int month = 1; month <= 12; month++)
            {
                comboBox1.Items.Add(month);

            }
            for (int day = 1; day <= 31; day++)
            {
                comboBox2.Items.Add(day);

            }
            for (int year = 2010; year <= 2025; year++)
            {
                comboBox3.Items.Add(year);

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                string sleep = textBox1.Text;
                string wakingup=textBox1.Text;
                string month=comboBox1.Text;
                string day=comboBox2.Text;
                string year=comboBox3.Text;


                
                listBox1.Items.Add(month +"/"+ day+ "/" +"/"+year +"    "+ sleep +"      "+ wakingup);

                
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
