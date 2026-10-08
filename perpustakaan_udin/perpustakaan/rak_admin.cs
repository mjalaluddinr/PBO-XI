using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace perpustakaan
{
    public partial class rak_admin : Form
    {
        public SqlConnection connection = new SqlConnection(koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public string id_rak;

        public rak_admin()
        {
            InitializeComponent();

            label4.Text = Model.name;

            showData();

            this.Resize += rak_admin_Resize;

            AturLayout();
        }

        private void rak_admin_Resize(object sender, EventArgs e)
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

                label3.Font = new Font(
                    "Arial",
                    18F,
                    FontStyle.Bold
                );
                label3.Location = new Point(
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
                    contentLeft +
                    leftWidth +
                    gap;

                panel2.Location = new Point(
                    contentLeft,
                    contentTop
                );

                panel2.Size = new Size(
                    leftWidth,
                    136
                );

                label5.Font = new Font(
                    "Microsoft Sans Serif",
                    12F
                );

                label6.Font = new Font(
                    "Microsoft Sans Serif",
                    12F
                );

                label7.Font = new Font(
                    "Microsoft Sans Serif",
                    12F
                );

                label5.Location = new Point(15, 15);
                label6.Location = new Point(15, 55);
                label7.Location = new Point(15, 97);

                int inputLeft = 135;
                int inputWidth =
                    panel2.Width -
                    inputLeft -
                    15;

                rakNama.Location = new Point(
                    inputLeft,
                    15
                );

                rakNama.Size = new Size(
                    inputWidth,
                    20
                );

                rakLokasi.Location = new Point(
                    inputLeft,
                    54
                );

                rakLokasi.Size = new Size(
                    inputWidth,
                    20
                );

                rakKapasitas.Location = new Point(
                    inputLeft,
                    96
                );

                rakKapasitas.Size = new Size(
                    inputWidth,
                    20
                );

                panel3.Location = new Point(
                    contentLeft,
                    contentTop + 145
                );

                panel3.Size = new Size(
                    leftWidth,
                    57
                );

                int buttonGap = 8;

                int buttonWidth =
                    (panel3.Width - 16 - (buttonGap * 2)) / 3;

                bInsert.Font = new Font(
                    "Microsoft Sans Serif",
                    10F
                );

                bInsert.Location = new Point(8, 10);

                bInsert.Size = new Size(
                    buttonWidth,
                    35
                );

                bEdit.Font = new Font(
                    "Microsoft Sans Serif",
                    10F
                );

                bEdit.Location = new Point(
                    8 + buttonWidth + buttonGap,
                    10
                );

                bEdit.Size = new Size(
                    buttonWidth,
                    35
                );

                bDelete.Font = new Font(
                    "Microsoft Sans Serif",
                    10F
                );

                bDelete.Location = new Point(
                    8 + ((buttonWidth + buttonGap) * 2),
                    10
                );

                bDelete.Size = new Size(
                    buttonWidth,
                    35
                );

                int searchWidth = 180;
                int searchGap = 10;

                label8.Font = new Font(
                    "Microsoft Sans Serif",
                    12F
                );

                int searchStartX = rightX + 15;

                label8.Location = new Point(
                    searchStartX,
                    contentTop - 30
                );

                cariRak.Location = new Point(
                    label8.Right + searchGap,
                    contentTop - 32
                );

                cariRak.Size = new Size(
                    searchWidth,
                    20
                );

                dataGridView1.Location = new Point(
                    rightX,
                    contentTop
                );

                dataGridView1.Size = new Size(
                    rightWidth,
                    this.ClientSize.Height -
                    contentTop -
                    20
                );

                dataGridView1.DefaultCellStyle.Font =
                    new Font(
                        "Microsoft Sans Serif",
                        11F
                    );

                dataGridView1.RowTemplate.Height = 28;

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

                label3.Font = new Font(
                    "Arial",
                    14F,
                    FontStyle.Bold
                );

                label3.Location = new Point(
                    130 +
                    ((this.ClientSize.Width - 130 - label3.Width) / 2),
                    115
                );

                panel2.Location = new Point(
                    145,
                    155
                );

                panel2.Size = new Size(
                    190,
                    115
                );

                label5.Font = new Font(
                    "Microsoft Sans Serif",
                    9F
                );

                label6.Font = new Font(
                    "Microsoft Sans Serif",
                    9F
                );

                label7.Font = new Font(
                    "Microsoft Sans Serif",
                    9F
                );

                label5.Location = new Point(8, 12);
                label6.Location = new Point(8, 48);
                label7.Location = new Point(8, 83);

                rakNama.Location = new Point(88, 12);
                rakNama.Size = new Size(95, 20);

                rakLokasi.Location = new Point(88, 47);
                rakLokasi.Size = new Size(95, 20);

                rakKapasitas.Location = new Point(88, 82);
                rakKapasitas.Size = new Size(95, 20);

                panel3.Location = new Point(
                    145,
                    280
                );

                panel3.Size = new Size(
                    190,
                    45
                );

                bInsert.Font = new Font(
                    "Microsoft Sans Serif",
                    8F
                );

                bInsert.Location = new Point(5, 7);
                bInsert.Size = new Size(55, 30);

                bEdit.Font = new Font(
                    "Microsoft Sans Serif",
                    8F
                );

                bEdit.Location = new Point(67, 7);
                bEdit.Size = new Size(55, 30);

                bDelete.Font = new Font(
                    "Microsoft Sans Serif",
                    8F
                );

                bDelete.Location = new Point(129, 7);
                bDelete.Size = new Size(55, 30);

                label8.Font = new Font(
                    "Microsoft Sans Serif",
                    9F
                );

                label8.Location = new Point(
                    365,
                    145
                );

                cariRak.Location = new Point(
                    415,
                    143
                );

                cariRak.Size = new Size(
                    120,
                    20
                );

                dataGridView1.Location = new Point(
                    350,
                    170
                );

                dataGridView1.Size = new Size(
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
                    new Font(
                        "Microsoft Sans Serif",
                        9F
                    );

                dataGridView1.RowTemplate.Height = 24;

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

        public void showData()
        {
            using (SqlConnection connection =
                new SqlConnection(koneksi.conn))
            {
                try
                {
                    connection.Open();

                    string sql =
                        "SELECT * FROM rak";

                    command = new SqlCommand(
                        sql,
                        connection
                    );

                    adapter = new SqlDataAdapter(command);

                    tabel = new DataTable();

                    adapter.Fill(tabel);

                    dataGridView1.DataSource = tabel;

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].HeaderText = "Nama Rak";
                    dataGridView1.Columns[2].HeaderText = "Lokasi";
                    dataGridView1.Columns[3].HeaderText = "Kapasitas";
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
            rakNama.Text = "";
            rakLokasi.Text = "";
            rakKapasitas.Text = "";

            id_rak = "";
        }

        public void insertData()
        {
            int kapasitas;

            if (!string.IsNullOrEmpty(rakNama.Text) &&
                !string.IsNullOrEmpty(rakLokasi.Text) &&
                !string.IsNullOrEmpty(rakKapasitas.Text) &&
                int.TryParse(rakKapasitas.Text, out kapasitas))
            {
                try
                {
                    using (SqlConnection connection =
                        new SqlConnection(koneksi.conn))
                    {
                        string sql =
                            "INSERT INTO rak " +
                            "(rak_nama, rak_lokasi, rak_kapasitas) " +
                            "VALUES " +
                            "(@nama, @lokasi, @kapasitas)";

                        command = new SqlCommand(
                            sql,
                            connection
                        );

                        command.Parameters.AddWithValue(
                            "@nama",
                            rakNama.Text
                        );

                        command.Parameters.AddWithValue(
                            "@lokasi",
                            rakLokasi.Text
                        );

                        command.Parameters.Add(
                            "@kapasitas",
                            SqlDbType.Int
                        ).Value = kapasitas;

                        connection.Open();

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Successfully inserted!",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    clear();
                    showData();
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
                MessageBox.Show(
                    "Please fill all data before insert!"
                );
            }
        }

        public void editData()
        {
            int kapasitas;

            if (dataGridView1.CurrentRow != null &&
                dataGridView1.CurrentRow.Selected)
            {
                if (!string.IsNullOrEmpty(rakNama.Text) &&
                    !string.IsNullOrEmpty(rakLokasi.Text) &&
                    !string.IsNullOrEmpty(rakKapasitas.Text) &&
                    int.TryParse(
                        rakKapasitas.Text,
                        out kapasitas
                    ))
                {
                    DialogResult result =
                        MessageBox.Show(
                            "Are you sure to update?",
                            "Confirmation",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (SqlConnection connection =
                                new SqlConnection(koneksi.conn))
                            {
                                string sql =
                                    "UPDATE rak SET " +
                                    "rak_nama = @nama, " +
                                    "rak_lokasi = @lokasi, " +
                                    "rak_kapasitas = @kapasitas " +
                                    "WHERE rak_id = @id_rak";

                                command = new SqlCommand(
                                    sql,
                                    connection
                                );

                                command.Parameters.AddWithValue(
                                    "@id_rak",
                                    id_rak
                                );

                                command.Parameters.AddWithValue(
                                    "@nama",
                                    rakNama.Text
                                );

                                command.Parameters.AddWithValue(
                                    "@lokasi",
                                    rakLokasi.Text
                                );

                                command.Parameters.Add(
                                    "@kapasitas",
                                    SqlDbType.Int
                                ).Value = kapasitas;

                                connection.Open();

                                command.ExecuteNonQuery();
                            }

                            MessageBox.Show(
                                "Successfully updated!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            clear();
                            showData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(
                                ex.Message
                            );
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Please fill all data!"
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select the data!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void deleteData()
        {
            if (dataGridView1.CurrentRow == null ||
                !dataGridView1.CurrentRow.Selected)
            {
                MessageBox.Show(
                    "Please select the data!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure to delete?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection =
                        new SqlConnection(koneksi.conn))
                    {
                        string sql =
                            "DELETE FROM rak " +
                            "WHERE rak_id = @id_rak";

                        command = new SqlCommand(
                            sql,
                            connection
                        );

                        command.Parameters.AddWithValue(
                            "@id_rak",
                            id_rak
                        );

                        connection.Open();

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Successfully deleted!",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    clear();
                    showData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message
                    );
                }
            }
        }

        public void searchData()
        {
            if (!string.IsNullOrEmpty(cariRak.Text))
            {
                try
                {
                    using (SqlConnection connection =
                        new SqlConnection(koneksi.conn))
                    {
                        string sql =
                            "SELECT * FROM rak WHERE " +
                            "rak_nama LIKE '%' + @search + '%' OR " +
                            "rak_lokasi LIKE '%' + @search + '%' OR " +
                            "CONVERT(VARCHAR, rak_kapasitas) " +
                            "LIKE '%' + @search + '%'";

                        command = new SqlCommand(
                            sql,
                            connection
                        );

                        command.Parameters.AddWithValue(
                            "@search",
                            cariRak.Text
                        );

                        adapter =
                            new SqlDataAdapter(command);

                        tabel = new DataTable();

                        adapter.Fill(tabel);

                        dataGridView1.DataSource = tabel;

                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].HeaderText = "Nama Rak";
                        dataGridView1.Columns[2].HeaderText = "Lokasi";
                        dataGridView1.Columns[3].HeaderText = "Kapasitas";
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
                dataGridView1.Rows[e.RowIndex].Selected = true;

                id_rak =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells[0]
                    .Value
                    .ToString();

                rakNama.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells[1]
                    .Value
                    .ToString();

                rakLokasi.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells[2]
                    .Value
                    .ToString();

                rakKapasitas.Text =
                    dataGridView1.Rows[e.RowIndex]
                    .Cells[3]
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

        private void cariRak_TextChanged(
            object sender,
            EventArgs e)
        {
            searchData();
        }

        private void rak_admin_Load(
            object sender,
            EventArgs e)
        {
            label4.Text = Model.name;
            AturLayout();
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

        private void label3_Click(
            object sender,
            EventArgs e)
        {
        }

        private void label5_Click(
            object sender,
            EventArgs e)
        {
        }

        private void label1_Click(
            object sender,
            EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void panel3_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}