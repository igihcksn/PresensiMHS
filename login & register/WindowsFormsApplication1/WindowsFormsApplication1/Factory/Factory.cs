using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Factory
    {
        private static Interface.IntfKalkulator kalkulatorDao ;

        public static Interface.IntfKalkulator GetKalkulatorDao()
        {
            kalkulatorDao = new Implement.ImpKalkulator();
            return kalkulatorDao;
        }
    }
}
