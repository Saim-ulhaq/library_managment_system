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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;



                if (a != "admin")

                if (b != "1122")
                {
                    MessageBox.Show("Invalid Login");
                    textBox1.Clear();
                    textBox2.Clear();
                }

                if (a == "admin")

                if (b == "1122")
                {
                    MessageBox.Show("Login Successful");
                    Form2 f2 = new Form2();
                    f2.Show();
                }
               
        }
    }
}
