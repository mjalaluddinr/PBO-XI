using System;
using System.Drawing;
using System.Windows.Forms;

namespace perpustakaan
{
    public partial class buku_admin : Form
    {
        public buku_admin()
        {
            InitializeComponent();

            label4.Text = Model.name;

            this.Resize += buku_admin_Resize;

            AturLayout();
        }

        private void buku_admin_Resize(object sender, EventArgs e)
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

                label1.Font = new Font(
                    "Arial",
                    21.75F,
                    FontStyle.Bold
                );

                label1.Location = new Point(
                    (this.ClientSize.Width - label1.Width) / 2,
                    22
                );

                panel1.Width = 220;
                panel1.Padding = new Padding(
                    25,
                    23,
                    25,
                    23
                );

                lLine.Location = new Point(220, 87);
                lLine.Size = new Size(
                    this.ClientSize.Width - 220,
                    48
                );

                label2.Font = new Font(
                    "Calibri",
                    14.25F,
                    FontStyle.Bold
                );

                label2.Location = new Point(230, 99);

                label4.Font = new Font(
                    "Calibri",
                    14.25F,
                    FontStyle.Bold
                );

                label4.Location = new Point(
                    label2.Right + 8,
                    99
                );

                button1.Font = new Font(
                    "Microsoft Sans Serif",
                    12F,
                    FontStyle.Bold
                );

                button2.Font = new Font(
                    "Microsoft Sans Serif",
                    12F,
                    FontStyle.Bold
                );

                button3.Font = new Font(
                    "Microsoft Sans Serif",
                    12F,
                    FontStyle.Bold
                );

                button4.Font = new Font(
                    "Microsoft Sans Serif",
                    12F,
                    FontStyle.Bold
                );

                button5.Font = new Font(
                    "Microsoft Sans Serif",
                    12F,
                    FontStyle.Bold
                );

                button6.Font = new Font(
                    "Microsoft Sans Serif",
                    12F,
                    FontStyle.Bold
                );

                button7.Font = new Font(
                    "Microsoft Sans Serif",
                    12F,
                    FontStyle.Bold
                );

                button8.Font = new Font(
                    "Microsoft Sans Serif",
                    12F,
                    FontStyle.Bold
                );

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

                label1.Font = new Font(
                    "Arial",
                    18F,
                    FontStyle.Bold
                );

                label1.Location = new Point(
                    (this.ClientSize.Width - label1.Width) / 2,
                    18
                );

                panel1.Width = 130;
                panel1.Padding = new Padding(10);

                lLine.Location = new Point(130, 65);
                lLine.Size = new Size(
                    this.ClientSize.Width - 130,
                    40
                );

                label2.Font = new Font(
                    "Calibri",
                    10F,
                    FontStyle.Bold
                );

                label2.Location = new Point(140, 76);

                label4.Font = new Font(
                    "Calibri",
                    10F,
                    FontStyle.Bold
                );

                label4.Location = new Point(
                    label2.Right + 5,
                    76
                );

                button1.Font = new Font(
                    "Microsoft Sans Serif",
                    9F,
                    FontStyle.Bold
                );

                button2.Font = new Font(
                    "Microsoft Sans Serif",
                    9F,
                    FontStyle.Bold
                );

                button3.Font = new Font(
                    "Microsoft Sans Serif",
                    9F,
                    FontStyle.Bold
                );

                button4.Font = new Font(
                    "Microsoft Sans Serif",
                    9F,
                    FontStyle.Bold
                );

                button5.Font = new Font(
                    "Microsoft Sans Serif",
                    9F,
                    FontStyle.Bold
                );

                button6.Font = new Font(
                    "Microsoft Sans Serif",
                    9F,
                    FontStyle.Bold
                );

                button7.Font = new Font(
                    "Microsoft Sans Serif",
                    9F,
                    FontStyle.Bold
                );

                button8.Font = new Font(
                    "Microsoft Sans Serif",
                    9F,
                    FontStyle.Bold
                );

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

        private void buku_admin_Load(object sender, EventArgs e)
        {
            label4.Text = Model.name;
            AturLayout();
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
            this.Close();
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
    }
}