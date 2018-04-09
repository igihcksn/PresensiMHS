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
    public partial class Materi : Form
    {
        //SqlCommand cmd;
        //SqlConnection con;
        //SqlDataAdapter da;
        private Entitas.EntitasDosen dosen;

        public Materi()
        {
            InitializeComponent();
            lblKode.Text = Entitas.EntitasDosen.GetKodeDosen();
            lblKode.Text = Entitas.EntitasDosen.GetNamaDosen();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Materi_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // con = new SqlConnection(" Data Source=IGIHCKSN\\SQLEXPRESS;Initial Catalog=FpPresensi;Integrated Security=True ");
            
            //cmd = new SqlCommand("INSERT INTO MATAKULIAH VALUES (@KODE_MATKUL, @NAMA_MATKUL, @JUMLAH_SKS, @MATERI) ", con); //INSERT INTO KELAS VALUES (@KODE_KELAS)
            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("@KODE_MATKUL", comboBox4.Text);
            //cmd.Parameters.AddWithValue("@NAMA_MATKUL", comboBox2.Text);
            //cmd.Parameters.AddWithValue("@JUMLAH_SKS", comboBox3.Text);
            //cmd.Parameters.AddWithValue("@MATERI", textBox3.Text);
            //cmd.Parameters.AddWithValue("@KODE_KELAS", comboBox1.Text);
            //cmd.Connection = con;
            //con.Open();
            //cmd.ExecuteNonQuery();

            //if (comboBox2 = 'Kalkulus') {

            
               this.Hide();
                Presensi pr = new Presensi();
                pr.Show();
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //con = new SqlConnection(" Data Source=IGIHCKSN\\SQLEXPRESS;Initial Catalog=FpPresensi;Integrated Security=True ");

            //cmd = new SqlCommand("SELECT * From MATAKULIAH ", con);
            //cmd.Connection = con;
            //con.Open();
            //cmd.ExecuteNonQuery();
        }
    }
}
