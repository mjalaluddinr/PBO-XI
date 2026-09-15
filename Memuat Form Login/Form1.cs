using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memuat_Form_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (tUsername.Text == "admin" && tPassword.Text == "12345")
            {
                Form2 Biodata = new Form2();
                Biodata.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username Dan Password Salah");
            }
        }
    }
}
