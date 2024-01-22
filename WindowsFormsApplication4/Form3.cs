using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1AS6E4S\\SQLEXPRESS;Initial Catalog=MPL;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into Table_1 values ('" + int.Parse(textBox1.Text) + "','" + (textBox2.Text) + "','" + int.Parse(textBox3.Text) + "')", con);
            command.ExecuteNonQuery();
            MessageBox.Show("Successfully Added !");
            con.Close();
            blindData();
        }
        void blindData()
        {
            SqlCommand command = new SqlCommand("select * from Table_1", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }
    }
}
