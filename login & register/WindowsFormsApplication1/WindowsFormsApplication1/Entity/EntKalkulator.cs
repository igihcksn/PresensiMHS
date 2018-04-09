using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class EntKalkulator
    {
        private double Nilai1;
        private double Nilai2;

        public void SetNilai1(double n1)
        {
            Nilai1 = n1;
        }

        public double GetNilai()
        {
            return Nilai1;
        }

        public void SetNilai2(double n2)
        {
            Nilai2 = n2;
        }

        public double GetNilai2()
        {
            return Nilai2;
        }
    }
}
