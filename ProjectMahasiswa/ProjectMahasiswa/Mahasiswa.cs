using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    public class Mahasiswa
    {
        public static int nim { get; set; }
        public string nama { get; set; }
        public string jeniskelamin { get; set; }
        public int ipk { get; set; }
        public static void _mahasiswa(double _nim, double _nama, double _jeniskelamin, double _ipk);
    }
}
