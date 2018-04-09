using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Presensi.Implement
{
    class ImpMahasiswa :Interface.IntfMahasiswa
    {
        Boolean status;
        public Boolean Getdata(Entity.EntityMahasiswa EM, string nim)
        {

            using (SqlConnection con = new SqlConnection("Data Source=IGIHCKSN\\SQLEXPRESS;Initial Catalog=Fp_PRESENSI;Integrated Security=True "))
            {

                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT NIM,NAMA FROM MAHASISWA where NIM = '" + nim + "'", con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                EM.Nim = reader["NIM"].ToString();
                                EM.Nama = reader["NAMA"].ToString();
                                
                            }
                            status = true;
                        }
                        else
                        {
                            status =  false;
                        }
                        reader.Close();

                    } // reader closed and disposed up here

                } // command disposed here
                con.Close();
            }
            nim = "";
            return status;
        }
    }
}
