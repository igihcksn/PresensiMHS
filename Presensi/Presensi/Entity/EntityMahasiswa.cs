using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presensi.Entity
{
    class EntityMahasiswa
    {
        private string nim,nama;
        public EntityMahasiswa()
        {

        }

        public EntityMahasiswa(string nim, string nama)
        {
            this.nim = nim;
            this.nama = nama;
        }

        public string Nama
        {
            get
            {
                return nama;
            }

            set
            {
                nama = value;
            }
        }

        public string Nim
        {
            get
            {
                return nim;
            }

            set
            {
                nim = value;
            }
        }
    }
}
