using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace perpustakaan
{
    public partial class Login : Form
    {
        public SqlConnection connection = new SqlConnection(koneksi.conn);
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataTable tabel;
        public SqlDataReader reader;

        public Login()
        {
            InitializeComponent();

            this.Resize += Login_Resize;

            AturLayout();
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            AturLayout();
            TerapkanTema();
        }

        private void TerapkanTema()
        {
            this.BackColor = TemaWarna.Lavender;
            this.Font = new Font("Segoe UI", 10F);
            panelLogin.BackColor = TemaWarna.Lavender;
            panelLogin.BorderStyle = BorderStyle.None;
            label1.ForeColor = TemaWarna.Plum;
            foreach (Label label in new[] { label2, label3, label4 })
                label.ForeColor = TemaWarna.UnguTua;
            foreach (TextBox input in new[] { tUsername, tPassword })
            {
                input.BackColor = Color.White;
                input.ForeColor = TemaWarna.UnguTua;
                input.BorderStyle = BorderStyle.FixedSingle;
            }
            AturTombol(bSignIn, TemaWarna.Plum, Color.White);
            AturTombol(bRegister, TemaWarna.Mawar, TemaWarna.UnguTua);
            AturTombol(bCancel, TemaWarna.Latar, TemaWarna.UnguTua);
        }

        private void AturTombol(Button button, Color backColor, Color foreColor)
        {
            button.BackColor = backColor;
            button.ForeColor = foreColor;
            button.FlatStyle = FlatStyle.Flat;
            button.UseVisualStyleBackColor = false;
            button.FlatAppearance.BorderColor = TemaWarna.MawarTua;
            button.FlatAppearance.MouseOverBackColor = backColor == TemaWarna.Plum
                ? TemaWarna.MawarTua
                : TemaWarna.Mawar;
        }

        private void AturLayout()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                panelLogin.Size = new Size(620, 430);
                panelLogin.Location = new Point((this.ClientSize.Width - panelLogin.Width) / 2, (this.ClientSize.Height - panelLogin.Height) / 2);

                label1.Font = new Font("Calibri", 28F, FontStyle.Bold);
                label1.Location = new Point((panelLogin.Width - label1.Width) / 2, 35);

                label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                label2.Location = new Point(105, 132);

                label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                label3.Location = new Point(105, 202);

                label4.Font = new Font("Segoe UI", 10F);
                label4.Location = new Point(150, 277);

                tUsername.Font = new Font("Segoe UI", 11F);
                tUsername.Location = new Point(245, 128);
                tUsername.Size = new Size(270, 30);

                tPassword.Font = new Font("Segoe UI", 11F);
                tPassword.Location = new Point(245, 198);
                tPassword.Size = new Size(270, 30);

                bRegister.Font = new Font("Calibri", 11F, FontStyle.Bold);
                bRegister.Location = new Point(300, 270);
                bRegister.Size = new Size(110, 34);

                bSignIn.Font = new Font("Calibri", 15F, FontStyle.Bold);
                bSignIn.Location = new Point(145, 340);
                bSignIn.Size = new Size(150, 52);

                bCancel.Font = new Font("Calibri", 15F, FontStyle.Bold);
                bCancel.Location = new Point(325, 340);
                bCancel.Size = new Size(150, 52);
            }
            else
            {
                int width = Math.Min(560, Math.Max(380, this.ClientSize.Width - 32));
                int height = Math.Min(360, Math.Max(320, this.ClientSize.Height - 32));
                panelLogin.Size = new Size(width, height);
                panelLogin.Location = new Point((this.ClientSize.Width - panelLogin.Width) / 2, (this.ClientSize.Height - panelLogin.Height) / 2);

                label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
                label1.Location = new Point((panelLogin.Width - label1.Width) / 2, 25);

                label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                label2.Location = new Point(70, 100);

                label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                label3.Location = new Point(70, 154);

                label4.Font = new Font("Segoe UI", 9F);
                label4.Location = new Point(92, 212);

                tUsername.Font = new Font("Segoe UI", 9.5F);
                tUsername.Location = new Point(190, 96);
                tUsername.Size = new Size(Math.Max(130, width - 260), 26);

                tPassword.Font = new Font("Segoe UI", 9.5F);
                tPassword.Location = new Point(190, 150);
                tPassword.Size = new Size(Math.Max(130, width - 260), 26);

                bRegister.Font = new Font("Calibri", 10F, FontStyle.Bold);
                bRegister.Location = new Point(250, 207);
                bRegister.Size = new Size(90, 30);

                bSignIn.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
                bSignIn.Location = new Point(width / 2 - 125, 265);
                bSignIn.Size = new Size(110, 42);

                bCancel.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
                bCancel.Location = new Point(width / 2 + 15, 265);
                bCancel.Size = new Size(110, 42);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AturLayout();
            TerapkanTema();
        }

        private void bSignIn_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sql = "SELECT * FROM users WHERE user_username = '" + tUsername.Text + "' AND user_password = '" + tPassword.Text + "'";

            command = new SqlCommand(sql, connection);
            adapter = new SqlDataAdapter(command);

            tabel = new DataTable();
            adapter.Fill(tabel);

            if (tabel.Rows.Count > 0)
            {
                foreach (DataRow dr in tabel.Rows)
                {
                    if (dr["user_level"].ToString() == "admin")
                    {
                        reader = command.ExecuteReader();
                        reader.Read();

                        Model.name = reader.GetString(1);

                        this.Hide();

                        Admin panggil = new Admin();
                        panggil.Show();
                    }
                    else if (dr["user_level"].ToString() == "anggota")
                    {
                        reader = command.ExecuteReader();
                        reader.Read();

                        Model.name = reader.GetString(1);
                        Model.iduser = dr["user_id"].ToString();

                        this.Hide();

                        Anggota panggil = new Anggota();
                        panggil.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }

            connection.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register panggil = new Register();
            panggil.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
