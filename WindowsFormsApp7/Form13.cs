using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 frm14 = new Form14();
            frm14.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form15 frm15 = new Form15();
            frm15.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form15 frm15 = new Form15();
            frm15.Show();
        }
    }
}
