using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Write("\nPilih Menu Aplikasi");
            Console.WriteLine();
            Console.Write("\n1. Tambah Mahasiswa");
            Console.Write("\n2. Hapus Mahasiswa");
            Console.Write("\n3. Edit Mahasiswa");
            Console.Write("\n4. Tampilkan Mahasiswa");
            Console.WriteLine();
            Console.Write("\nNomor Menu [1..4]: ");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Console.WriteLine("Tambah Data Mahasiswa");
            Console.Write("NIM\t: ");
            double _nim = double.Parse(Console.ReadLine());
            Console.Write("Nama\t: ");
            double _nama = double.Parse(Console.ReadLine());
            Console.Write("Jenis Kelamain [L/P]\t: ");
            double _jeniskelamin = double.Parse(Console.ReadLine());
            Console.Write("IPK\t: ");
            double _ipk = double.Parse(Console.ReadLine());
            Console.Write("Tekan ENTER untuk kembali ke menu");
            
            _mahasiswa(_nim,_nama,_jeniskelamin,_ipk);

            Console.ReadKey();
        }

private static void _mahasiswa(double _nim,double _nama,double _jeniskelamin,double _ipk)
{
 	throw new NotImplementedException();
}

        static void HapusMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            Console.WriteLine("\n");
            Console.Write("Masukkan NIM Mahasiswa");
            double _pilnim = double.Parse(Console.ReadLine());
            bool chek = false;
            for(int i = 0; i < daftarMahasiswa.Count; i++)
            {
                if(daftarMahasiswa[i].nim == _pilnim)
                {
                    var hapus = daftarMahasiswa.Single(r => r.nim == _pilnim);
                    Console.Write("Data mahasiswa berhasil di hapus");
                    Console.Write("NIM\t\t: " + hapus.nim);
                    Console.Write("Nama\t: " + hapus.nama);
                    Console.Write("Jenis Kelamin\t: " + hapus.jeniskelamin);
                    Console.Write("IPK\t: " + hapus.ipk);

                    daftarMahasiswa.Remove(hapus);
                    chek = true;
                    Console.Write("Apakah yakin ingin menghapus data??[Tekan y/n} : ");
                    char lanjut = char.Parse(Console.ReadLine());
                    if (lanjut == 'y' || lanjut == 'y')
                    {
                        daftarMahasiswa.Remove(hapus);
                        Console.WriteLine("Data Mahasiswa berhasil dihapus");
                    }
                    else
                    {
                        Console.WriteLine("Data Mahasiswa gagal dihapus");
                    }
                    chek = true;
                }
                if(!chek)
                {
                   Console.WriteLine("NIM tidak ditemukan");
                }
            }
                    Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
                    Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            int nomorUrut = 1;
            foreach(Mahasiswa mahasiswa in daftarMahasiswa)
            {
                Console.WriteLine("NO.{0}" + " " + "NIM.{1}" + "\t" + "Nama : {2}" + "\t"+" kelamin : {3}"+"\t"+" IPK : {4}",
                     nomorUrut, mahasiswa.nim, mahasiswa.nama, mahasiswa.jeniskelamin, mahasiswa.ipk);
                nomorUrut++;
            }

              static void _mahasiswa(double _NIM, string _Nama, string _Jeniskelamin,double _IPK)
            {
              daftarMahasiswa.Add(new Mahasiswa {nim = _NIM,nama = _Nama,jeniskelamin = _Jeniskelamin,ipk = _IPK });
            }
        }
}
