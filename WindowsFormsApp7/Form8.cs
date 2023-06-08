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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7D79UF6;Initial Catalog=\"mohndesen 2\";Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked == true) { gender = "male"; } else { gender = "female"; }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into data_p values('" + textBox1.Text + "' ,'" + gender + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            MessageBox.Show("تم الحجز بنجاح");
            //try
            //{
            //    string price = textBox8.Text, phone = textBox5.Text, name = textBox1.Text, gender = "", job = textBox3.Text, addresss = textBox4.Text, name_d = textBox6.Text, date_k = textBox7.Text, anyt = textBox9.Text, age = textBox2.Text;
            //    if (radioButton1.Checked == true) { gender = "male"; } else { gender = "female"; }
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand("INSERT INTO data_p(name_p,gender,age,job,adresss,phone,name_d,date_k,price,anty)values('" + textBox1.Text + "' ,'" + gender + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("تم الحجز بنجاح جاري طبع الفاتوره");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.OpenForms[2].Show();
            this.Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("update data_p set age='" + textBox2.Text + "',job='" + textBox3.Text + "',adresss='" + textBox4.Text + "',phone='" + textBox5.Text + "',name_d='" + textBox6.Text + "',date_k='" + textBox7.Text + "',price='" + textBox8.Text + "',anty='" + textBox9.Text + "' WHERE name_p='" + textBox1.Text + "'", con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            MessageBox.Show("تم التعديل بنجاح");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked == true) { gender = "male"; } else { gender = "female"; }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from data_p where name_p='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            MessageBox.Show("تم الحذف بنجاح");
        }
    }
}
