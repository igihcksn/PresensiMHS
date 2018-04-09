namespace Presensi.View
{
    partial class FrmMateri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMateri));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtMateri = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "151101 - S1TI-01",
            "151102 - S1TI-02",
            "151103 - S1TI-03",
            "151104 - S1TI-04",
            "151105 - S1TI-05",
            "151106 - S1TI-06",
            "151107 - S1TI-07",
            "151108 - S1TI-08",
            "151109 - S1TI-09",
            "151110 - S1TI-10",
            "151111 - S1TI-11",
            "151112 - S1TI-12",
            "151113 - S1TI-13"});
            this.comboBox1.Location = new System.Drawing.Point(101, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Text = "Kelas";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0 - Sistem Basis Data",
            "1 - Pemograman Lanjut",
            "2- Multimedia",
            "3- Hardware & Software",
            "4- Komputer Grafis",
            "5- Interaksi Manusia & Komputer"});
            this.comboBox2.Location = new System.Drawing.Point(101, 293);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(185, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.Text = "Matakuliah";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Location = new System.Drawing.Point(442, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(267, 26);
            this.button5.TabIndex = 17;
            this.button5.Text = "Submit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtMateri
            // 
            this.txtMateri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMateri.Location = new System.Drawing.Point(441, 227);
            this.txtMateri.Multiline = true;
            this.txtMateri.Name = "txtMateri";
            this.txtMateri.Size = new System.Drawing.Size(320, 84);
            this.txtMateri.TabIndex = 16;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.BackColor = System.Drawing.Color.Transparent;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(208, 78);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(316, 55);
            this.lblNama.TabIndex = 21;
            this.lblNama.Text = "Nama Dosen";
            this.lblNama.Click += new System.EventHandler(this.lblNama_Click);
            // 
            // lblNip
            // 
            this.lblNip.AutoSize = true;
            this.lblNip.BackColor = System.Drawing.Color.Transparent;
            this.lblNip.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNip.Location = new System.Drawing.Point(369, 133);
            this.lblNip.Name = "lblNip";
            this.lblNip.Size = new System.Drawing.Size(151, 33);
            this.lblNip.TabIndex = 22;
            this.lblNip.Text = "Nip Dosen";
            this.lblNip.Click += new System.EventHandler(this.lblNip_Click);
            // 
            // FrmMateri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblNip);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtMateri);
            this.Name = "FrmMateri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMateri";
            this.Load += new System.EventHandler(this.FrmMateri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtMateri;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNip;
    }
}