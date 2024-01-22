using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f2 = new Form6();
            f2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
