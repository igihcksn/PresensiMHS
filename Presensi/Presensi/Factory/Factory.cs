using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presensi.Factory
{
    class Factory
    {
        private static Interface.IntfDosen DosenDao;

        public static Interface.IntfDosen GetDosenDao()
        {
            DosenDao = new Implement.ImpDosen();
            return DosenDao;
        }
        private static Interface.IntfMahasiswa MahasiswaDao;

        public static Interface.IntfMahasiswa GetMahasiswaDao()
        {
            MahasiswaDao = new Implement.ImpMahasiswa();
            return MahasiswaDao;
        }
    }
}
