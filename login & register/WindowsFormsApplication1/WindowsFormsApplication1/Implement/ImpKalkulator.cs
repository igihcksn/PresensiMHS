using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ImpKalkulator:Interface.IntfKalkulator
    {
        public double Penjumlahan(Entity.EntKalkulator e)
        {
        return (e.GetNilai() + e.GetNilai2());
        }

        public double Pengurangan(Entity.EntKalkulator e)
        {
            return (e.GetNilai() - e.GetNilai2());
        }

        public double Perkalian(Entity.EntKalkulator e)
        {
            return (e.GetNilai() * e.GetNilai2());
        }

        public double Pembagian(Entity.EntKalkulator e)
        {
            return (e.GetNilai() + e.GetNilai2());
        }
}
}
