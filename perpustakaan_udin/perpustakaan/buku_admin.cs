using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace perpustakaan
{
    public partial class buku_admin : Form
    {
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable tabel;
        SqlDataReader reader;
        public string id_buku = "";
        private readonly ErrorProvider errorProvider = new ErrorProvider();

        public buku_admin()
        {
            InitializeComponent();

            label4.Text = Model.name;

            dataGridView1.CellClick -= dataGridView1_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;

            dataGridView1.CellContentClick -= dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            this.Resize += buku_admin_Resize;

            AturLayout();
            TerapkanTema();
        }

        public void showNamaPenulis()
        {
            using (SqlConnection connection = new SqlConnection(koneksi.conn))
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT penulis_nama FROM penulis";

                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();

                    cPenulis.Items.Clear();

                    while (reader.Read())
                    {
                        cPenulis.Items.Add(reader["penulis_nama"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at: " + ex.Message);
                }
            }
        }

        public void showNamaKategori()
        {
            using (SqlConnection connection = new SqlConnection(koneksi.conn))
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT kategori_nama FROM kategori";

                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();

                    cKategori.Items.Clear();

                    while (reader.Read())
                    {
                        cKategori.Items.Add(reader["kategori_nama"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at: " + ex.Message);
                }
            }
        }

        public void showNamaPenerbit()
        {
            using (SqlConnection connection = new SqlConnection(koneksi.conn))
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT penerbit_nama FROM penerbit";

                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();

                    cPenerbit.Items.Clear();

                    while (reader.Read())
                    {
                        cPenerbit.Items.Add(reader["penerbit_nama"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at: " + ex.Message);
                }
            }
        }

        public void showNamaRak()
        {
            using (SqlConnection connection = new SqlConnection(koneksi.conn))
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT rak_nama FROM rak";

                    command = new SqlCommand(sql, connection);
                    reader = command.ExecuteReader();

                    cRak.Items.Clear();

                    while (reader.Read())
                    {
                        cRak.Items.Add(reader["rak_nama"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at: " + ex.Message);
                }
            }
        }

        private readonly string sqlSelectBuku =
            @"SELECT b.buku_id, b.buku_judul, b.buku_isbn, b.buku_thnterbit,
                     p.penulis_nama, k.kategori_nama, pb.penerbit_nama, r.rak_nama
              FROM buku b
              JOIN penulis p ON b.buku_penulis_id = p.penulis_id
              JOIN kategori k ON b.buku_kategori_id = k.kategori_id
              JOIN penerbit pb ON b.buku_penerbit_id = pb.penerbit_id
              JOIN rak r ON b.buku_rak_id = r.rak_id";

        public void showData()
        {
            using (SqlConnection connection = new SqlConnection(koneksi.conn))
            {
                try
                {
                    connection.Open();

                    command = new SqlCommand(sqlSelectBuku, connection);
                    adapter = new SqlDataAdapter(command);

                    tabel = new DataTable();
                    adapter.Fill(tabel);

                    dataGridView1.DataSource = tabel;

                    AturGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at: " + ex.Message);
                }
            }
        }

        private void AturGrid()
        {
            if (dataGridView1.Columns.Count == 0)
                return;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Judul";
            dataGridView1.Columns[2].HeaderText = "ISBN";
            dataGridView1.Columns[3].HeaderText = "Tahun Terbit";
            dataGridView1.Columns[4].HeaderText = "Penulis";
            dataGridView1.Columns[5].HeaderText = "Kategori";
            dataGridView1.Columns[6].HeaderText = "Penerbit";
            dataGridView1.Columns[7].HeaderText = "Rak";
        }

        public void clear()
        {
            tJudul.Text = "";
            tIsbn.Text = "";
            tThnterbit.Value = DateTime.Now.Year;

            cPenulis.SelectedIndex = -1;
            cKategori.SelectedIndex = -1;
            cPenerbit.SelectedIndex = -1;
            cRak.SelectedIndex = -1;

            id_buku = "";

            dataGridView1.ClearSelection();
        }

        // ASVS 2.2.1: ISBN divalidasi sebelum data buku disimpan atau diperbarui.
        private bool inputValid()
        {
            if (string.IsNullOrWhiteSpace(tJudul.Text) ||
                string.IsNullOrWhiteSpace(tIsbn.Text) ||
                cPenulis.SelectedIndex == -1 ||
                cKategori.SelectedIndex == -1 ||
                cPenerbit.SelectedIndex == -1 ||
                cRak.SelectedIndex == -1)
            {
                TemaPopup.Tampilkan(this, "Lengkapi semua data buku sebelum menyimpan.", "Data belum lengkap", MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tIsbn.Text) ||
                !tIsbn.Text.All(char.IsDigit))
            {
                TemaPopup.Tampilkan(this, "ISBN hanya boleh berisi angka.", "ISBN tidak valid", MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void isiParameter(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@penulis", cPenulis.Text);
            cmd.Parameters.AddWithValue("@kategori", cKategori.Text);
            cmd.Parameters.AddWithValue("@penerbit", cPenerbit.Text);
            cmd.Parameters.AddWithValue("@rak", cRak.Text);
            cmd.Parameters.AddWithValue("@judul", tJudul.Text);
            cmd.Parameters.AddWithValue("@isbn", tIsbn.Text);
            cmd.Parameters.Add("@tahun", SqlDbType.Int).Value = Decimal.ToInt32(tThnterbit.Value);
        }

        public void insertData()
        {
            if (!inputValid())
                return;

            try
            {
                using (SqlConnection connection = new SqlConnection(koneksi.conn))
                {
                    string sql =
                        @"INSERT INTO buku
                        (
                            buku_penulis_id,
                            buku_kategori_id,
                            buku_penerbit_id,
                            buku_rak_id,
                            buku_judul,
                            buku_isbn,
                            buku_thnterbit
                        )
                        VALUES
                        (
                            (SELECT penulis_id FROM penulis WHERE penulis_nama = @penulis),
                            (SELECT kategori_id FROM kategori WHERE kategori_nama = @kategori),
                            (SELECT penerbit_id FROM penerbit WHERE penerbit_nama = @penerbit),
                            (SELECT rak_id FROM rak WHERE rak_nama = @rak),
                            @judul,
                            @isbn,
                            @tahun
                        )";

                    command = new SqlCommand(sql, connection);

                    isiParameter(command);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                TemaPopup.Tampilkan(this, "Data buku berhasil ditambahkan.",
                    "Buku tersimpan", MessageBoxIcon.Information);

                clear();
                showData();
            }
            catch
            {
                TemaPopup.Tampilkan(this, "Data buku gagal disimpan. Periksa kembali isian dan koneksi database.",
                    "Penyimpanan gagal", MessageBoxIcon.Warning);
            }
        }

        public void editData()
        {
            if (string.IsNullOrEmpty(id_buku))
            {
                TemaPopup.Tampilkan(this, "Pilih buku yang ingin diubah terlebih dahulu.",
                    "Buku belum dipilih", MessageBoxIcon.Warning);

                return;
            }

            if (!inputValid())
                return;

            DialogResult result = TemaPopup.Konfirmasi(this,
                "Simpan perubahan pada data buku ini?", "Konfirmasi perubahan");

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(koneksi.conn))
                    {
                        string sql =
                            @"UPDATE buku SET
                                buku_penulis_id =
                                    (SELECT penulis_id
                                     FROM penulis
                                     WHERE penulis_nama = @penulis),

                                buku_kategori_id =
                                    (SELECT kategori_id
                                     FROM kategori
                                     WHERE kategori_nama = @kategori),

                                buku_penerbit_id =
                                    (SELECT penerbit_id
                                     FROM penerbit
                                     WHERE penerbit_nama = @penerbit),

                                buku_rak_id =
                                    (SELECT rak_id
                                     FROM rak
                                     WHERE rak_nama = @rak),

                                buku_judul = @judul,
                                buku_isbn = @isbn,
                                buku_thnterbit = @tahun

                              WHERE buku_id = @id_buku";

                        command = new SqlCommand(sql, connection);

                        isiParameter(command);

                        command.Parameters.AddWithValue(
                            "@id_buku",
                            id_buku
                        );

                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                    TemaPopup.Tampilkan(this, "Perubahan data buku berhasil disimpan.",
                        "Buku diperbarui", MessageBoxIcon.Information);

                    clear();
                    showData();
                }
                catch
                {
                    TemaPopup.Tampilkan(this, "Perubahan data buku gagal disimpan.",
                        "Penyimpanan gagal", MessageBoxIcon.Warning);
                }
            }
        }

        public void deleteData()
        {
            if (string.IsNullOrEmpty(id_buku))
            {
                TemaPopup.Tampilkan(this, "Pilih buku yang ingin dihapus terlebih dahulu.",
                    "Buku belum dipilih", MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = TemaPopup.Konfirmasi(this,
                "Yakin ingin menghapus data buku yang dipilih?", "Konfirmasi hapus buku");

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(koneksi.conn))
                    {
                        string sql =
                            "DELETE FROM buku WHERE buku_id = @id_buku";

                        command = new SqlCommand(sql, connection);

                        command.Parameters.AddWithValue(
                            "@id_buku",
                            id_buku
                        );

                        connection.Open();
                        int affected = command.ExecuteNonQuery();
                        if (affected == 0)
                        {
                            TemaPopup.Tampilkan(this, "Data buku tidak ditemukan atau sudah dihapus.",
                                "Penghapusan tidak dilakukan", MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    TemaPopup.Tampilkan(this, "Data buku berhasil dihapus.",
                        "Buku dihapus", MessageBoxIcon.Information);

                    clear();
                    showData();
                }
                catch (Exception ex)
                {
                    TemaPopup.Tampilkan(this,
                        ex is SqlException && ((SqlException)ex).Number == 547
                            ? "Buku tidak dapat dihapus karena masih digunakan pada transaksi peminjaman."
                            : "Data buku gagal dihapus. Periksa koneksi database lalu coba lagi.",
                        "Penghapusan gagal", MessageBoxIcon.Warning);
                }
            }
        }

        public void searchData()
        {
            if (!string.IsNullOrEmpty(cariBuku.Text))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(koneksi.conn))
                    {
                        string sql =
                            sqlSelectBuku +
                            @" WHERE
                                b.buku_judul LIKE '%' + @search + '%'
                                OR b.buku_isbn LIKE '%' + @search + '%'
                                OR p.penulis_nama LIKE '%' + @search + '%'
                                OR k.kategori_nama LIKE '%' + @search + '%'
                                OR pb.penerbit_nama LIKE '%' + @search + '%'
                                OR r.rak_nama LIKE '%' + @search + '%'";

                        command = new SqlCommand(sql, connection);

                        command.Parameters.AddWithValue(
                            "@search",
                            cariBuku.Text
                        );

                        adapter = new SqlDataAdapter(command);

                        tabel = new DataTable();
                        adapter.Fill(tabel);

                        dataGridView1.DataSource = tabel;

                        AturGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at: " + ex.Message);
                }
            }
            else
            {
                showData();
            }
        }

        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dataGridView1.Rows[e.RowIndex];

            row.Selected = true;

            id_buku =
                Convert.ToString(row.Cells[0].Value);

            tJudul.Text =
                Convert.ToString(row.Cells[1].Value);

            tIsbn.Text =
                Convert.ToString(row.Cells[2].Value);

            int tahunTerbit;
            if (int.TryParse(Convert.ToString(row.Cells[3].Value), out tahunTerbit))
            {
                tThnterbit.Value = Math.Max(tThnterbit.Minimum,
                    Math.Min(tThnterbit.Maximum, tahunTerbit));
            }

            string namaPenulis =
                Convert.ToString(row.Cells[4].Value);

            string namaKategori =
                Convert.ToString(row.Cells[5].Value);

            string namaPenerbit =
                Convert.ToString(row.Cells[6].Value);

            string namaRak =
                Convert.ToString(row.Cells[7].Value);

            cPenulis.SelectedIndex = -1;
            cKategori.SelectedIndex = -1;
            cPenerbit.SelectedIndex = -1;
            cRak.SelectedIndex = -1;

            for (int i = 0; i < cPenulis.Items.Count; i++)
            {
                if (cPenulis.Items[i].ToString().Trim() ==
                    namaPenulis.Trim())
                {
                    cPenulis.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cKategori.Items.Count; i++)
            {
                if (cKategori.Items[i].ToString().Trim() ==
                    namaKategori.Trim())
                {
                    cKategori.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cPenerbit.Items.Count; i++)
            {
                if (cPenerbit.Items[i].ToString().Trim() ==
                    namaPenerbit.Trim())
                {
                    cPenerbit.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < cRak.Items.Count; i++)
            {
                if (cRak.Items[i].ToString().Trim() ==
                    namaRak.Trim())
                {
                    cRak.SelectedIndex = i;
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            dataGridView1_CellClick(sender, e);
        }


        private void TerapkanTema()
        {
            TemaWarna.Terapkan(this);
            pHeader.BackColor = TemaWarna.Plum;
            lLine.BackColor = TemaWarna.MawarTua;
            label2.BackColor = TemaWarna.MawarTua;
            label2.ForeColor = System.Drawing.Color.White;
            label4.BackColor = TemaWarna.MawarTua;
            label4.ForeColor = System.Drawing.Color.White;
            panel1.BackColor = TemaWarna.Lavender;
        }

        private void buku_admin_Resize(object sender, EventArgs e)
        {
            AturLayout();
            TerapkanTema();
        }

        private void AturLayout()
        {
            SuspendLayout();

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
                panel1.Padding = new Padding(25, 23, 25, 23);

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

                int contentLeft = panel1.Width + 18;
                int contentRight = this.ClientSize.Width - 18;
                int contentWidth = contentRight - contentLeft;

                int gap = 16;

                int panel2Width = (int)(contentWidth * 0.36);
                int panel4Width = contentWidth - panel2Width - gap;

                if (panel2Width < 300)
                    panel2Width = 300;

                if (panel4Width < 350)
                    panel4Width = 350;

                int totalWidth = panel2Width + gap + panel4Width;

                if (totalWidth > contentWidth)
                {
                    panel2Width = (int)(contentWidth * 0.35);
                    panel4Width = contentWidth - panel2Width - gap;
                }

                int contentX = contentLeft;

                label3.Font = new Font(
                    "Arial",
                    18F,
                    FontStyle.Bold
                );

                label3.Location = new Point(
                    220 + ((this.ClientSize.Width - 220 - label3.Width) / 2),
                    175
                );

                panel2.Location = new Point(contentX, 210);
                panel2.Size = new Size(panel2Width, 137);

                panel4.Location = new Point(contentX + panel2Width + gap, 210);
                panel4.Size = new Size(panel4Width, 137);

                cPenulis.Location = new Point(63, 11);
                cKategori.Location = new Point(63, 42);
                cPenerbit.Location = new Point(63, 77);
                cRak.Location = new Point(63, 108);

                cPenulis.Width = panel2.Width - 70;
                cKategori.Width = panel2.Width - 70;
                cPenerbit.Width = panel2.Width - 70;
                cRak.Width = panel2.Width - 70;

                tJudul.Location = new Point(94, 12);
                tIsbn.Location = new Point(94, 47);
                tThnterbit.Location = new Point(94, 82);

                tJudul.Width = panel4.Width - 102;
                tIsbn.Width = panel4.Width - 102;
                tThnterbit.Width = panel4.Width - 102;

                panel3.Location = new Point(contentX, 355);
                panel3.Size = new Size(contentWidth, 45);

                bInsert.Location = new Point((panel3.Width / 2) - 180, 7);
                bEdit.Location = new Point((panel3.Width / 2) - 30, 7);
                bDelete.Location = new Point((panel3.Width / 2) + 120, 7);

                label8.Location = new Point(contentX, 420);
                cariBuku.Location = new Point(label8.Right + 8, 417);

                dataGridView1.Location = new Point(contentX, 450);
                dataGridView1.Size = new Size(
                    contentWidth,
                    Math.Max(100, this.ClientSize.Height - 485)
                );
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

                int contentLeft = panel1.Width + 10;
                int contentRight = this.ClientSize.Width - 10;
                int contentWidth = Math.Max(200, contentRight - contentLeft);

                int gap = 10;

                int panel2Width = (int)(contentWidth * 0.4);
                int panel4Width = contentWidth - panel2Width - gap;

                if (panel2Width < 200)
                    panel2Width = 200;

                if (panel4Width < 220)
                    panel4Width = 220;

                int totalWidth = panel2Width + gap + panel4Width;

                if (totalWidth > contentWidth)
                {
                    panel2Width = (int)(contentWidth * 0.45);
                    panel4Width = contentWidth - panel2Width - gap;
                }

                int contentX = contentLeft;

                label3.Font = new Font(
                    "Arial",
                    14F,
                    FontStyle.Bold
                );

                label3.Location = new Point(
                    130 + ((this.ClientSize.Width - 130 - label3.Width) / 2),
                    112
                );

                panel2.Location = new Point(contentX, 140);
                panel2.Size = new Size(panel2Width, 137);

                panel4.Location = new Point(contentX + panel2Width + gap, 140);
                panel4.Size = new Size(panel4Width, 137);

                cPenulis.Location = new Point(63, 11);
                cKategori.Location = new Point(63, 42);
                cPenerbit.Location = new Point(63, 77);
                cRak.Location = new Point(63, 108);

                cPenulis.Width = Math.Max(50, panel2.Width - 70);
                cKategori.Width = Math.Max(50, panel2.Width - 70);
                cPenerbit.Width = Math.Max(50, panel2.Width - 70);
                cRak.Width = Math.Max(50, panel2.Width - 70);

                tJudul.Location = new Point(94, 12);
                tIsbn.Location = new Point(94, 47);
                tThnterbit.Location = new Point(94, 82);

                tJudul.Width = Math.Max(50, panel4.Width - 102);
                tIsbn.Width = Math.Max(50, panel4.Width - 102);
                tThnterbit.Width = Math.Max(50, panel4.Width - 102);

                panel3.Location = new Point(contentX, 285);
                panel3.Size = new Size(contentWidth, 40);

                bInsert.Location = new Point((panel3.Width / 2) - 140, 5);
                bEdit.Location = new Point((panel3.Width / 2) - 25, 5);
                bDelete.Location = new Point((panel3.Width / 2) + 90, 5);

                label8.Location = new Point(contentX, 332);
                cariBuku.Location = new Point(label8.Right + 8, 330);

                dataGridView1.Location = new Point(contentX, 360);
                dataGridView1.Size = new Size(
                    contentWidth,
                    Math.Max(80, this.ClientSize.Height - 375)
                );
            }

            ResumeLayout();
        }

        private void buku_admin_Load(object sender, EventArgs e)
        {
            errorProvider.ContainerControl = this;
            tJudul.MaxLength = 40;
            tIsbn.MaxLength = 16;
            tThnterbit.Value = DateTime.Now.Year;
            tIsbn.Text = new string(tIsbn.Text.Where(char.IsDigit).ToArray());
            tIsbn.KeyPress -= HanyaAngka_KeyPress;
            tIsbn.KeyPress += HanyaAngka_KeyPress;
            tIsbn.TextChanged -= Isbn_TextChanged;
            tIsbn.TextChanged += Isbn_TextChanged;

            cPenulis.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cKategori.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cPenerbit.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cRak.DropDownStyle =
                ComboBoxStyle.DropDownList;

            label4.Text = Model.name;

            AturLayout();
            TerapkanTema();

            showNamaPenulis();
            showNamaKategori();
            showNamaPenerbit();
            showNamaRak();

            showData();
        }

        private void HanyaAngka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void Isbn_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(tIsbn,
                tIsbn.Text.Length > 0 && !tIsbn.Text.All(char.IsDigit)
                    ? "ISBN hanya boleh berisi angka."
                    : string.Empty);
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
            Login panggil = new Login();
            panggil.Show();
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

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cariBuku_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void bInsert_Click_1(object sender, EventArgs e)
        {
            insertData();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            editData();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            deleteData();
        }
    }
}
