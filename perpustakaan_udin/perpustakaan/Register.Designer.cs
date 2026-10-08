using System.Windows.Forms;

namespace perpustakaan
{
    partial class Register
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.RichTextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.notlp = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.bton = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(74)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(241, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(74, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(70, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(320, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(48, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "No Telepon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(76, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(320, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(136, 89);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(134, 20);
            this.nama.TabIndex = 7;
            // 
            // alamat
            // 
            this.alamat.Location = new System.Drawing.Point(136, 123);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(134, 79);
            this.alamat.TabIndex = 8;
            this.alamat.Text = "";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(136, 231);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(134, 20);
            this.email.TabIndex = 9;
            // 
            // notlp
            // 
            this.notlp.Location = new System.Drawing.Point(136, 257);
            this.notlp.Name = "notlp";
            this.notlp.Size = new System.Drawing.Size(134, 20);
            this.notlp.TabIndex = 10;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(394, 123);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(141, 20);
            this.password.TabIndex = 11;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(394, 94);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(141, 20);
            this.username.TabIndex = 12;
            // 
            // bton
            // 
            this.bton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(90)))), ((int)(((byte)(194)))));
            this.bton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.bton.ForeColor = System.Drawing.Color.White;
            this.bton.Location = new System.Drawing.Point(228, 298);
            this.bton.Name = "bton";
            this.bton.Size = new System.Drawing.Size(112, 46);
            this.bton.TabIndex = 13;
            this.bton.Text = "Register";
            this.bton.UseVisualStyleBackColor = false;
            this.bton.Click += new System.EventHandler(this.bton_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.panelRegister.Controls.Add(this.bton);
            this.panelRegister.Controls.Add(this.username);
            this.panelRegister.Controls.Add(this.password);
            this.panelRegister.Controls.Add(this.notlp);
            this.panelRegister.Controls.Add(this.email);
            this.panelRegister.Controls.Add(this.alamat);
            this.panelRegister.Controls.Add(this.nama);
            this.panelRegister.Controls.Add(this.label7);
            this.panelRegister.Controls.Add(this.label6);
            this.panelRegister.Controls.Add(this.label5);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Controls.Add(this.label2);
            this.panelRegister.Controls.Add(this.label1);
            this.panelRegister.Location = new System.Drawing.Point(20, 20);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(568, 356);
            this.panelRegister.TabIndex = 14;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(616, 405);
            this.Controls.Add(this.panelRegister);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(632, 444);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.RichTextBox alamat;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox notlp;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button bton;
        private System.Windows.Forms.Panel panelRegister;
    }
}