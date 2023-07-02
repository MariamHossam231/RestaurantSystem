using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = comboBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Show();
                comboBox1.Show();
                label3.Show();
                label4.Show();
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label2.Hide();
                comboBox1.Hide();
                label3.Hide();
                label4.Hide();
            }
        }
        void button1_Click(object sender, EventArgs e)
        { 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(radioButton1.Checked || radioButton2.Checked)
            {Application.Exit();}
            else
            {
                label6.Text = "please check your order!";
            }
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RatingButton_Click(object sender, EventArgs e)
        {
            RatingForm f7 = new RatingForm();
            f7.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
