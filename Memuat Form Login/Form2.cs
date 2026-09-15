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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3a_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGHasil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bSimpan_Click(object sender, EventArgs e)
        {
            string Nama = tNama.Text;
            string JK = "";
            string TempatLahir = tTmptLahir.Text;
            string TglLahir = dTglLahir.Text;
            string Alamat = rtAlamat.Text;
            string Agama = cAgama.Text;
            string Hobi = "";

            //RadioButton Untuk Jenis Kelamin
            if (rLaki.Checked == true)
            {
                JK = "Laki-laki";
            }
            else if (rPerempuan.Checked == true)
            {
                JK = "Perempuan";
            }


            //CheckBox Untuk Hobi 
            List<string> daftarHobi = new List<string>();

            if (cbMembaca.Checked == true)
            {
                daftarHobi.Add("Membaca");
            }

            if (cbMemasak.Checked == true)
            {
                daftarHobi.Add("Memasak");
            }

            if (cbMainGame.Checked == true)
            {
                daftarHobi.Add("Main Game");
            }

            if (cbMenyanyi.Checked == true)
            {
                daftarHobi.Add("Menyanyi");
            }

            Hobi = string.Join(", ", daftarHobi);
            dGHasil.Rows.Add(Nama, JK, TempatLahir, TglLahir, Alamat, Agama, Hobi);
        }

        private void bHapus_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGHasil.SelectedRows)
            {
                dGHasil.Rows.RemoveAt(row.Index);
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
