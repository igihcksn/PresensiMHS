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
   /* public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String query = "SELECT m.nama_matkul FROM dosen d INNER JOIN matakuliah m ON d.kode_matkul = m.kode_matkul";

            //execute

            while (DataTableReader.Read())
            {
                listBox1.Items.Add(reader.GetString(0).toString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String matkul = listBox1.SelectedItem().toString();
        }
    } */
}
