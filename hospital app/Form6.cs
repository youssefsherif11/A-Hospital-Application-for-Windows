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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace WindowsFormsApp7
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7D79UF6;Initial Catalog=\"mohndesen 2\";Integrated Security=True");
        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text, gender = "", age = textBox2.Text,  job = textBox3.Text, addresss = textBox4.Text, phone = textBox5.Text, type_t = comboBox2.Text, date_t= textBox7.Text, price = textBox8.Text,anty=textBox9.Text;
                if (radioButton1.Checked == true) { gender = "male"; } else { gender = "female"; }
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ta7lel(name_t,gender,age,job,adresss,phone,type_t,date_t,price,anty)values('" + textBox1.Text + "' ,'" + gender + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox2.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم الحجز بنجاح جاري طبع الفاتوره");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            MessageBox.Show("تم الحجز بنجاح");
        }
    }
}
