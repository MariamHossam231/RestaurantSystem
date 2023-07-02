using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        String constring = "datasource=127.0.0.1;port=3306;username=root;password=;database=restaurant";
        public Form3()
        {
            InitializeComponent();
        }
        void button1_Click(object sender, EventArgs e)
        {


            String myquery = ("SELECT * FROM admin");
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand commandDatabase = new MySqlCommand(myquery, con);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                con.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Name  Password    Hours   Salary
                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));

                    }
                }
                else
                {
                    Console.WriteLine("NO ROWS FOUND");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            MySqlDataAdapter adapt;
            adapt = new MySqlDataAdapter("select * from admin where name like '" + nametextBox.Text + "%'", con);

            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void detailbutton_Click(object sender, EventArgs e)
        {
            String myquery = ("SELECT * FROM admin ;");
            MySqlConnection con = new MySqlConnection(constring);
            MySqlCommand commandDatabase = new MySqlCommand(myquery, con);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            con.Open();


            using (MySqlDataAdapter adapter = new MySqlDataAdapter(myquery, con))
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }


            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Visible = false;
        }
    }
}