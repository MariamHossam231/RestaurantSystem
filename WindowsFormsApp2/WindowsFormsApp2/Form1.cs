using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text =="customer"  && textBox2.Text=="customer")
            {
                Form4 f4 = new Form4();
                f4.Show();
                Visible = false;
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form3 f3 = new Form3();
                f3.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("The Username or password you entered is invalid , Please try again");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_ShowPassSignIn.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }

            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
