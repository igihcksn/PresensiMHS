namespace Presensi.View
{
    partial class FrmPresensi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresensi));
            this.lblMatkul = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dgvPresensi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresensi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatkul
            // 
            this.lblMatkul.AutoSize = true;
            this.lblMatkul.BackColor = System.Drawing.Color.Transparent;
            this.lblMatkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkul.Location = new System.Drawing.Point(353, 63);
            this.lblMatkul.Name = "lblMatkul";
            this.lblMatkul.Size = new System.Drawing.Size(107, 33);
            this.lblMatkul.TabIndex = 0;
            this.lblMatkul.Text = "Matkul";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Location = new System.Drawing.Point(48, 151);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(249, 29);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // dgvPresensi
            // 
            this.dgvPresensi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPresensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresensi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPresensi.Location = new System.Drawing.Point(410, 153);
            this.dgvPresensi.Name = "dgvPresensi";
            this.dgvPresensi.Size = new System.Drawing.Size(356, 283);
            this.dgvPresensi.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NIM";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NAMA";
            this.Column2.Name = "Column2";
            // 
            // FrmPresensi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvPresensi);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMatkul);
            this.Name = "FrmPresensi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPresensi";
            this.Load += new System.EventHandler(this.FrmPresensi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresensi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatkul;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvPresensi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}