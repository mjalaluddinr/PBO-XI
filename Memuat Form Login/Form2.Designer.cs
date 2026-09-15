namespace Memuat_Form_Login
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtAlamat = new System.Windows.Forms.RichTextBox();
            this.cbMenyanyi = new System.Windows.Forms.CheckBox();
            this.cbMemasak = new System.Windows.Forms.CheckBox();
            this.cbMainGame = new System.Windows.Forms.CheckBox();
            this.cbMembaca = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cAgama = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dTglLahir = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tTmptLahir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rPerempuan = new System.Windows.Forms.RadioButton();
            this.rLaki = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tNama = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGHasil = new System.Windows.Forms.DataGridView();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempatLahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TglLahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hobi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bSimpan = new System.Windows.Forms.Button();
            this.bHapus = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(298, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIODATA SISWA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.rtAlamat);
            this.groupBox1.Controls.Add(this.cbMenyanyi);
            this.groupBox1.Controls.Add(this.cbMemasak);
            this.groupBox1.Controls.Add(this.cbMainGame);
            this.groupBox1.Controls.Add(this.cbMembaca);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cAgama);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dTglLahir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tTmptLahir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rPerempuan);
            this.groupBox1.Controls.Add(this.rLaki);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tNama);
            this.groupBox1.Location = new System.Drawing.Point(9, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(254, 312);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Isi Biodata";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rtAlamat
            // 
            this.rtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtAlamat.Location = new System.Drawing.Point(100, 150);
            this.rtAlamat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtAlamat.Name = "rtAlamat";
            this.rtAlamat.Size = new System.Drawing.Size(147, 78);
            this.rtAlamat.TabIndex = 3;
            this.rtAlamat.Text = "";
            // 
            // cbMenyanyi
            // 
            this.cbMenyanyi.AutoSize = true;
            this.cbMenyanyi.Location = new System.Drawing.Point(176, 291);
            this.cbMenyanyi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMenyanyi.Name = "cbMenyanyi";
            this.cbMenyanyi.Size = new System.Drawing.Size(71, 17);
            this.cbMenyanyi.TabIndex = 13;
            this.cbMenyanyi.Text = "Menyanyi";
            this.cbMenyanyi.UseVisualStyleBackColor = true;
            this.cbMenyanyi.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cbMemasak
            // 
            this.cbMemasak.AutoSize = true;
            this.cbMemasak.Location = new System.Drawing.Point(100, 291);
            this.cbMemasak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMemasak.Name = "cbMemasak";
            this.cbMemasak.Size = new System.Drawing.Size(72, 17);
            this.cbMemasak.TabIndex = 12;
            this.cbMemasak.Text = "Memasak";
            this.cbMemasak.UseVisualStyleBackColor = true;
            // 
            // cbMainGame
            // 
            this.cbMainGame.AutoSize = true;
            this.cbMainGame.Location = new System.Drawing.Point(176, 264);
            this.cbMainGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMainGame.Name = "cbMainGame";
            this.cbMainGame.Size = new System.Drawing.Size(80, 17);
            this.cbMainGame.TabIndex = 11;
            this.cbMainGame.Text = "Main Game";
            this.cbMainGame.UseVisualStyleBackColor = true;
            // 
            // cbMembaca
            // 
            this.cbMembaca.AutoSize = true;
            this.cbMembaca.Location = new System.Drawing.Point(100, 266);
            this.cbMembaca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMembaca.Name = "cbMembaca";
            this.cbMembaca.Size = new System.Drawing.Size(73, 17);
            this.cbMembaca.TabIndex = 3;
            this.cbMembaca.Text = "Membaca";
            this.cbMembaca.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 267);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Hobi :";
            // 
            // cAgama
            // 
            this.cAgama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cAgama.FormattingEnabled = true;
            this.cAgama.Items.AddRange(new object[] {
            "Islam",
            "Kristen Katolik",
            "Kristen Protestan",
            "Hindu",
            "Budha",
            "Konghucu"});
            this.cAgama.Location = new System.Drawing.Point(100, 236);
            this.cAgama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cAgama.Name = "cAgama";
            this.cAgama.Size = new System.Drawing.Size(148, 21);
            this.cAgama.TabIndex = 3;
            this.cAgama.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Agama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Alamat :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dTglLahir
            // 
            this.dTglLahir.Checked = false;
            this.dTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTglLahir.Location = new System.Drawing.Point(100, 119);
            this.dTglLahir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dTglLahir.Name = "dTglLahir";
            this.dTglLahir.Size = new System.Drawing.Size(151, 20);
            this.dTglLahir.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tanggal Lahir :";
            // 
            // tTmptLahir
            // 
            this.tTmptLahir.Location = new System.Drawing.Point(100, 92);
            this.tTmptLahir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tTmptLahir.Name = "tTmptLahir";
            this.tTmptLahir.Size = new System.Drawing.Size(148, 20);
            this.tTmptLahir.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tempat Lahir :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // rPerempuan
            // 
            this.rPerempuan.AutoSize = true;
            this.rPerempuan.Location = new System.Drawing.Point(100, 69);
            this.rPerempuan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rPerempuan.Name = "rPerempuan";
            this.rPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rPerempuan.TabIndex = 3;
            this.rPerempuan.TabStop = true;
            this.rPerempuan.Text = "Perempuan";
            this.rPerempuan.UseVisualStyleBackColor = true;
            // 
            // rLaki
            // 
            this.rLaki.AutoSize = true;
            this.rLaki.Location = new System.Drawing.Point(100, 48);
            this.rLaki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rLaki.Name = "rLaki";
            this.rLaki.Size = new System.Drawing.Size(64, 17);
            this.rLaki.TabIndex = 2;
            this.rLaki.TabStop = true;
            this.rLaki.Text = "Laki-laki";
            this.rLaki.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tNama
            // 
            this.tNama.Location = new System.Drawing.Point(100, 20);
            this.tNama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tNama.Name = "tNama";
            this.tNama.Size = new System.Drawing.Size(148, 20);
            this.tNama.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox2.Controls.Add(this.dGHasil);
            this.groupBox2.Location = new System.Drawing.Point(268, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(523, 265);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasil";
            // 
            // dGHasil
            // 
            this.dGHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGHasil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nama,
            this.Jk,
            this.TempatLahir,
            this.TglLahir,
            this.Alamat,
            this.Agama,
            this.Hobi});
            this.dGHasil.Location = new System.Drawing.Point(12, 17);
            this.dGHasil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGHasil.Name = "dGHasil";
            this.dGHasil.RowHeadersWidth = 51;
            this.dGHasil.RowTemplate.Height = 24;
            this.dGHasil.Size = new System.Drawing.Size(503, 235);
            this.dGHasil.TabIndex = 0;
            this.dGHasil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGHasil_CellContentClick);
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.Width = 125;
            // 
            // Jk
            // 
            this.Jk.HeaderText = "Jenis Kelamin";
            this.Jk.MinimumWidth = 6;
            this.Jk.Name = "Jk";
            this.Jk.Width = 125;
            // 
            // TempatLahir
            // 
            this.TempatLahir.HeaderText = "Tempat Lahir";
            this.TempatLahir.MinimumWidth = 6;
            this.TempatLahir.Name = "TempatLahir";
            this.TempatLahir.Width = 125;
            // 
            // TglLahir
            // 
            this.TglLahir.HeaderText = "Tanggal Lahir";
            this.TglLahir.MinimumWidth = 6;
            this.TglLahir.Name = "TglLahir";
            this.TglLahir.Width = 125;
            // 
            // Alamat
            // 
            this.Alamat.HeaderText = "Alamat";
            this.Alamat.MinimumWidth = 6;
            this.Alamat.Name = "Alamat";
            this.Alamat.Width = 125;
            // 
            // Agama
            // 
            this.Agama.HeaderText = "Agama";
            this.Agama.MinimumWidth = 6;
            this.Agama.Name = "Agama";
            this.Agama.Width = 125;
            // 
            // Hobi
            // 
            this.Hobi.HeaderText = "Hobi";
            this.Hobi.MinimumWidth = 6;
            this.Hobi.Name = "Hobi";
            this.Hobi.Width = 125;
            // 
            // bSimpan
            // 
            this.bSimpan.BackColor = System.Drawing.Color.SpringGreen;
            this.bSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSimpan.Location = new System.Drawing.Point(314, 328);
            this.bSimpan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bSimpan.Name = "bSimpan";
            this.bSimpan.Size = new System.Drawing.Size(68, 23);
            this.bSimpan.TabIndex = 4;
            this.bSimpan.Text = "SIMPAN";
            this.bSimpan.UseVisualStyleBackColor = false;
            this.bSimpan.Click += new System.EventHandler(this.bSimpan_Click);
            // 
            // bHapus
            // 
            this.bHapus.BackColor = System.Drawing.Color.Red;
            this.bHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHapus.Location = new System.Drawing.Point(485, 328);
            this.bHapus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bHapus.Name = "bHapus";
            this.bHapus.Size = new System.Drawing.Size(68, 23);
            this.bHapus.TabIndex = 5;
            this.bHapus.Text = "HAPUS";
            this.bHapus.UseVisualStyleBackColor = false;
            this.bHapus.Click += new System.EventHandler(this.bHapus_Click);
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Yellow;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Location = new System.Drawing.Point(664, 328);
            this.bExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(68, 23);
            this.bExit.TabIndex = 6;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 366);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bHapus);
            this.Controls.Add(this.bSimpan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Biodata";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGHasil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rLaki;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rPerempuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dTglLahir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tTmptLahir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cAgama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbMenyanyi;
        private System.Windows.Forms.CheckBox cbMemasak;
        private System.Windows.Forms.CheckBox cbMainGame;
        private System.Windows.Forms.CheckBox cbMembaca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtAlamat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGHasil;
        private System.Windows.Forms.Button bSimpan;
        private System.Windows.Forms.Button bHapus;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jk;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempatLahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn TglLahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hobi;
    }
}