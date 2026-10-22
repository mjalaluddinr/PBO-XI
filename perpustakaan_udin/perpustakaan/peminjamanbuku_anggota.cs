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
    public partial class peminjamanbuku_anggota : Form
    {
        public SqlConnection connection = new SqlConnection(koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        List<string> keranjangBuku = new List<string>();

        public void showIdBuku()
        {
            using (SqlConnection connection = new SqlConnection(koneksi.conn))
            {
                try
                {
                    connection.Open();  // Buka koneksi

                    string sql = "SELECT buku_id FROM buku";  // Query SQL untuk mengambil data
                    command = new SqlCommand(sql, connection);

                    reader = command.ExecuteReader();   // Eksekusi query dan ambil data

                    idbuku.Items.Clear();   // Bersihkan ComboBox sebelum mengisi data

                    while (reader.Read())   // Mengisi ComboBox dengan data dari database
                    {   // Mengambil data dari kolom "buku_id"
                        idbuku.Items.Add(reader["buku_id"].ToString());
                    }
                    reader.Close();  // Tutup reader
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at:" + ex);
                }
            }
        }
        public peminjamanbuku_anggota()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            this.Load -= peminjamanbuku_anggota_Load;
            this.Load += peminjamanbuku_anggota_Load;

            showIdBuku();

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "ID Buku";
            dataGridView1.Columns[1].Name = "Judul Buku";
        }

        private void AturLayout()
        {
            this.BackColor = Color.White;

            panel4.Anchor = AnchorStyles.Top |
                           AnchorStyles.Bottom |
                           AnchorStyles.Left |
                           AnchorStyles.Right;

            panel5.Anchor = AnchorStyles.Bottom |
                           AnchorStyles.Left |
                           AnchorStyles.Right;

            panel1.Dock = DockStyle.Fill;
            panel1.BackColor = Color.White;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if (panel1 == null || label3 == null ||
                panel5 == null || button1 == null)
            {
                return;
            }

            label3.Location = new Point(
                (panel1.ClientSize.Width - label3.Width) / 2,
                15
            );

            button1.Left = (panel5.ClientSize.Width - button1.Width) / 2;
        }

        private void peminjamanbuku_anggota_Load(object sender, EventArgs e)
        {
            AturLayout();

            panel1.Resize -= panel1_Resize;
            panel1.Resize += panel1_Resize;

            panel1_Resize(null, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void idbuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (idbuku.SelectedItem != null)
            {
                using (SqlConnection connection = new SqlConnection(koneksi.conn))
                {
                    try
                    {
                        connection.Open(); // Buka koneksi

                        // Query untuk mengambil data
                        string sql = "SELECT buku.buku_judul, penulis.penulis_nama, penerbit.penerbit_nama " +
                    "FROM buku " +
                    "JOIN penulis ON penulis.penulis_id = buku.buku_penulis_id " +
                    "JOIN penerbit ON penerbit.penerbit_id = buku.buku_penerbit_id " +
                    "WHERE buku_id = @bukuid";

                        command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@bukuid", idbuku.Text);

                        reader = command.ExecuteReader(); // Eksekusi query dan ambil data

                        if (reader.Read())  // Jika data ditemukan, tampilkan di label
                        {
                            label6.Text = reader["buku_judul"].ToString();
                            label7.Text = reader["penulis_nama"].ToString();
                            label8.Text = reader["penerbit_nama"].ToString();
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            if (idbuku.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih buku terlebih dahulu!");
                return;
            }

            string idBuku = idbuku.SelectedItem.ToString();
            string judulBuku = label6.Text;

            if (!keranjangBuku.Contains(idBuku))
            {
                keranjangBuku.Add(idBuku);
                dataGridView1.Rows.Add(idBuku, judulBuku);
            }
            else
            {
                MessageBox.Show("Buku sudah ada di keranjang!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idbuku.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih buku yang mau diedit!");
                return;
            }

            if (idbuku.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih buku baru untuk mengganti!");
                return;
            }

            string bukuBaru = idbuku.SelectedItem.ToString();
            int selectedIndex = dataGridView1.SelectedRows[0].Index;

            // Buku lama
            string bukuLama = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();

            // Jika buku baru sudah ada di keranjang → tolak
            if (keranjangBuku.Contains(bukuBaru) && bukuBaru != bukuLama)
            {
                MessageBox.Show("Buku sudah ada di keranjang!");
                return;
            }

            // Update ke list
            keranjangBuku[selectedIndex] = bukuBaru;

            // Update tampilan DataGridView
            dataGridView1.Rows[selectedIndex].Cells[0].Value = bukuBaru;

            MessageBox.Show("Buku berhasil diubah!");

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data yang mau dihapus!");
                return;
            }

            // Ambil ID buku dari baris yang dipilih
            string idBuku = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            // Hapus dari list & datagrid
            keranjangBuku.Remove(idBuku);
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (keranjangBuku.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong!");
                return;
            }

            using (SqlConnection connection = new SqlConnection(koneksi.conn))
            {
                connection.Open();  // Buka koneksi
                try
                {
                    // insert ke tabel peminjaman
                    string sqlPinjam = @"INSERT INTO peminjaman 
                (peminjaman_user_id, peminjaman_tglpinjam, peminjaman_tglkembali, peminjaman_statuskembali, peminjaman_note, peminjaman_denda)
                VALUES (@user, @tglpinjam, @tglkembali, @status, @note, @denda)";

                    command = new SqlCommand(sqlPinjam, connection);
                    command.Parameters.AddWithValue("@user", Model.iduser);
                    command.Parameters.AddWithValue("@tglpinjam", DateTime.Today);
                    command.Parameters.AddWithValue("@tglkembali", DateTime.Today.AddDays(7));
                    command.Parameters.AddWithValue("@status", 0); // 0 = Dipinjam, 1 = Dikembalikan
                    command.Parameters.AddWithValue("@note", "");
                    command.Parameters.AddWithValue("@denda", 0);
                    command.ExecuteNonQuery();

                    // ambil peminjaman_id terakhir (ID dari trigger)
                    string sqlGetId = "SELECT TOP 1 peminjaman_id FROM peminjaman ORDER BY TRY_CAST(SUBSTRING(peminjaman_id, 3, 15) AS INT) DESC";
                    string peminjamanId;
                    using (SqlCommand cmdGet = new SqlCommand(sqlGetId, connection))
                    {
                        peminjamanId = cmdGet.ExecuteScalar().ToString();
                    }

                    // insert detail (banyak buku)
                    string sqlDetail = @"INSERT INTO peminjaman_detail 
                (peminjaman_detail_peminjaman_id, peminjaman_detail_buku_id)
                VALUES (@pinjamid, @bukuid)";

                    foreach (string idBuku in keranjangBuku) // ambil dari lLst
                    {
                        command = new SqlCommand(sqlDetail, connection);
                        command.Parameters.AddWithValue("@pinjamid", peminjamanId);
                        command.Parameters.AddWithValue("@bukuid", idBuku);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Peminjaman berhasil disimpan!");

                    keranjangBuku.Clear();
                    dataGridView1.Rows.Clear();

                    // === REFRESH RIWAYAT SECARA OTOMATIS ===
                    var parent = this.Parent;
                    if (parent != null)
                    {
                        riwayat_anggota r = parent.Controls.OfType<riwayat_anggota>().FirstOrDefault();
                        if (r != null)
                        {
                            r.showData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
    }
}
