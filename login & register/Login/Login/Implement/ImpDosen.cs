using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Login.Implement
{
    class ImpDosen
    {
        public Boolean CekloginDosen;
        private SqlConnection koneksi;
        private string query; //
        private Boolean status; // untuk menyimpan return value
        private SqlDataReader reader;
        private SqlCommand command;
    }
}
