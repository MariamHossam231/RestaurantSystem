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
    public partial class LunchForm : Form
    {
        public LunchForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int TotalPrice = 0;
            if (checkBox1.Checked)
            {
                TotalPrice = TotalPrice + 500;
            }
            if (checkBox2.Checked)
            {
                TotalPrice = TotalPrice + 150;
            }
            if (checkBox3.Checked)
            {
                TotalPrice = TotalPrice + 300;
            }
            
            label7.Text = Convert.ToString(TotalPrice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            Visible = false;
        }

        private void LunchForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
