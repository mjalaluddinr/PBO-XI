using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace perpustakaan
{
    public partial class kategori_admin : Form
    {
        private readonly ErrorProvider errorProvider = new ErrorProvider();
        public SqlConnection connection = new SqlConnection(koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public string id_kategori;

        public kategori_admin()
        {
            InitializeComponent();

            label4.Text = Model.name;

            showData();

            this.Resize += kategori_admin_Resize;

            AturLayout();
        }

        private void kategori_admin_Resize(object sender, EventArgs e)
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
                label1.Location =
                    new Point(
                        (this.ClientSize.Width - label1.Width) / 2,
                        22
                    );

                panel1.Width = 220;
                panel1.Padding = new Padding(25, 23, 25, 23);

                lLine.Location = new Point(220, 87);
                lLine.Size =
                    new Size(
                        this.ClientSize.Width - 220,
                        48
                    );

                label2.Font =
                    new Font("Calibri", 14.25F, FontStyle.Bold);

                label2.Location = new Point(230, 99);

                label4.Font =
                    new Font("Calibri", 14.25F, FontStyle.Bold);

                label4.Location =
                    new Point(label2.Right + 8, 99);

                label3.Font =
                    new Font("Arial", 18F, FontStyle.Bold);

                label3.Location =
                    new Point(
                        220 +
                        ((this.ClientSize.Width - 220 - label3.Width) / 2),
                        175
                    );

                int contentLeft = 250;
                int contentRight = 20;
                int contentTop = 260;
                int gap = 40;

                int contentWidth =
                    this.ClientSize.Width -
                    contentLeft -
                    contentRight;

                int leftWidth =
                    (int)((contentWidth - gap) * 0.4);

                int rightWidth =
                    (contentWidth - gap) - leftWidth;

                int rightX =
                    contentLeft + leftWidth + gap;

                panel2.Location =
                    new Point(contentLeft, contentTop);

                panel2.Size =
                    new Size(leftWidth, 75);

                label5.Font =
                    new Font("Microsoft Sans Serif", 12F);

                label5.Location =
                    new Point(15, 25);

                int inputLeft = 135;

                int inputWidth =
                    panel2.Width -
                    inputLeft -
                    15;

                nama.Location =
                    new Point(inputLeft, 25);

                nama.Size =
                    new Size(inputWidth, 20);

                panel3.Location =
                    new Point(contentLeft, contentTop + 85);

                panel3.Size =
                    new Size(leftWidth, 57);

                int buttonGap = 8;

                int buttonWidth =
                    (panel3.Width - 16 - (buttonGap * 2)) / 3;

                bInsert.Font =
                    new Font("Microsoft Sans Serif", 10F);

                bInsert.Location =
                    new Point(8, 10);

                bInsert.Size =
                    new Size(buttonWidth, 35);

                bEdit.Font =
                    new Font("Microsoft Sans Serif", 10F);

                bEdit.Location =
                    new Point(
                        8 + buttonWidth + buttonGap,
                        10
                    );

                bEdit.Size =
                    new Size(buttonWidth, 35);

                bDelete.Font =
                    new Font("Microsoft Sans Serif", 10F);

                bDelete.Location =
                    new Point(
                        8 +
                        ((buttonWidth + buttonGap) * 2),
                        10
                    );

                bDelete.Size =
                    new Size(buttonWidth, 35);

                int searchWidth = 180;
                int searchGap = 10;

                label8.Font =
                    new Font("Microsoft Sans Serif", 12F);

                int searchStartX =
                    rightX + 15;

                label8.Location =
                    new Point(
                        searchStartX,
                        contentTop - 30
                    );

                cariKategori.Location =
                    new Point(
                        label8.Right + searchGap,
                        contentTop - 32
                    );

                cariKategori.Size =
                    new Size(searchWidth, 20);

                dataGridView1.Location =
                    new Point(rightX, contentTop);

                dataGridView1.Size =
                    new Size(
                        rightWidth,
                        this.ClientSize.Height -
                        contentTop -
                        20
                    );

                dataGridView1.DefaultCellStyle.Font =
                    new Font("Microsoft Sans Serif", 11F);

                dataGridView1.RowTemplate.Height = 28;

                button1.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        12F,
                        FontStyle.Bold
                    );

                button2.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        12F,
                        FontStyle.Bold
                    );

                button3.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        12F,
                        FontStyle.Bold
                    );

                button4.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        12F,
                        FontStyle.Bold
                    );

                button5.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        12F,
                        FontStyle.Bold
                    );

                button6.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        12F,
                        FontStyle.Bold
                    );

                button7.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        12F,
                        FontStyle.Bold
                    );

                button8.Font =
                    new Font(
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

                label1.Font =
                    new Font("Arial", 18F, FontStyle.Bold);

                label1.Location =
                    new Point(
                        (this.ClientSize.Width - label1.Width) / 2,
                        18
                    );

                panel1.Width = 130;
                panel1.Padding = new Padding(10);

                lLine.Location =
                    new Point(130, 65);

                lLine.Size =
                    new Size(
                        this.ClientSize.Width - 130,
                        40
                    );

                label2.Font =
                    new Font("Calibri", 10F, FontStyle.Bold);

                label2.Location =
                    new Point(140, 76);

                label4.Font =
                    new Font("Calibri", 10F, FontStyle.Bold);

                label4.Location =
                    new Point(label2.Right + 5, 76);

                label3.Font =
                    new Font("Arial", 14F, FontStyle.Bold);

                label3.Location =
                    new Point(
                        130 +
                        ((this.ClientSize.Width - 130 - label3.Width) / 2),
                        115
                    );

                panel2.Location =
                    new Point(145, 155);

                panel2.Size =
                    new Size(190, 55);

                label5.Font =
                    new Font("Microsoft Sans Serif", 9F);

                label5.Location =
                    new Point(8, 20);

                nama.Location =
                    new Point(88, 17);

                nama.Size =
                    new Size(95, 20);

                panel3.Location =
                    new Point(145, 220);

                panel3.Size =
                    new Size(190, 45);

                bInsert.Font =
                    new Font("Microsoft Sans Serif", 8F);

                bInsert.Location =
                    new Point(5, 7);

                bInsert.Size =
                    new Size(55, 30);

                bEdit.Font =
                    new Font("Microsoft Sans Serif", 8F);

                bEdit.Location =
                    new Point(67, 7);

                bEdit.Size =
                    new Size(55, 30);

                bDelete.Font =
                    new Font("Microsoft Sans Serif", 8F);

                bDelete.Location =
                    new Point(129, 7);

                bDelete.Size =
                    new Size(55, 30);

                label8.Font =
                    new Font("Microsoft Sans Serif", 9F);

                label8.Location =
                    new Point(365, 145);

                cariKategori.Location =
                    new Point(415, 143);

                cariKategori.Size =
                    new Size(120, 20);

                dataGridView1.Location =
                    new Point(350, 170);

                dataGridView1.Size =
                    new Size(
                        Math.Max(
                            250,
                            this.ClientSize.Width - 366
                        ),
                        Math.Max(
                            180,
                            this.ClientSize.Height - 190
                        )
                    );

                dataGridView1.DefaultCellStyle.Font =
                    new Font("Microsoft Sans Serif", 9F);

                dataGridView1.RowTemplate.Height = 24;

                button1.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        9F,
                        FontStyle.Bold
                    );

                button2.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        9F,
                        FontStyle.Bold
                    );

                button3.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        9F,
                        FontStyle.Bold
                    );

                button4.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        9F,
                        FontStyle.Bold
                    );

                button5.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        9F,
                        FontStyle.Bold
                    );

                button6.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        9F,
                        FontStyle.Bold
                    );

                button7.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        9F,
                        FontStyle.Bold
                    );

                button8.Font =
                    new Font(
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

        public void showData()
        {
            using (SqlConnection connection =
                new SqlConnection(koneksi.conn))
            {
                try
                {
                    connection.Open();

                    string sql =
                        "SELECT * FROM kategori";

                    command =
                        new SqlCommand(sql, connection);

                    adapter =
                        new SqlDataAdapter(command);

                    tabel =
                        new DataTable();

                    adapter.Fill(tabel);

                    dataGridView1.DataSource = tabel;

                    dataGridView1.Columns[0].Visible = false;

                    dataGridView1.Columns[1].HeaderText =
                        "Nama Kategori";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error at: " + ex.Message
                    );
                }
            }
        }

        public void clear()
        {
            nama.Text = "";
        }

        public void insertData()
        {
            if (!ValidasiNama()) return;

            if (!string.IsNullOrEmpty(nama.Text))
            {
                try
                {
                    using (SqlConnection connection =
                        new SqlConnection(koneksi.conn))
                    {
                        string sql =
                            "INSERT INTO kategori " +
                            "(kategori_nama) " +
                            "VALUES (@nama)";

                        command =
                            new SqlCommand(sql, connection);

                        command.Parameters.AddWithValue(
                            "@nama",
                            nama.Text
                        );

                        connection.Open();

                        command.ExecuteNonQuery();
                    }

                    TemaPopup.Tampilkan(this, "Kategori baru berhasil ditambahkan.",
                        "Kategori tersimpan", MessageBoxIcon.Information);

                    clear();
                    showData();
                }
                catch
                {
                    TemaPopup.Tampilkan(this, "Kategori gagal disimpan. Periksa kembali data dan koneksi database.",
                        "Penyimpanan gagal", MessageBoxIcon.Warning);
                }
            }
            else
            {
                TemaPopup.Tampilkan(this, "Masukkan nama kategori terlebih dahulu.",
                    "Data belum lengkap", MessageBoxIcon.Warning);
            }
        }

        public void editData()
        {
            if (!ValidasiNama()) return;

            if (dataGridView1.CurrentRow != null &&
                dataGridView1.CurrentRow.Selected)
            {
                if (!string.IsNullOrEmpty(nama.Text))
                {
                    DialogResult result =
                        TemaPopup.Konfirmasi(this, "Simpan perubahan pada kategori ini?",
                            "Konfirmasi perubahan");

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (SqlConnection connection =
                                new SqlConnection(koneksi.conn))
                            {
                                string sql =
                                    "UPDATE kategori SET " +
                                    "kategori_nama = @nama " +
                                    "WHERE kategori_id = @id_kategori";

                                command =
                                    new SqlCommand(
                                        sql,
                                        connection
                                    );

                                command.Parameters.AddWithValue(
                                    "@id_kategori",
                                    id_kategori
                                );

                                command.Parameters.AddWithValue(
                                    "@nama",
                                    nama.Text
                                );

                                connection.Open();

                                command.ExecuteNonQuery();
                            }

                            TemaPopup.Tampilkan(this, "Perubahan kategori berhasil disimpan.",
                                "Kategori diperbarui", MessageBoxIcon.Information);

                            clear();
                            showData();
                        }
                        catch
                        {
                            TemaPopup.Tampilkan(this, "Perubahan kategori gagal disimpan.",
                                "Penyimpanan gagal", MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    TemaPopup.Tampilkan(this, "Masukkan nama kategori terlebih dahulu.",
                        "Data belum lengkap", MessageBoxIcon.Warning);
                }
            }
            else
            {
                TemaPopup.Tampilkan(this, "Pilih kategori yang ingin diubah terlebih dahulu.",
                    "Kategori belum dipilih", MessageBoxIcon.Warning);
            }
        }

        public void deleteData()
        {
            if (dataGridView1.CurrentRow == null ||
                !dataGridView1.CurrentRow.Selected)
            {
                TemaPopup.Tampilkan(this, "Pilih kategori yang ingin dihapus terlebih dahulu.",
                    "Kategori belum dipilih", MessageBoxIcon.Warning);

                return;
            }

            DialogResult result = TemaPopup.Konfirmasi(this,
                "Yakin ingin menghapus kategori yang dipilih?", "Konfirmasi hapus kategori");

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection =
                        new SqlConnection(koneksi.conn))
                    {
                        string sql =
                            "DELETE FROM kategori " +
                            "WHERE kategori_id = @id_kategori";

                        command =
                            new SqlCommand(
                                sql,
                                connection
                            );

                        command.Parameters.AddWithValue(
                            "@id_kategori",
                            id_kategori
                        );

                        connection.Open();
                        int affected = command.ExecuteNonQuery();
                        if (affected == 0)
                        {
                            TemaPopup.Tampilkan(this, "Data kategori tidak ditemukan atau sudah dihapus.",
                                "Penghapusan tidak dilakukan", MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    TemaPopup.Tampilkan(this, "Kategori berhasil dihapus.",
                        "Kategori dihapus", MessageBoxIcon.Information);

                    clear();
                    showData();
                }
                catch (Exception ex)
                {
                    TemaPopup.Tampilkan(this,
                        ex is SqlException && ((SqlException)ex).Number == 547
                            ? "Kategori tidak dapat dihapus karena masih digunakan oleh data buku. Hapus atau pindahkan relasi tersebut terlebih dahulu."
                            : "Kategori gagal dihapus. Periksa koneksi database lalu coba lagi.",
                        "Penghapusan gagal", MessageBoxIcon.Warning);
                }
            }
        }

        public void searchData()
        {
            if (!string.IsNullOrEmpty(cariKategori.Text))
            {
                try
                {
                    using (SqlConnection connection =
                        new SqlConnection(koneksi.conn))
                    {
                        string sql =
                            "SELECT * FROM kategori " +
                            "WHERE kategori_nama LIKE " +
                            "'%' + @search + '%'";

                        command =
                            new SqlCommand(
                                sql,
                                connection
                            );

                        command.Parameters.AddWithValue(
                            "@search",
                            cariKategori.Text
                        );

                        adapter =
                            new SqlDataAdapter(command);

                        tabel =
                            new DataTable();

                        adapter.Fill(tabel);

                        dataGridView1.DataSource =
                            tabel;

                        dataGridView1.Columns[0].Visible =
                            false;

                        dataGridView1.Columns[1].HeaderText =
                            "Nama Kategori";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error at: " + ex.Message
                    );
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
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected =
                    true;

                id_kategori =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells[0]
                    .Value
                    .ToString();

                nama.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells[1]
                    .Value
                    .ToString();
            }
        }

        private void bInsert_Click(
            object sender,
            EventArgs e)
        {
            insertData();
        }

        private void bEdit_Click(
            object sender,
            EventArgs e)
        {
            editData();
        }

        private void bDelete_Click(
            object sender,
            EventArgs e)
        {
            deleteData();
        }

        private void cariKategori_TextChanged(
            object sender,
            EventArgs e)
        {
            searchData();
        }

        private void kategori_admin_Load(
            object sender,
            EventArgs e)
        {
            errorProvider.ContainerControl = this;
            nama.KeyPress -= HanyaHuruf_KeyPress;
            nama.KeyPress += HanyaHuruf_KeyPress;
            nama.TextChanged -= Nama_TextChanged;
            nama.TextChanged += Nama_TextChanged;
            label4.Text = Model.name;
            AturLayout();
        }

        private void HanyaHuruf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) &&
                        !char.IsLetter(e.KeyChar) &&
                        !char.IsWhiteSpace(e.KeyChar);
        }

        private void Nama_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(nama,
                nama.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c))
                    ? "Nama kategori hanya boleh berisi huruf dan spasi."
                    : string.Empty);
        }

        // ASVS 2.2.1: nama kategori menerima huruf dan spasi saja.
        private bool ValidasiNama()
        {
            if (string.IsNullOrWhiteSpace(nama.Text))
            {
                TemaPopup.Tampilkan(this, "Nama kategori wajib diisi.", "Data belum lengkap", MessageBoxIcon.Warning);
                nama.Focus();
                return false;
            }

            if (nama.Text.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
            {
                errorProvider.SetError(nama, "Gunakan huruf dan spasi saja.");
                TemaPopup.Tampilkan(this, "Nama kategori hanya boleh berisi huruf dan spasi.",
                    "Nama kategori tidak valid", MessageBoxIcon.Warning);
                nama.Focus();
                return false;
            }

            return true;
        }

        private void button1_Click(
            object sender,
            EventArgs e)
        {
            Admin panggil = new Admin();
            panggil.Show();
            this.Hide();
        }

        private void button2_Click(
            object sender,
            EventArgs e)
        {
            penulis_admin panggil =
                new penulis_admin();

            panggil.Show();
            this.Hide();
        }

        private void button3_Click(
            object sender,
            EventArgs e)
        {
            penerbit_admin panggil =
                new penerbit_admin();

            panggil.Show();
            this.Hide();
        }

        private void button4_Click(
            object sender,
            EventArgs e)
        {
            kategori_admin panggil =
                new kategori_admin();

            panggil.Show();
            this.Hide();
        }

        private void button5_Click(
            object sender,
            EventArgs e)
        {
            rak_admin panggil =
                new rak_admin();

            panggil.Show();
            this.Hide();
        }

        private void button6_Click(
            object sender,
            EventArgs e)
        {
            buku_admin panggil =
                new buku_admin();

            panggil.Show();
            this.Hide();
        }

        private void button7_Click(
            object sender,
            EventArgs e)
        {
            peminjaman_admin panggil =
                new peminjaman_admin();

            panggil.Show();
            this.Hide();
        }

        private void button8_Click(
            object sender,
            EventArgs e)
        {
            Login panggil = new Login();
            panggil.Show();
            this.Hide();
        }
    }
}
