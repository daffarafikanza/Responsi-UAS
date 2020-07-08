sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    public class Mahasiswa
    {
        public double nim { get; set; }
        public string nama { get; set; }
        public string jeniskelamin { get; set; }
        public double ipk { get; set; }
        public static void _mahasiswa(double _nim, string _nama, string _jeniskelamin, double _ipk);
    }
}
