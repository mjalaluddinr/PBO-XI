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
            this.BackColor = Color.FromArgb(248, 246, 253);
            panel1.Dock = DockStyle.Fill;
            panel1.Padding = new Padding(0);
            panel1.BackColor = Color.FromArgb(248, 246, 253);

            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panel5.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            panel2.BackColor = Color.FromArgb(243, 238, 250);
            panel3.BackColor = Color.FromArgb(243, 238, 250);
            panel4.BackColor = Color.FromArgb(243, 238, 250);
            panel5.BackColor = Color.FromArgb(243, 238, 250);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel5.BorderStyle = BorderStyle.FixedSingle;

            label3.ForeColor = Color.FromArgb(54, 42, 78);
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label10.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 34;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.BackgroundColor = Color.FromArgb(250, 249, 253);
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.GridColor = Color.FromArgb(221, 213, 239);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(48, 42, 61);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(124, 90, 194);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Padding = new Padding(6, 3, 6, 3);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 244, 252);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            StyleTombol(bInsert, "INSERT");
            StyleTombol(bEdit, "EDIT");
            StyleTombol(bDelete, "DELETE");
            button1.BackColor = Color.FromArgb(124, 90, 194);
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        }

        private void StyleTombol(Button tombol, string teks)
        {
            tombol.Text = teks;
            tombol.BackColor = Color.White;
            tombol.ForeColor = Color.FromArgb(82, 57, 139);
            tombol.FlatStyle = FlatStyle.Flat;
            tombol.FlatAppearance.BorderColor = Color.FromArgb(190, 177, 218);
            tombol.FlatAppearance.MouseOverBackColor = Color.FromArgb(233, 223, 255);
            tombol.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if (panel1 == null || label3 == null || panel2 == null ||
                panel3 == null || panel4 == null || panel5 == null || button1 == null)
            {
                return;
            }

            int width = panel1.ClientSize.Width;
            int height = panel1.ClientSize.Height;
            if (width <= 0 || height <= 0) return;

            int margin = Math.Max(18, Math.Min(34, width / 45));
            int gap = Math.Max(14, Math.Min(24, width / 70));
            int bodyWidth = Math.Max(0, width - margin * 2);
            int leftWidth = Math.Max(203, Math.Min(460, (bodyWidth - gap) * 38 / 100));
            leftWidth = Math.Min(leftWidth, Math.Max(203, bodyWidth - gap - 220));
            int rightLeft = margin + leftWidth + gap;
            int rightWidth = Math.Max(0, width - rightLeft - margin);

            int headerTop = Math.Max(20, height / 45);
            int contentTop = headerTop + 50;
            int footerHeight = 78;
            int footerBottom = height - Math.Max(18, height / 45);
            int footerTop = footerBottom - footerHeight;
            int contentHeight = Math.Max(260, footerTop - contentTop - 18);
            int detailsHeight = Math.Min(210, Math.Max(175, contentHeight * 42 / 100));
            int actionsTop = contentTop + detailsHeight + 14;
            int actionsHeight = Math.Min(104, Math.Max(82, contentHeight - detailsHeight - 14));

            label3.Location = new Point((width - label3.Width) / 2, headerTop);

            panel2.SetBounds(margin, contentTop, leftWidth, detailsHeight);
            panel3.SetBounds(margin, actionsTop, leftWidth, actionsHeight);
            panel4.SetBounds(rightLeft, contentTop, rightWidth, contentHeight);
            panel5.SetBounds(margin, footerTop, bodyWidth, footerHeight);

            label1.Location = new Point(16, 17);
            label2.Location = new Point(16, 57);
            label4.Location = new Point(16, 97);
            label5.Location = new Point(16, 137);
            idbuku.SetBounds(105, 14, Math.Max(80, leftWidth - 121), 27);

            int valueLeft = 105;
            int valueWidth = Math.Max(50, leftWidth - valueLeft - 14);
            label6.SetBounds(valueLeft, 57, valueWidth, 24);
            label7.SetBounds(valueLeft, 97, valueWidth, 24);
            label8.SetBounds(valueLeft, 137, valueWidth, 24);
            label6.AutoSize = label7.AutoSize = label8.AutoSize = false;
            label6.AutoEllipsis = label7.AutoEllipsis = label8.AutoEllipsis = true;

            label10.Location = new Point(12, 9);
            int buttonGap = 10;
            int innerWidth = Math.Max(0, panel3.ClientSize.Width - 24);
            int buttonWidth = Math.Max(56, (innerWidth - buttonGap * 2) / 3);
            int buttonsWidth = buttonWidth * 3 + buttonGap * 2;
            int buttonLeft = Math.Max(12, (panel3.ClientSize.Width - buttonsWidth) / 2);
            int buttonHeight = 38;
            int buttonTop = Math.Max(34, (panel3.ClientSize.Height - buttonHeight) / 2 + 7);
            bInsert.SetBounds(buttonLeft, buttonTop, buttonWidth, buttonHeight);
            bEdit.SetBounds(buttonLeft + buttonWidth + buttonGap, buttonTop, buttonWidth, buttonHeight);
            bDelete.SetBounds(buttonLeft + (buttonWidth + buttonGap) * 2, buttonTop, buttonWidth, buttonHeight);

            label9.Location = new Point(16, 12);
            int gridLeft = 18;
            int gridTop = 43;
            int gridWidth = Math.Max(100, panel4.ClientSize.Width - gridLeft * 2);
            int gridHeight = Math.Max(100, panel4.ClientSize.Height - gridTop - 18);
            dataGridView1.SetBounds(gridLeft, gridTop, gridWidth, gridHeight);
            dataGridView1.Columns[0].FillWeight = 28;
            dataGridView1.Columns[1].FillWeight = 72;

            button1.Size = new Size(Math.Min(300, panel5.ClientSize.Width - 40), 44);
            button1.Location = new Point(
                (panel5.ClientSize.Width - button1.Width) / 2,
                (panel5.ClientSize.Height - button1.Height) / 2);
        }

        private void peminjamanbuku_anggota_Load(object sender, EventArgs e)
        {
            AturLayout();

            panel1.Resize -= panel1_Resize;
            panel1.Resize += panel1_Resize;

            AturLayout();
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
