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

namespace WindowsFormsApp7
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7D79UF6;Initial Catalog=\"mohndesen 2\";Integrated Security=True");
        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string sql = "select * from data_p where name_p=@name";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            SqlDataReader r;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    textBox10.Text = r["gender"].ToString();
                    textBox2.Text = r["age"].ToString();
                    textBox3.Text = r["job"].ToString();
                    textBox4.Text = r["adresss"].ToString();
                    textBox5.Text = r["phone"].ToString();
                    textBox6.Text = r["name_d"].ToString();
                    textBox7.Text = r["date_k"].ToString();
                    textBox8.Text = r["price"].ToString();
                    textBox9.Text = r["anty"].ToString();

                }
            }
            else
            {
                MessageBox.Show("invalid input !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 frm13 = new Form13();
            frm13.Show();
        }
    }
}
