
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace perpustakaan
{
    public partial class caribuku_anggota : Form
    {
        public SqlConnection connection = new SqlConnection(koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;

        public caribuku_anggota()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            this.Load -= caribuku_anggota_Load;
            this.Load += caribuku_anggota_Load;
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
            label8.Location = new Point(22, 68);

            cari.Anchor = AnchorStyles.Top |
                          AnchorStyles.Left |
                          AnchorStyles.Right;

            cari.Location = new Point(label8.Right + 8, 66);
            cari.Height = 23;
            cari.Width = Math.Min(
                175,
                Math.Max(80, panel1.ClientSize.Width - cari.Left - 25)
            );

            cari.Font = new Font("Microsoft Sans Serif", 9F);
            cari.BorderStyle = BorderStyle.FixedSingle;

            dataGridView1.Anchor = AnchorStyles.Top |
                                   AnchorStyles.Bottom |
                                   AnchorStyles.Left |
                                   AnchorStyles.Right;

            dataGridView1.Left = 25;
            dataGridView1.Top = cari.Bottom + 10;
            dataGridView1.Width = Math.Max(
                0,
                panel1.ClientSize.Width - 50
            );

            dataGridView1.Height = Math.Max(
                50,
                panel1.ClientSize.Height - dataGridView1.Top - 20
            );

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.ColumnHeadersHeight = 35;

            dataGridView1.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridView1.DefaultCellStyle.Font =
                new Font("Microsoft Sans Serif", 9F);

            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Microsoft Sans Serif",
                    9F,
                    FontStyle.Bold
                );

            dataGridView1.ScrollBars = ScrollBars.Both;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
        }

        private void AturPosisiGrid(object sender, EventArgs e)
        {
            if (panel1 == null ||
                dataGridView1 == null ||
                cari == null ||
                label8 == null ||
                label3 == null)
            {
                return;
            }

            label3.Location = new Point(
                (panel1.ClientSize.Width - label3.Width) / 2,
                15
            );

            label8.Location = new Point(22, 68);

            cari.Location = new Point(label8.Right + 8, 66);

            cari.Width = Math.Min(
                175,
                Math.Max(80, panel1.ClientSize.Width - cari.Left - 25)
            );

            dataGridView1.Left = 25;
            dataGridView1.Top = cari.Bottom + 10;

            dataGridView1.Width = Math.Max(
                0,
                panel1.ClientSize.Width - 50
            );

            dataGridView1.Height = Math.Max(
                50,
                panel1.ClientSize.Height - dataGridView1.Top - 20
            );
        }

        public void showData()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(koneksi.conn))
                {
                    conn.Open();

                    string sql =
                        "SELECT buku.buku_id, buku.buku_judul, " +
                        "buku.buku_isbn, buku.buku_thnterbit, " +
                        "penulis.penulis_nama, rak.rak_nama, " +
                        "kategori.kategori_nama, penerbit.penerbit_nama " +
                        "FROM buku " +
                        "JOIN penulis ON penulis.penulis_id = buku.buku_penulis_id " +
                        "JOIN rak ON rak.rak_id = buku.buku_rak_id " +
                        "JOIN kategori ON kategori.kategori_id = buku.buku_kategori_id " +
                        "JOIN penerbit ON penerbit.penerbit_id = buku.buku_penerbit_id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        adapter = new SqlDataAdapter(cmd);
                        tabel = new DataTable();

                        adapter.Fill(tabel);
                        dataGridView1.DataSource = tabel;
                    }
                }

                AturKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal menampilkan data buku: " + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void searchData()
        {
            string keyword = cari.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                showData();
                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(koneksi.conn))
                {
                    conn.Open();

                    string sql =
                        "SELECT buku.buku_id, buku.buku_judul, " +
                        "buku.buku_isbn, buku.buku_thnterbit, " +
                        "penulis.penulis_nama, rak.rak_nama, " +
                        "kategori.kategori_nama, penerbit.penerbit_nama " +
                        "FROM buku " +
                        "JOIN penulis ON penulis.penulis_id = buku.buku_penulis_id " +
                        "JOIN rak ON rak.rak_id = buku.buku_rak_id " +
                        "JOIN kategori ON kategori.kategori_id = buku.buku_kategori_id " +
                        "JOIN penerbit ON penerbit.penerbit_id = buku.buku_penerbit_id " +
                        "WHERE CAST(buku.buku_id AS VARCHAR(50)) LIKE @search " +
                        "OR buku.buku_judul LIKE @search " +
                        "OR buku.buku_isbn LIKE @search " +
                        "OR CAST(buku.buku_thnterbit AS VARCHAR(50)) LIKE @search " +
                        "OR penulis.penulis_nama LIKE @search " +
                        "OR rak.rak_nama LIKE @search " +
                        "OR kategori.kategori_nama LIKE @search " +
                        "OR penerbit.penerbit_nama LIKE @search";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add(
                            "@search",
                            SqlDbType.VarChar,
                            255
                        ).Value = "%" + keyword + "%";

                        adapter = new SqlDataAdapter(cmd);
                        tabel = new DataTable();

                        adapter.Fill(tabel);
                        dataGridView1.DataSource = tabel;
                    }
                }

                AturKolom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal mencari buku: " + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AturKolom()
        {
            if (dataGridView1.Columns.Count >= 8)
            {
                dataGridView1.Columns[0].HeaderText = "ID Buku";
                dataGridView1.Columns[1].HeaderText = "Judul Buku";
                dataGridView1.Columns[2].HeaderText = "ISBN";
                dataGridView1.Columns[3].HeaderText = "Tahun Terbit";
                dataGridView1.Columns[4].HeaderText = "Penulis";
                dataGridView1.Columns[5].HeaderText = "Rak";
                dataGridView1.Columns[6].HeaderText = "Kategori";
                dataGridView1.Columns[7].HeaderText = "Penerbit";

                dataGridView1.Columns[0].FillWeight = 55;
                dataGridView1.Columns[1].FillWeight = 150;
                dataGridView1.Columns[2].FillWeight = 100;
                dataGridView1.Columns[3].FillWeight = 75;
                dataGridView1.Columns[4].FillWeight = 110;
                dataGridView1.Columns[5].FillWeight = 80;
                dataGridView1.Columns[6].FillWeight = 100;
                dataGridView1.Columns[7].FillWeight = 100;
            }
        }

        private void caribuku_anggota_Load(object sender, EventArgs e)
        {
            AturLayout();

            panel1.Resize -= AturPosisiGrid;
            panel1.Resize += AturPosisiGrid;

            AturPosisiGrid(null, EventArgs.Empty);

            showData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
