using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IntfKalkulator
    {
        double Penjumlahan(Entity.EntKalkulator e);
        double Pengurangan(Entity.EntKalkulator e);
        double Perkalian(Entity.EntKalkulator e);
        double Pembagian(Entity.EntKalkulator e);
    }
}
