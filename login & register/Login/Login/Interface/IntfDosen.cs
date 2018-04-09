using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Login.Interface
{
    class IntfDosen
    {
        Boolean CekLoginDosen(string nip, string pass);

        DataSet SelectionDosen();
    }
}
