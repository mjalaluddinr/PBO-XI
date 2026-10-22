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

namespace perpustakaan
{
    public partial class riwayat_anggota : Form
    {
        public SqlConnection connection = new SqlConnection(koneksi.conn); // untuk koneksi
        public SqlCommand command; // untuk eksekusi perintah sql
        public SqlDataAdapter adapter; // ambil data dari sqlcommand
        public DataTable tabel; // untuk tabel menyimpan hasil query

        public void showData()
        {
            using (SqlConnection connection = new SqlConnection(koneksi.conn))
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT pd.peminjaman_detail_peminjaman_id, buku.buku_judul, p.peminjaman_tglpinjam, " +
                      "CASE WHEN p.peminjaman_statuskembali = 1 THEN 'DiKembalikan' ELSE 'DiPinjam' END AS status_kembali, p.peminjaman_note, p.peminjaman_denda " +
                      "FROM peminjaman_detail pd " +
                      "JOIN peminjaman p ON p.peminjaman_id = pd.peminjaman_detail_peminjaman_id " +
                      "JOIN buku ON buku.buku_id = pd.peminjaman_detail_buku_id " +
                      "WHERE p.peminjaman_user_id = @userid";

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@userid", Model.iduser);

                    adapter = new SqlDataAdapter(command);
                    tabel = new DataTable();
                    adapter.Fill(tabel);

                    dataGridView1.DataSource = tabel;
                    dataGridView1.Columns[0].HeaderText = "Id Peminjaman";
                    dataGridView1.Columns[1].HeaderText = "Judul Buku";
                    dataGridView1.Columns[2].HeaderText = "Tanggal Pinjam";
                    dataGridView1.Columns[3].HeaderText = "Status Kembali";
                    dataGridView1.Columns[4].HeaderText = "Note";
                    dataGridView1.Columns[5].HeaderText = "Denda";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at:" + ex);
                }
            }
        }

        public void searchData()
        {
            if (!string.IsNullOrEmpty(cari.Text))
            {
                try
                {
                    string sql = "SELECT pd.peminjaman_detail_peminjaman_id, buku.buku_judul, p.peminjaman_tglpinjam, " +
                      "p.peminjaman_statuskembali, p.peminjaman_note, p.peminjaman_denda " +
                      "FROM peminjaman_detail pd " +
                      "JOIN peminjaman p ON p.peminjaman_id = pd.peminjaman_detail_peminjaman_id " +
                      "JOIN buku ON buku.buku_id = pd.peminjaman_detail_buku_id " +
                      "WHERE (" +
                        "p.peminjaman_id LIKE '%' + @search + '%' OR " +
                        "buku.buku_judul LIKE '%' + @search + '%' OR " +
                        "p.peminjaman_tglpinjam LIKE '%' + @search + '%' OR " +
                        "(CASE WHEN p.peminjaman_statuskembali = 1 THEN 'DiKembalikan' ELSE 'DiPinjam' END) LIKE '%' + @search + '%' OR " +
                        "p.peminjaman_note LIKE '%' + @search + '%' OR " +
                        "p.peminjaman_denda LIKE '%' + @search + '%'" +
                      ") AND p.peminjaman_user_id = @userid";

                    command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@userid", Model.iduser);
                    command.Parameters.AddWithValue("@search", cari.Text);

                    adapter = new SqlDataAdapter(command);
                    tabel = new DataTable();
                    adapter.Fill(tabel);

                    dataGridView1.DataSource = tabel;
                    dataGridView1.Columns[0].HeaderText = "Id Peminjaman";
                    dataGridView1.Columns[1].HeaderText = "Judul Buku";
                    dataGridView1.Columns[2].HeaderText = "Tanggal Pinjam";
                    dataGridView1.Columns[3].HeaderText = "Status Kembali";
                    dataGridView1.Columns[4].HeaderText = "Note";
                    dataGridView1.Columns[5].HeaderText = "Denda";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at:" + ex);
                }
            }
            else
            {
                showData();
            }
        }

        public riwayat_anggota()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            this.Load -= riwayat_anggota_Load;
            this.Load += riwayat_anggota_Load;

            AturLayout();
            showData();
        }

        private void AturLayout()
        {
            this.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            panel1.Padding = new Padding(0);
            panel1.BackColor = Color.White;

            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;

            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label8.AutoSize = true;

            cari.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cari.Height = 23;
            cari.Font = new Font("Microsoft Sans Serif", 9F);
            cari.BorderStyle = BorderStyle.FixedSingle;

            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                                   AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
        }

        private void AturPosisiGrid(object sender, EventArgs e)
        {
            if (panel1 == null || dataGridView1 == null || cari == null ||
                label8 == null || label3 == null)
            {
                return;
            }

            label3.Location = new Point(
                (panel1.ClientSize.Width - label3.Width) / 2,
                15
            );

            label8.Location = new Point(22, 68);
            cari.Location = new Point(label8.Right + 8, 66);
            cari.Width = Math.Min(175, Math.Max(80, panel1.ClientSize.Width - cari.Left - 25));

            dataGridView1.SetBounds(25, cari.Bottom + 10,
                Math.Max(0, panel1.ClientSize.Width - 50),
                Math.Max(50, panel1.ClientSize.Height - cari.Bottom - 30));
        }

        private void riwayat_anggota_Load(object sender, EventArgs e)
        {
            AturLayout();
            panel1.Resize -= AturPosisiGrid;
            panel1.Resize += AturPosisiGrid;
            AturPosisiGrid(null, EventArgs.Empty);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }
    }
}
