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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7D79UF6;Initial Catalog=\"mohndesen 2\";Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 frm13 = new Form13();
            frm13.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from ta7lel where name_t=@name";
            SqlCommand cmd = new SqlCommand(sql , con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            SqlDataReader r;
            con.Open();
            r= cmd.ExecuteReader();
            if(r.HasRows)
            {
                while(r.Read())
                {
                    textBox2.Text = r["type_t"].ToString();

                }
            }
            else
            {
                MessageBox.Show("invalid input !");
            }
        }
    }
}
