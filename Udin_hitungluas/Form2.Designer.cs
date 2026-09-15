namespace Udin_hitungluas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tSisi = new System.Windows.Forms.TextBox();
            this.bHitung = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LUAS PERSEGI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sisi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tSisi
            // 
            this.tSisi.Location = new System.Drawing.Point(320, 152);
            this.tSisi.Name = "tSisi";
            this.tSisi.Size = new System.Drawing.Size(169, 20);
            this.tSisi.TabIndex = 2;
            this.tSisi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bHitung
            // 
            this.bHitung.BackColor = System.Drawing.SystemColors.Menu;
            this.bHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHitung.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHitung.Location = new System.Drawing.Point(295, 222);
            this.bHitung.Name = "bHitung";
            this.bHitung.Size = new System.Drawing.Size(105, 40);
            this.bHitung.TabIndex = 3;
            this.bHitung.Text = "Hitung";
            this.bHitung.UseVisualStyleBackColor = false;
            this.bHitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Luas Persegi   = ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bHitung);
            this.Controls.Add(this.tSisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Hitung Luas Persegi";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tSisi;
        private System.Windows.Forms.Button bHitung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}