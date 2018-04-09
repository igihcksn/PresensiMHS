using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presensi.Entity
{
    class EntMateri
    {
        private string kelas;
        private string matakuliah;
        private string materi;

        private static String namaMatkul;

        public static void SeNamaMatkul(String matkul)
        {
            namaMatkul = matkul;
        }

        public static String GetNamaMatkul()
        {
            return namaMatkul;
        }

        public void SetKelas(string kls)
        {
            kelas = kls;
        }
        public string GetKelas()
        {
            return kelas;
        }

        public void SetMatakuliah(string matkul)
        {
            matakuliah = matkul;
        }
        public string GetMatakuliah()
        {
            return matakuliah;
        }

        public void SetMateri(string m)
        {
            materi = m;
        }
        public string GetMateri()
        {
            return materi;
        }
    }
}

