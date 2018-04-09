using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Presensi.Entity;

namespace Presensi.Implement
{
    class ImpDosen : Interface.IntfDosen
    {
        public Boolean cekloginDosen;
        private SqlConnection koneksi;
        private string query; //
        private Boolean status; // untuk menyimpan return value
        private SqlDataReader reader;
        private SqlCommand command;

        public ImpDosen()
        {
            koneksi = Koneksi.Koneksi.GetKoneksi(); // utk mengambil koneksi
        }

        public Boolean CekLoginDosen(string nip, string password)
        {
            query = " SELECT nip, nama, password FROM DOSEN nip WHERE nip = '" + nip + "' AND password = '" + password + "' ";

            koneksi.Open();

            SqlCommand command = koneksi.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.GetString(0).ToString() == nip && (reader.GetString(2).ToString() == password))
                {

                    status = true;
                    Entity.EntDosen.SetNipSimpan(reader.GetString(0));
                    Entity.EntDosen.SetNamaSimpan(reader.GetString(1));
                }
                else
                {
                    status = false;
                }
            }

            koneksi.Close();

            return status;
        }

        public DataSet SelectionDosen()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();

                query = "SELECT * FROM nip";
                command = new SqlCommand(query, koneksi);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();
                adapter.Fill(ds);

                koneksi.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine("ERROR" + se);
            }
            return ds;
        }

        Boolean InsertKelas(Entity.EntMateri em)
        {
            status = false;
            try
            {
                query = "INSERT INTO kode_kelas VALUES ('" + em.GetKelas() + "')";
                koneksi.Open();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine("ERROR" + se);
            }

            return status;
        }

        public Boolean SelectKelas(Entity.EntMateri em)
        {
            status = false;
            try
            {
                query = "SELECT kode_kelas FROM KELAS kode_kelas WHERE kode_kelas = '" + em.GetKelas() + "'";
                koneksi.Open();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine("ERROR" + se);
            }

            return status;
        }

        public Boolean SelectMatakuliah(Entity.EntMateri em)
        {
            status = false;
            try
            {
                query = "INSERT INTO Materi VALUES Kode_Matkul ('" + em.GetMatakuliah() + "')"; //'"+ em.GetMatakuliah() + "'
                koneksi.Open();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                //Entity.EntMateri.SeNamaMatkul(reader.GetString(1));
                koneksi.Close();
            }
            catch (SqlException se)
            {
                Console.WriteLine("ERROR" + se);
            }

            return status;
        }

        public Boolean InsertMateri(Entity.EntMateri em)
        {
            status = false;
            

            try
            {
                query = "INSERT INTO Materi VALUES Nama_Materi ('" + em.GetMateri() + "')";
                koneksi.Open();
                command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();



            }

            catch (SqlException se)
            {
                Console.WriteLine("ERROR" + se);
            }

            return status;
        }
    }

}
