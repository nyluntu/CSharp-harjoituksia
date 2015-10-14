using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPerusteet
{
    public partial class Kuvagalleria : Form
    {
        public Kuvagalleria()
        {
            InitializeComponent();
        }

        private void Kuvagalleria_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox2.ImageLocation = @"P:\repositories\CSharp-harjoituksia\WindowsFormsPerusteet\WindowsFormsPerusteet\Resources\kuva3.jpg";
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    pictureBox1.Hide();
        //    pictureBox2.Show();
        //    pictureBox3.Hide();
        //    pictureBox4.Hide();
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Show();
            pictureBox4.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Show();
        }
    }
}
