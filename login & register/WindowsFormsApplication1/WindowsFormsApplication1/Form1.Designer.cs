namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.txtNilai1 = new System.Windows.Forms.Label();
            this.txtNilai2 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tambah = new System.Windows.Forms.Button();
            this.Pengurangan = new System.Windows.Forms.Button();
            this.Perkalian = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNilai1
            // 
            this.txtNilai1.AutoSize = true;
            this.txtNilai1.Location = new System.Drawing.Point(91, 13);
            this.txtNilai1.Name = "txtNilai1";
            this.txtNilai1.Size = new System.Drawing.Size(36, 13);
            this.txtNilai1.TabIndex = 0;
            this.txtNilai1.Text = "Nilai 1";
            this.txtNilai1.Click += new System.EventHandler(this.Nilai1_Click);
            // 
            // txtNilai2
            // 
            this.txtNilai2.AutoSize = true;
            this.txtNilai2.Location = new System.Drawing.Point(91, 52);
            this.txtNilai2.Name = "txtNilai2";
            this.txtNilai2.Size = new System.Drawing.Size(36, 13);
            this.txtNilai2.TabIndex = 1;
            this.txtNilai2.Text = "Nilai 2";
            // 
            // txtHasil
            // 
            this.txtHasil.AutoSize = true;
            this.txtHasil.Location = new System.Drawing.Point(91, 91);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(30, 13);
            this.txtHasil.TabIndex = 2;
            this.txtHasil.Text = "Hasil";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(41, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtHasil);
            this.groupBox1.Controls.Add(this.txtNilai2);
            this.groupBox1.Controls.Add(this.txtNilai1);
            this.groupBox1.Location = new System.Drawing.Point(14, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 161);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kalkulator";
            // 
            // tambah
            // 
            this.tambah.Location = new System.Drawing.Point(41, 10);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(32, 25);
            this.tambah.TabIndex = 7;
            this.tambah.Text = "+";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // Pengurangan
            // 
            this.Pengurangan.Location = new System.Drawing.Point(79, 10);
            this.Pengurangan.Name = "Pengurangan";
            this.Pengurangan.Size = new System.Drawing.Size(32, 25);
            this.Pengurangan.TabIndex = 8;
            this.Pengurangan.Text = "-";
            this.Pengurangan.UseVisualStyleBackColor = true;
            this.Pengurangan.Click += new System.EventHandler(this.Pengurangan_Click);
            // 
            // Perkalian
            // 
            this.Perkalian.Location = new System.Drawing.Point(117, 10);
            this.Perkalian.Name = "Perkalian";
            this.Perkalian.Size = new System.Drawing.Size(32, 25);
            this.Perkalian.TabIndex = 9;
            this.Perkalian.Text = "x";
            this.Perkalian.UseVisualStyleBackColor = true;
            this.Perkalian.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(153, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 25);
            this.button4.TabIndex = 10;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(41, 46);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 25);
            this.button5.TabIndex = 11;
            this.button5.Text = "C";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.Perkalian);
            this.groupBox2.Controls.Add(this.Pengurangan);
            this.groupBox2.Controls.Add(this.tambah);
            this.groupBox2.Location = new System.Drawing.Point(14, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Proses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtNilai1;
        private System.Windows.Forms.Label txtNilai2;
        private System.Windows.Forms.Label txtHasil;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button Pengurangan;
        private System.Windows.Forms.Button Perkalian;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

