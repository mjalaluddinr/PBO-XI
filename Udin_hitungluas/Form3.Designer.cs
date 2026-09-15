namespace Udin_hitungluas
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tPanjang = new System.Windows.Forms.TextBox();
            this.bHitung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tLebar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(240, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "LUAS PERSEGI PANJANG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(265, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Panjang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tPanjang
            // 
            this.tPanjang.Location = new System.Drawing.Point(365, 129);
            this.tPanjang.Name = "tPanjang";
            this.tPanjang.Size = new System.Drawing.Size(169, 20);
            this.tPanjang.TabIndex = 4;
            // 
            // bHitung
            // 
            this.bHitung.BackColor = System.Drawing.SystemColors.Menu;
            this.bHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHitung.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHitung.ForeColor = System.Drawing.Color.Black;
            this.bHitung.Location = new System.Drawing.Point(324, 234);
            this.bHitung.Name = "bHitung";
            this.bHitung.Size = new System.Drawing.Size(105, 40);
            this.bHitung.TabIndex = 5;
            this.bHitung.Text = "Hitung";
            this.bHitung.UseVisualStyleBackColor = false;
            this.bHitung.Click += new System.EventHandler(this.bHitung_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(259, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Luas Persegi   Panjang = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(479, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(265, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lebar";
            // 
            // tLebar
            // 
            this.tLebar.Location = new System.Drawing.Point(365, 172);
            this.tLebar.Name = "tLebar";
            this.tLebar.Size = new System.Drawing.Size(169, 20);
            this.tLebar.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tLebar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bHitung);
            this.Controls.Add(this.tPanjang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Pink;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Hitung Luas Persegi Panjang";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tPanjang;
        private System.Windows.Forms.Button bHitung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tLebar;
    }
}