using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Login
{
    class KoneksiDB
    {
        private static SqlConnection koneksi;

        public static SqlConnection GetKoneksi() //karena koneksi private jadi harus di get
        {
            koneksi = new SqlConnection(); //proses instan
            koneksi.ConnectionString = " Data Source=IGIHCKSN\\SQLEXPRESS;Initial Catalog=FpPresensi;Integrated Security=True "; //menghubungkan aplikasi dengan database (tambah / satu)
            return koneksi;
        }
    }
}
