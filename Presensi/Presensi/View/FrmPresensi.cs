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
    public partial class FrmPresensi : Form
    {
        private Entity.EntMateri materi;
        private Entity.EntityMahasiswa mhs;
        private Interface.IntfMahasiswa imhs;
        public FrmPresensi()
        {
            InitializeComponent();
            imhs = Factory.Factory.GetMahasiswaDao();
            lblMatkul.Text = Entity.EntMateri.GetNamaMatkul();
            MessageBox.Show(Entity.EntMateri.GetNamaMatkul());

              
        }

        private void rep_bind()
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmPresensi_Load(object sender, EventArgs e)
        {

        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            mhs = new Entity.EntityMahasiswa();
            if (e.KeyCode == Keys.Enter)
            {
                if(imhs.Getdata(mhs,txtID.Text) == true)
                {
                    string[] row = new string[] { mhs.Nim, mhs.Nama };
                    dgvPresensi.Rows.Add(row);
                    txtID.Text="";
                    txtID.Select();
                }
                else
                {
                    MessageBox.Show("NIM TIDAK ADA");
                    txtID.Text = "";
                    txtID.Select();
                }
             
            }
        }
    }
}
