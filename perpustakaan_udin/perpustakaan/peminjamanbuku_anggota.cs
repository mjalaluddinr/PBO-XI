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

            showIdBuku();

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "ID Buku";
            dataGridView1.Columns[1].Name = "Judul Buku";
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
            string judulBuku = label7.Text;

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
    }
}
