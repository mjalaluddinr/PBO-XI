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
            this.SuspendLayout();

            if (this.WindowState == FormWindowState.Maximized)
            {
                panelRegister.Size = new Size(720, 560);

                panelRegister.Location = new Point(
                    (this.ClientSize.Width - panelRegister.Width) / 2,
                    (this.ClientSize.Height - panelRegister.Height) / 2
                );

                label1.Font = new Font("Calibri", 28F, FontStyle.Bold);
                label1.Location = new Point((panelRegister.Width - label1.Width) / 2, 25);

                label2.Font = new Font("Calibri", 13F, FontStyle.Bold);
                label2.Location = new Point(40, 95);
                nama.Font = new Font("Microsoft Sans Serif", 10F);
                nama.Location = new Point(155, 93);
                nama.Size = new Size(180, 26);

                label4.Font = new Font("Calibri", 13F, FontStyle.Bold);
                label4.Location = new Point(380, 95);
                username.Font = new Font("Microsoft Sans Serif", 10F);
                username.Location = new Point(480, 93);
                username.Size = new Size(180, 26);

                label3.Font = new Font("Calibri", 13F, FontStyle.Bold);
                label3.Location = new Point(40, 145);
                alamat.Font = new Font("Microsoft Sans Serif", 10F);
                alamat.Location = new Point(155, 143);
                alamat.Size = new Size(180, 100);

                label7.Font = new Font("Calibri", 13F, FontStyle.Bold);
                label7.Location = new Point(380, 145);
                password.Font = new Font("Microsoft Sans Serif", 10F);
                password.Location = new Point(480, 143);
                password.Size = new Size(180, 26);

                label6.Font = new Font("Calibri", 13F, FontStyle.Bold);
                label6.Location = new Point(40, 265);
                email.Font = new Font("Microsoft Sans Serif", 10F);
                email.Location = new Point(155, 263);
                email.Size = new Size(180, 26);

                label5.Font = new Font("Calibri", 13F, FontStyle.Bold);
                label5.Location = new Point(40, 310);
                notlp.Font = new Font("Microsoft Sans Serif", 10F);
                notlp.Location = new Point(155, 308);
                notlp.Size = new Size(180, 26);

                bton.Font = new Font("Calibri", 14F, FontStyle.Bold);
                bton.Size = new Size(150, 45);
                bton.Location = new Point((panelRegister.Width - bton.Width) / 2, 385);

                label8.Font = new Font("Calibri", 11F, FontStyle.Bold);
                label8.Location = new Point(230, 465);

                button1.Font = new Font("Calibri", 11F, FontStyle.Bold);
                button1.Size = new Size(90, 32);
                button1.Location = new Point(label8.Right + 8, 460);
            }
            else
            {
                int targetWidth = Math.Min(580, Math.Max(320, this.ClientSize.Width - 40));
                int targetHeight = Math.Min(450, Math.Max(320, this.ClientSize.Height - 40));

                panelRegister.Size = new Size(targetWidth, targetHeight);

                panelRegister.Location = new Point(
                    (this.ClientSize.Width - panelRegister.Width) / 2,
                    (this.ClientSize.Height - panelRegister.Height) / 2
                );

                label1.Font = new Font("Calibri", 20F, FontStyle.Bold);
                label1.Location = new Point((panelRegister.Width - label1.Width) / 2, 15);

                int leftMargin = 20;
                int labelWidth = 70;
                int inputWidth = Math.Max(80, (panelRegister.Width / 2) - leftMargin - labelWidth - 15);
                int col2LeftMargin = (panelRegister.Width / 2) + 10;

                label2.Font = new Font("Calibri", 10F, FontStyle.Bold);
                label2.Location = new Point(leftMargin, 60);
                nama.Font = new Font("Microsoft Sans Serif", 9F);
                nama.Location = new Point(leftMargin + labelWidth, 58);
                nama.Size = new Size(inputWidth, 22);

                label3.Font = new Font("Calibri", 10F, FontStyle.Bold);
                label3.Location = new Point(leftMargin, 93);
                alamat.Font = new Font("Microsoft Sans Serif", 9F);
                alamat.Location = new Point(leftMargin + labelWidth, 91);
                alamat.Size = new Size(inputWidth, 70);

                label6.Font = new Font("Calibri", 10F, FontStyle.Bold);
                label6.Location = new Point(leftMargin, 173);
                email.Font = new Font("Microsoft Sans Serif", 9F);
                email.Location = new Point(leftMargin + labelWidth, 171);
                email.Size = new Size(inputWidth, 22);

                label5.Font = new Font("Calibri", 10F, FontStyle.Bold);
                label5.Location = new Point(leftMargin, 206);
                notlp.Font = new Font("Microsoft Sans Serif", 9F);
                notlp.Location = new Point(leftMargin + labelWidth, 204);
                notlp.Size = new Size(inputWidth, 22);

                label4.Font = new Font("Calibri", 10F, FontStyle.Bold);
                label4.Location = new Point(col2LeftMargin, 60);
                username.Font = new Font("Microsoft Sans Serif", 9F);
                username.Location = new Point(col2LeftMargin + labelWidth, 58);
                username.Size = new Size(inputWidth, 22);

                label7.Font = new Font("Calibri", 10F, FontStyle.Bold);
                label7.Location = new Point(col2LeftMargin, 93);
                password.Font = new Font("Microsoft Sans Serif", 9F);
                password.Location = new Point(col2LeftMargin + labelWidth, 91);
                password.Size = new Size(inputWidth, 22);

                bton.Font = new Font("Calibri", 11F, FontStyle.Bold);
                bton.Size = new Size(120, 35);
                bton.Location = new Point((panelRegister.Width - bton.Width) / 2, 260);

                label8.Font = new Font("Calibri", 9.5F, FontStyle.Bold);
                label8.Location = new Point((panelRegister.Width / 2) - 90, 315);

                button1.Font = new Font("Calibri", 9.5F, FontStyle.Bold);
                button1.Size = new Size(75, 28);
                button1.Location = new Point(label8.Right + 5, 310);
            }

            this.ResumeLayout();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void bton_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login panggil = new Login();
            panggil.Show();
            this.Hide();
        }
    }
}