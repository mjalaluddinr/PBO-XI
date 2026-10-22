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
                      "p.peminjaman_statuskembali, p.peminjaman_note, p.peminjaman_denda " +
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
                        "p.peminjaman_statuskembali LIKE '%' + @search + '%' OR " +
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
            showData();
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
