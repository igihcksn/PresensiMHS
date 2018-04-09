using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Login : Form
    {
        private SqlConnection connObj;

        public Login()
        {
            connObj = KoneksiDB.GetKoneksi();
            try //untuk eror handling agar tidak langsung close
            {
                connObj.Open();
                MessageBox.Show("Koneksi Sukses");
            }
            catch (SqlException se)
            {
                MessageBox.Show("Koneksi Gagal" + se);
            }

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlDataAdapter sda = new SqlDataAdapter("Select kode_dosen, nama, pass From DOSEN Where Nip='" + textBox1.Text + "' and Pass='" + textBox2.Text + "'", connObj);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Materi mm = new Materi();
                mm.Show();
                Entitas.EntitasDosen.SetKodeDosen(dt.Rows[0][0].ToString());
                Entitas.EntitasDosen.SetNamaDosen(dt.Rows[0][1].ToString());
            }
            else
            {
                MessageBox.Show("Please Check Your Nik or Pass");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Hide();
        }
    }
}
