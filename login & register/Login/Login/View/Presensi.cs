using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Presensi : Form
    {
        public Presensi()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listAbsensi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void listAbsensi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //refres data & get data
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //ambil tex dari text box, simpen ke variable, masukin ke database
            //select ke database


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
