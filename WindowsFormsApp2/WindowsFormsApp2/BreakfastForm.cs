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
    public partial class BreakfastForm : Form
    {
        public BreakfastForm()
        {
            InitializeComponent();
        }

        private void BreakfastForm_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int TotalPrice = 0;
            if (checkBox1.Checked)
            {
                TotalPrice = TotalPrice + 20;
            }
            if (checkBox2.Checked)
            {
                TotalPrice = TotalPrice + 25;
            }
            if (checkBox3.Checked)
            {
                TotalPrice = TotalPrice + 20;
            }
            if (checkBox4.Checked)
            {
                TotalPrice = TotalPrice + 250;
            }
            if (checkBox5.Checked)
            {
                TotalPrice = TotalPrice + 30;
            }


            label7.Text = Convert.ToString(TotalPrice);

        
    }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            Visible = false;

        }
    }
}
