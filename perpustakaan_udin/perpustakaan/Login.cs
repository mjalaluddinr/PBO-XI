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
        }

        private void AturLayout()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                panelLogin.Size = new Size(620, 430);
                panelLogin.Location = new Point((this.ClientSize.Width - panelLogin.Width) / 2, (this.ClientSize.Height - panelLogin.Height) / 2);

                label1.Font = new Font("Calibri", 28F, FontStyle.Bold);
                label1.Location = new Point((panelLogin.Width - label1.Width) / 2, 35);

                label2.Font = new Font("Calibri", 14F);
                label2.Location = new Point(120, 135);

                label3.Font = new Font("Calibri", 14F);
                label3.Location = new Point(120, 205);

                label4.Font = new Font("Calibri", 12F);
                label4.Location = new Point(140, 270);

                tUsername.Font = new Font("Microsoft Sans Serif", 12F);
                tUsername.Location = new Point(245, 132);
                tUsername.Size = new Size(230, 26);

                tPassword.Font = new Font("Microsoft Sans Serif", 12F);
                tPassword.Location = new Point(245, 202);
                tPassword.Size = new Size(230, 26);

                bRegister.Font = new Font("Calibri", 11F, FontStyle.Bold);
                bRegister.Location = new Point(305, 263);
                bRegister.Size = new Size(100, 30);

                bSignIn.Font = new Font("Calibri", 15F, FontStyle.Bold);
                bSignIn.Location = new Point(140, 330);
                bSignIn.Size = new Size(130, 55);

                bCancel.Font = new Font("Calibri", 15F, FontStyle.Bold);
                bCancel.Location = new Point(350, 330);
                bCancel.Size = new Size(130, 55);
            }
            else
            {
                panelLogin.Size = new Size(560, 340);
                panelLogin.Location = new Point((this.ClientSize.Width - panelLogin.Width) / 2, (this.ClientSize.Height - panelLogin.Height) / 2);

                label1.Font = new Font("Calibri", 24F, FontStyle.Bold);
                label1.Location = new Point((panelLogin.Width - label1.Width) / 2, 28);

                label2.Font = new Font("Calibri", 12F);
                label2.Location = new Point(92, 104);

                label3.Font = new Font("Calibri", 12F);
                label3.Location = new Point(92, 163);

                label4.Font = new Font("Calibri", 10.8F);
                label4.Location = new Point(108, 216);

                tUsername.Font = new Font("Microsoft Sans Serif", 8.25F);
                tUsername.Location = new Point(188, 103);
                tUsername.Size = new Size(180, 20);

                tPassword.Font = new Font("Microsoft Sans Serif", 8.25F);
                tPassword.Location = new Point(188, 162);
                tPassword.Size = new Size(180, 20);

                bRegister.Font = new Font("Calibri", 10F, FontStyle.Bold);
                bRegister.Location = new Point(244, 211);
                bRegister.Size = new Size(81, 27);

                bSignIn.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
                bSignIn.Location = new Point(95, 260);
                bSignIn.Size = new Size(110, 50);

                bCancel.Font = new Font("Calibri", 13.8F, FontStyle.Bold);
                bCancel.Location = new Point(255, 260);
                bCancel.Size = new Size(110, 50);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AturLayout();
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