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
    public partial class RatingForm : Form
    {
        public RatingForm()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.images;
            pictureBox2.Image = Properties.Resources.images; 
            pictureBox3.Image = Properties.Resources.images;
            pictureBox4.Image = Properties.Resources.images;
            pictureBox5.Image = Properties.Resources.images;
            label3.Text = "5";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.images;
            pictureBox2.Image = Properties.Resources.images;
            pictureBox3.Image = Properties.Resources.images;
            pictureBox4.Image = Properties.Resources.images;
            pictureBox5.Image = Properties.Resources.imagesx;
            label3.Text = "4";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.images;
            pictureBox2.Image = Properties.Resources.images;
            pictureBox3.Image = Properties.Resources.images;
            pictureBox4.Image = Properties.Resources.imagesx;
            pictureBox5.Image = Properties.Resources.imagesx;
            label3.Text = "3";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.images;
            pictureBox2.Image = Properties.Resources.images;
            pictureBox3.Image = Properties.Resources.imagesx;
            pictureBox4.Image = Properties.Resources.imagesx;
            pictureBox5.Image = Properties.Resources.imagesx;
            label3.Text = "2";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.images;
            pictureBox2.Image = Properties.Resources.imagesx;
            pictureBox3.Image = Properties.Resources.imagesx;
            pictureBox4.Image = Properties.Resources.imagesx;
            pictureBox5.Image = Properties.Resources.imagesx;
            label3.Text = "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
