namespace perpustakaan
{
    partial class Login
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
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.bRegister = new System.Windows.Forms.Button();
            this.bSignIn = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(74)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(229, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(92, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(92, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.label4.Location = new System.Drawing.Point(108, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Belum punya akun?";
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(188, 103);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(180, 20);
            this.tUsername.TabIndex = 4;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(188, 162);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(180, 20);
            this.tPassword.TabIndex = 5;
            // 
            // bRegister
            // 
            this.bRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.bRegister.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.bRegister.Location = new System.Drawing.Point(244, 211);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(81, 27);
            this.bRegister.TabIndex = 6;
            this.bRegister.Text = "Register";
            this.bRegister.UseVisualStyleBackColor = false;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // bSignIn
            // 
            this.bSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(90)))), ((int)(((byte)(194)))));
            this.bSignIn.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.bSignIn.ForeColor = System.Drawing.Color.White;
            this.bSignIn.Location = new System.Drawing.Point(95, 260);
            this.bSignIn.Name = "bSignIn";
            this.bSignIn.Size = new System.Drawing.Size(110, 50);
            this.bSignIn.TabIndex = 7;
            this.bSignIn.Text = "Sign In";
            this.bSignIn.UseVisualStyleBackColor = false;
            this.bSignIn.Click += new System.EventHandler(this.bSignIn_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            this.bCancel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.bCancel.Location = new System.Drawing.Point(255, 260);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(110, 50);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.panelLogin.Controls.Add(this.bCancel);
            this.panelLogin.Controls.Add(this.bSignIn);
            this.panelLogin.Controls.Add(this.bRegister);
            this.panelLogin.Controls.Add(this.tPassword);
            this.panelLogin.Controls.Add(this.tUsername);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Controls.Add(this.label3);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(28, 20);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(560, 340);
            this.panelLogin.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(616, 405);
            this.Controls.Add(this.panelLogin);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(632, 444);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.Button bSignIn;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Panel panelLogin;
    }
}