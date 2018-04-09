using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Entity.EntKalkulator kalkulator;
        private Interface.IntfKalkulator kalkulatorDao;

        public Form1()
        {
            kalkulatorDao = Factory.GetKalkulatorDao();

            InitializeComponent();
        }

        private void Nilai1_Click(object sender, EventArgs e)
        {

        }

        private void tambah_Click(object sender, EventArgs e)
        {
            //input
            kalkulator = new Entity.EntKalkulator();
            kalkulator.SetNilai1(double.Parse(txtNilai1.Text));
            kalkulator.SetNilai1(double.Parse(txtNilai2.Text));
            //output
            txtHasil.Text = kalkulatorDao.Pengurangan(kalkulator).ToString();

        }

        private void Pengurangan_Click(object sender, EventArgs e)
        {
            //input
            kalkulator = new Entity.EntKalkulator();
            kalkulator.SetNilai1(double.Parse(txtNilai1.Text));
            kalkulator.SetNilai1(double.Parse(txtNilai2.Text));
            //output
            txtHasil.Text = kalkulatorDao.Pengurangan(kalkulator).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //input
            kalkulator = new Entity.EntKalkulator();
            kalkulator.SetNilai1(double.Parse(txtNilai1.Text));
            kalkulator.SetNilai1(double.Parse(txtNilai2.Text));
            //output
            txtHasil.Text = kalkulatorDao.Perkalian(kalkulator).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //input
            kalkulator = new Entity.EntKalkulator();
            kalkulator.SetNilai1(double.Parse(txtNilai1.Text));
            kalkulator.SetNilai1(double.Parse(txtNilai2.Text));
            //output
            txtHasil.Text = kalkulatorDao.Pembagian(kalkulator).ToString();
        }
    }
}
