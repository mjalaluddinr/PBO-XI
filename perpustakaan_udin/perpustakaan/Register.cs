using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace perpustakaan
{
    public partial class Register : Form
    {
        public SqlConnection connection = new SqlConnection(koneksi.conn);
        public SqlCommand command;

        public Register()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.Resize += Register_Resize;

            AturLayout();
        }

        public void clear()
        {
            nama.Text = "";
            alamat.Text = "";
            email.Text = "";
            notlp.Text = "";
            username.Text = "";
            password.Text = "";
        }

        public void insertData()
        {
            if (!string.IsNullOrEmpty(nama.Text) &&
                !string.IsNullOrEmpty(alamat.Text) &&
                !string.IsNullOrEmpty(email.Text) &&
                !string.IsNullOrEmpty(notlp.Text) &&
                !string.IsNullOrEmpty(username.Text) &&
                !string.IsNullOrEmpty(password.Text))
            {
                string sql =
                    "INSERT INTO users (user_nama, user_alamat, user_username, user_email, user_notelp, user_password, user_level) " +
                    "VALUES (@nama, @alamat, @username, @email, @notelp, @password, @level)";

                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@nama", nama.Text);
                command.Parameters.AddWithValue("@alamat", alamat.Text);
                command.Parameters.AddWithValue("@username", username.Text);
                command.Parameters.AddWithValue("@email", email.Text);
                command.Parameters.AddWithValue("@notelp", notlp.Text);
                command.Parameters.AddWithValue("@password", password.Text);
                command.Parameters.AddWithValue("@level", "anggota");

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show(
                        "Successfully registered!",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    clear();

                    this.Hide();

                    Login panggil = new Login();
                    panggil.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at:" + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all data");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            AturLayout();
        }

        private void Register_Resize(object sender, EventArgs e)
        {
            AturLayout();
        }

        private void AturLayout()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                panelRegister.Size = new Size(620, 430);

                panelRegister.Location = new Point(
                    (this.ClientSize.Width - panelRegister.Width) / 2,
                    (this.ClientSize.Height - panelRegister.Height) / 2
                );

                label1.Font = new Font(
                    "Calibri",
                    28F,
                    FontStyle.Bold
                );

                label1.Location = new Point(
                    (panelRegister.Width - label1.Width) / 2,
                    35
                );

                label2.Font = new Font(
                    "Calibri",
                    14F,
                    FontStyle.Bold
                );

                label2.Location = new Point(55, 130);

                label3.Font = new Font(
                    "Calibri",
                    14F,
                    FontStyle.Bold
                );

                label3.Location = new Point(50, 185);

                label6.Font = new Font(
                    "Calibri",
                    14F,
                    FontStyle.Bold
                );

                label6.Location = new Point(57, 320);

                label5.Font = new Font(
                    "Calibri",
                    14F,
                    FontStyle.Bold
                );

                label5.Location = new Point(25, 370);

                label4.Font = new Font(
                    "Calibri",
                    14F,
                    FontStyle.Bold
                );

                label4.Location = new Point(350, 135);

                label7.Font = new Font(
                    "Calibri",
                    14F,
                    FontStyle.Bold
                );

                label7.Location = new Point(350, 190);

                nama.Font = new Font(
                    "Microsoft Sans Serif",
                    10F
                );

                nama.Location = new Point(165, 127);
                nama.Size = new Size(180, 26);

                alamat.Font = new Font(
                    "Microsoft Sans Serif",
                    10F
                );

                alamat.Location = new Point(165, 182);
                alamat.Size = new Size(180, 105);

                email.Font = new Font(
                    "Microsoft Sans Serif",
                    10F
                );

                email.Location = new Point(165, 315);
                email.Size = new Size(180, 26);

                notlp.Font = new Font(
                    "Microsoft Sans Serif",
                    10F
                );

                notlp.Location = new Point(165, 365);
                notlp.Size = new Size(180, 26);

                username.Font = new Font(
                    "Microsoft Sans Serif",
                    10F
                );

                username.Location = new Point(445, 132);
                username.Size = new Size(140, 26);

                password.Font = new Font(
                    "Microsoft Sans Serif",
                    10F
                );

                password.Location = new Point(445, 187);
                password.Size = new Size(140, 26);

                bton.Font = new Font(
                    "Calibri",
                    15F,
                    FontStyle.Bold
                );

                bton.Location = new Point(245, 390);
                bton.Size = new Size(130, 45);
            }
            else
            {
                panelRegister.Size = new Size(560, 340);

                panelRegister.Location = new Point(
                    (this.ClientSize.Width - panelRegister.Width) / 2,
                    (this.ClientSize.Height - panelRegister.Height) / 2
                );

                label1.Font = new Font(
                    "Calibri",
                    24F,
                    FontStyle.Bold
                );

                label1.Location = new Point(
                    (panelRegister.Width - label1.Width) / 2,
                    28
                );

                label2.Font = new Font(
                    "Calibri",
                    12F,
                    FontStyle.Bold
                );

                label2.Location = new Point(70, 100);

                label3.Font = new Font(
                    "Calibri",
                    12F,
                    FontStyle.Bold
                );

                label3.Location = new Point(65, 138);

                label6.Font = new Font(
                    "Calibri",
                    12F,
                    FontStyle.Bold
                );

                label6.Location = new Point(72, 238);

                label5.Font = new Font(
                    "Calibri",
                    12F,
                    FontStyle.Bold
                );

                label5.Location = new Point(44, 275);

                label4.Font = new Font(
                    "Calibri",
                    12F,
                    FontStyle.Bold
                );

                label4.Location = new Point(320, 102);

                label7.Font = new Font(
                    "Calibri",
                    12F,
                    FontStyle.Bold
                );

                label7.Location = new Point(320, 140);

                nama.Font = new Font(
                    "Microsoft Sans Serif",
                    8.25F
                );

                nama.Location = new Point(136, 99);
                nama.Size = new Size(134, 20);

                alamat.Font = new Font(
                    "Microsoft Sans Serif",
                    8.25F
                );

                alamat.Location = new Point(136, 137);
                alamat.Size = new Size(134, 79);

                email.Font = new Font(
                    "Microsoft Sans Serif",
                    8.25F
                );

                email.Location = new Point(136, 236);
                email.Size = new Size(134, 20);

                notlp.Font = new Font(
                    "Microsoft Sans Serif",
                    8.25F
                );

                notlp.Location = new Point(136, 273);
                notlp.Size = new Size(134, 20);

                username.Font = new Font(
                    "Microsoft Sans Serif",
                    8.25F
                );

                username.Location = new Point(394, 101);
                username.Size = new Size(141, 20);

                password.Font = new Font(
                    "Microsoft Sans Serif",
                    8.25F
                );

                password.Location = new Point(394, 139);
                password.Size = new Size(141, 20);

                bton.Font = new Font(
                    "Calibri",
                    13.8F,
                    FontStyle.Bold
                );

                bton.Location = new Point(225, 292);
                bton.Size = new Size(110, 50);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void bton_Click(object sender, EventArgs e)
        {
            insertData();
        }
    }
}