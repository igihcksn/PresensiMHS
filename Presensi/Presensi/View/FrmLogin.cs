using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presensi.View
{
    public partial class FrmLogin : Form
    {
        private Entity.EntDosen Dosen;
        private Interface.IntfDosen DosenDao;

        public FrmLogin()
        {
            DosenDao = Factory.Factory.GetDosenDao();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtNip.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Kode & Password Harus di isi !");
            }
            else
            {
                Boolean status = DosenDao.CekLoginDosen(txtNip.Text, txtPass.Text);

                if (status == true)
                {
                    this.Hide();
                    View.FrmMateri frm = new View.FrmMateri();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Maaf Login Gagal");
                    txtNip.Text = "";
                    txtPass.Text = "";
                    txtNip.Focus();
                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
