using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Entitas
{
    class EntitasDosen
    {
        private static string kodeDosen;
        private static string namaDosen;
        private static string passD;

        public static void SetKodeDosen(string kode)
        {
            kodeDosen = kode;
        }
        public static void SetNamaDosen(string kode)
        {
            namaDosen = kode;
        }
        public static string GetKodeDosen()
        {
            return kodeDosen;
        }
        public static string GetNamaDosen()
        {
            return namaDosen;
        }

        public static string SetPassD(string pass)
        {
            passD = pass;
        }
        public static string GetPassD()
        {
            return passD;
        }
    }
}
