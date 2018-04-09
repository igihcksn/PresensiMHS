using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presensi.Entity
{
    class EntDosen
    {
        private string nipDosen;
        private string namaDosen;
        private string passwordDosen;

        private static String nipSimpan;
        private static String namaSimpan;

        public static void SetNipSimpan(String nip)
        {
            nipSimpan = nip;
        }

        public static void SetNamaSimpan(String nama)
        {
            namaSimpan = nama;
        }

        public static String GetNipSimpan()
        {
            return nipSimpan;
        }

        public static String GetNamaSimpan()
        {
            return namaSimpan;
        }

        public void SetNipDosen(string nip)
        {
            nipDosen = nip;
        }
        public string GetKodeDosen()
        {
            return nipDosen;
        }

        public void SetNamaDosen(string nama)
        {
            namaDosen = nama;
        }
        public string GetNamaDosen()
        {
            return namaDosen;
        }

        public void SetPasswordDosen(string password)
        {
            passwordDosen = password;
        }
        public string GetPassword()
        {
            return passwordDosen;
        }

       
        
    }
}

