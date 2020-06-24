using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Polymorphsim, Inheritance, Abstraction & Collection";

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "145-456-789";
            karyawanTetap.Nama = "Huda keling";
            karyawanTetap.GajiBulanan = 4500000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "462-321-345";
            karyawanHarian.Nama = "Fira susi";
            karyawanHarian.JumlahJamKerja = 8;
            karyawanHarian.UpahPerJam = 20000;

            Sales sales = new Sales();
            sales.Nik = "789-765-432";
            sales.Nama = "Sekar Saraswati";
            sales.JumlahPenjualan = 50;
            sales.Komisi = 55000;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. Nik: {1}, Nama: {2}, Gaji: {3:N0}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
