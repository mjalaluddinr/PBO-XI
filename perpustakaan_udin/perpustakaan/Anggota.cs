using System;
using System.Drawing;
using System.Windows.Forms;

namespace perpustakaan
{
    public partial class Anggota : Form
    {
        private Form halamanAktif;

        private Color warnaNormal = Color.FromArgb(243, 238, 250);
        private Color warnaAktif = Color.FromArgb(124, 90, 194);

        public Anggota()
        {
            InitializeComponent();

            label4.Text = Model.name;

            this.Resize += Anggota_Resize;

            panel2.Dock = DockStyle.None;
            panel2.Location = new Point(130, 105);

            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = warnaNormal;
            button5.FlatAppearance.MouseOverBackColor = warnaNormal;
            button5.BackColor = warnaNormal;
            button5.ForeColor = SystemColors.ControlText;

            AturLayout();
            SetButtonAktif(button1);
        }

        private void SetButtonAktif(Button tombolAktif)
        {
            Button[] tombolSidebar =
            {
                button1,
                button2,
                button3,
                button4
            };

            foreach (Button tombol in tombolSidebar)
            {
                tombol.BackColor = warnaNormal;
                tombol.ForeColor = SystemColors.ControlText;
                tombol.FlatStyle = FlatStyle.Flat;
                tombol.FlatAppearance.BorderSize = 0;
                tombol.FlatAppearance.MouseDownBackColor = warnaNormal;
                tombol.FlatAppearance.MouseOverBackColor = warnaNormal;
            }

            tombolAktif.BackColor = warnaAktif;
            tombolAktif.ForeColor = Color.White;
            tombolAktif.FlatStyle = FlatStyle.Flat;
            tombolAktif.FlatAppearance.BorderSize = 0;
            tombolAktif.FlatAppearance.MouseDownBackColor = warnaAktif;
            tombolAktif.FlatAppearance.MouseOverBackColor = warnaAktif;
        }

        private void TampilkanHalaman(Form halaman)
        {
            if (halamanAktif != null)
            {
                panel2.Controls.Remove(halamanAktif);
                halamanAktif.Dispose();
            }

            halamanAktif = halaman;
            halamanAktif.TopLevel = false;
            halamanAktif.FormBorderStyle = FormBorderStyle.None;
            halamanAktif.Dock = DockStyle.Fill;

            panel2.Controls.Clear();
            panel2.Controls.Add(halamanAktif);

            halamanAktif.Show();
            halamanAktif.BringToFront();
        }

        private void Anggota_Resize(object sender, EventArgs e)
        {
            AturLayout();
        }

        private void AturLayout()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                pHeader.Height = 87;

                pLogo.Location = new Point(20, 6);
                pLogo.Size = new Size(83, 77);

                label1.Font = new Font("Arial", 21.75F, FontStyle.Bold);
                label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, 22);

                panel1.Width = 220;
                panel1.Padding = new Padding(25, 23, 25, 23);

                lLine.Location = new Point(220, 87);
                lLine.Size = new Size(this.ClientSize.Width - 220, 48);

                label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
                label2.Location = new Point(230, 99);

                label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold);
                label4.Location = new Point(label2.Right + 8, 99);

                button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);

                button1.Margin = new Padding(13, 15, 13, 15);
                button2.Margin = new Padding(13, 15, 13, 15);
                button3.Margin = new Padding(13, 15, 13, 15);
                button4.Margin = new Padding(13, 15, 13, 15);
                button5.Margin = new Padding(13, 15, 13, 15);

                panel2.Location = new Point(220, 135);
                panel2.Size = new Size(this.ClientSize.Width - 220, this.ClientSize.Height - 135);
            }
            else
            {
                pHeader.Height = 65;

                pLogo.Location = new Point(10, 5);
                pLogo.Size = new Size(55, 55);

                label1.Font = new Font("Arial", 18F, FontStyle.Bold);
                label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, 18);

                panel1.Width = 130;
                panel1.Padding = new Padding(10);

                lLine.Location = new Point(130, 65);
                lLine.Size = new Size(this.ClientSize.Width - 130, 40);

                label2.Font = new Font("Calibri", 10F, FontStyle.Bold);
                label2.Location = new Point(140, 75);

                label4.Font = new Font("Calibri", 10F, FontStyle.Bold);
                label4.Location = new Point(label2.Right + 5, 75);

                button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);

                button1.Margin = new Padding(5, 6, 5, 6);
                button2.Margin = new Padding(5, 6, 5, 6);
                button3.Margin = new Padding(5, 6, 5, 6);
                button4.Margin = new Padding(5, 6, 5, 6);
                button5.Margin = new Padding(5, 6, 5, 6);

                panel2.Location = new Point(130, 105);
                panel2.Size = new Size(this.ClientSize.Width - 130, this.ClientSize.Height - 105);
            }

            panel2.BringToFront();
            pHeader.BringToFront();
            panel1.BringToFront();
            lLine.BringToFront();
            label2.BringToFront();
            label4.BringToFront();
        }

        private void Anggota_Load(object sender, EventArgs e)
        {
            label4.Text = Model.name;
            AturLayout();
            SetButtonAktif(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (halamanAktif != null)
            {
                panel2.Controls.Remove(halamanAktif);
                halamanAktif.Dispose();
                halamanAktif = null;
            }

            panel2.Controls.Clear();
            SetButtonAktif(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetButtonAktif(button2);
            TampilkanHalaman(new caribuku_anggota());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetButtonAktif(button3);
            TampilkanHalaman(new peminjamanbuku_anggota());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetButtonAktif(button4);
            TampilkanHalaman(new riwayat_anggota());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login panggil = new Login();
            panggil.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}