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

namespace Presensi.View
{
    public partial class FrmMateri : Form
    {

        private Entity.EntMateri materi;
        private Entity.EntDosen dosen;
        private Interface.IntfDosen DosenDao;
        private Implement.ImpDosen impDosen = new Implement.ImpDosen();
        private SqlConnection koneksi;
        private string query; //
        private Boolean status; // untuk menyimpan return value
        private SqlDataReader reader;
        private SqlCommand command;

        public FrmMateri()
        {
            InitializeComponent();

            dosen = new Entity.EntDosen();
            DosenDao = Factory.Factory.GetDosenDao();

            lblNip.Text = Entity.EntDosen.GetNipSimpan();
            lblNama.Text = Entity.EntDosen.GetNamaSimpan();
            MessageBox.Show(Entity.EntDosen.GetNamaSimpan() + " - " + Entity.EntDosen.GetNipSimpan());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            materi = new Entity.EntMateri();
            //Entity.EntMateri push_materi = new Entity.EntMateri();
            //push_materi.SetKelas(comboBox1.Text);
            //push_materi.SetMateri(txtMateri.Text);
            //push_materi.SetMatakuliah(comboBox2.Text);
            
            try
            {
                materi.SetMatakuliah(comboBox2.Text.Substring(0, 1));
                materi.SetKelas(comboBox1.Text.Substring(0, 6));
                materi.SetMateri(txtMateri.Text);
                if (impDosen.InsertMateri(materi))
                {

                    this.Hide();
                    View.FrmPresensi frm = new View.FrmPresensi();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception)
            {
                txtMateri.Select();
                MessageBox.Show("Mohon Isi Materi");
            }
           
            

            

        }

        private void lblNama_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmMateri_Load(object sender, EventArgs e)
        {

        }

        private void lblNip_Click(object sender, EventArgs e)
        {

        }
    }
}
