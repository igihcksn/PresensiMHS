using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Presensi.Interface
{
    interface IntfDosen
    {
        //validasi login
        Boolean CekLoginDosen(string nip, string password);

        //select
        DataSet SelectionDosen();

        // string KodeStaffBaru();

        //insert kelas lewat combo box
        Boolean SelectKelas(Entity.EntMateri em);

        //insert matkul lewat combo box
        Boolean SelectMatakuliah(Entity.EntMateri em);

        //insert materi
        Boolean InsertMateri(Entity.EntMateri em);
    }
}
