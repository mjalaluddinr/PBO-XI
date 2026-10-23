using System;
using System.Drawing;
using System.Windows.Forms;

namespace perpustakaan
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();

            label4.Text = Model.name;

            this.Resize += Admin_Resize;

            AturLayout();
            TerapkanTema();
        }

        private void Admin_Resize(object sender, EventArgs e)
        {
            AturLayout();
            TerapkanTema();
        }

        private void TerapkanTema()
        {
            TemaWarna.Terapkan(this);
            pHeader.BackColor = TemaWarna.Plum;
            lLine.BackColor = TemaWarna.MawarTua;
            label2.BackColor = TemaWarna.MawarTua;
            label2.ForeColor = Color.White;
            label4.BackColor = TemaWarna.MawarTua;
            label4.ForeColor = Color.White;
            panel1.BackColor = TemaWarna.Lavender;
            label2.Text = "Selamat Datang Admin,";
            label4.Text = Model.name;
            label2.AutoSize = true;
            label4.AutoSize = true;
            label4.AutoEllipsis = false;
            label4.MaximumSize = Size.Empty;
            label2.Location = new Point(this.WindowState == FormWindowState.Maximized ? 230 : 140,
                this.WindowState == FormWindowState.Maximized ? 99 : 76);
            label4.Location = new Point(label2.Right + 6, label2.Top);
            AturGayaSidebar();
            TerapkanKeTombolKonten(this);
        }

        private void TerapkanKeTombolKonten(Control induk)
        {
            foreach (Control kontrol in induk.Controls)
            {
                if (kontrol is Button tombol && tombol.Parent != tableLayoutPanel1)
                {
                    tombol.BackColor = TemaWarna.Latar;
                    tombol.ForeColor = TemaWarna.UnguTua;
                    tombol.FlatStyle = FlatStyle.Flat;
                    tombol.UseVisualStyleBackColor = false;
                    tombol.FlatAppearance.BorderSize = 1;
                    tombol.FlatAppearance.BorderColor = TemaWarna.Mawar;
                    tombol.FlatAppearance.MouseOverBackColor = TemaWarna.MawarTua;
                    tombol.FlatAppearance.MouseDownBackColor = TemaWarna.UnguTua;
                }

                if (kontrol.HasChildren) TerapkanKeTombolKonten(kontrol);
            }
        }

        private void AturGayaSidebar()
        {
            Button[] tombolSidebar =
            {
                button1, button2, button5, button6,
                button3, button4, button7, button8
            };

            foreach (Button tombol in tombolSidebar)
            {
                tombol.BackColor = TemaWarna.Lavender;
                tombol.ForeColor = TemaWarna.UnguTua;
                tombol.FlatStyle = FlatStyle.Flat;
                tombol.UseVisualStyleBackColor = false;
                tombol.FlatAppearance.BorderSize = 1;
                tombol.FlatAppearance.BorderColor = TemaWarna.Mawar;
                tombol.FlatAppearance.MouseOverBackColor = TemaWarna.MawarTua;
                tombol.FlatAppearance.MouseDownBackColor = TemaWarna.MawarTua;
            }

            Button tombolAktif = button1;
            tombolAktif.BackColor = TemaWarna.Plum;
            tombolAktif.ForeColor = Color.White;
            tombolAktif.FlatAppearance.BorderSize = 0;
            tombolAktif.FlatAppearance.MouseOverBackColor = TemaWarna.UnguTua;
            tombolAktif.FlatAppearance.MouseDownBackColor = TemaWarna.UnguTua;
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
                button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                button7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                button8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);

                button1.Margin = new Padding(13, 15, 13, 15);
                button2.Margin = new Padding(13, 15, 13, 15);
                button3.Margin = new Padding(13, 15, 13, 15);
                button4.Margin = new Padding(13, 15, 13, 15);
                button5.Margin = new Padding(13, 15, 13, 15);
                button6.Margin = new Padding(13, 15, 13, 15);
                button7.Margin = new Padding(13, 15, 13, 15);
                button8.Margin = new Padding(13, 15, 13, 15);
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
                label2.Location = new Point(140, 76);

                label4.Font = new Font("Calibri", 10F, FontStyle.Bold);
                label4.Location = new Point(label2.Right + 5, 76);

                button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                button6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                button7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                button8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);

                button1.Margin = new Padding(5, 6, 5, 6);
                button2.Margin = new Padding(5, 6, 5, 6);
                button3.Margin = new Padding(5, 6, 5, 6);
                button4.Margin = new Padding(5, 6, 5, 6);
                button5.Margin = new Padding(5, 6, 5, 6);
                button6.Margin = new Padding(5, 6, 5, 6);
                button7.Margin = new Padding(5, 6, 5, 6);
                button8.Margin = new Padding(5, 6, 5, 6);
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            label4.Text = Model.name;
            AturLayout();
            TerapkanTema();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin panggil = new Admin();
            panggil.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            penulis_admin panggil = new penulis_admin();
            panggil.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            penerbit_admin panggil = new penerbit_admin();
            panggil.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            kategori_admin panggil = new kategori_admin();
            panggil.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            rak_admin panggil = new rak_admin();
            panggil.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            buku_admin panggil = new buku_admin();
            panggil.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            peminjaman_admin panggil = new peminjaman_admin();
            panggil.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Login panggil = new Login ();
            panggil .Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lLine_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
