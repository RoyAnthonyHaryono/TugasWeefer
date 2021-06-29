using System;
using System.Collections.Generic;

namespace Calculator_Luas_bangunan_datar
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Selamat Datang di aplikasi Calculator luas bangunan datar");
                bool forloop = true;
                while (forloop == true)
              {
                Console.WriteLine("Luas bangunan apa yang kalian mau hitung? (segitiga, persegi, trapesium, lingkaran)");
                Console.WriteLine("Tekan angka 1 untuk segitiga");
                Console.WriteLine("Tekan angka 2 untuk persegi");
                Console.WriteLine("Tekan angka 3 untuk trapesium");
                Console.WriteLine("Tekan angka 4 untuk lingkaran");
                Console.WriteLine("Tekan angka 5 untuk keluar");
                int bangunandatar;
                bool valid = (int.TryParse(Console.ReadLine(), out bangunandatar));
                while (!valid)
                {
                    Console.WriteLine("tolong hanya isikan angka");
                    valid = int.TryParse(Console.ReadLine(), out bangunandatar);
                }
                if (bangunandatar == 1)
                {
                    Console.WriteLine("Tolong gunakan tanda koma untuk angka desimal!");
                    Console.WriteLine("Tolong masukkan ukuran alas segitiga");                  
                    double alas;
                    bool berhasil = (double.TryParse(Console.ReadLine(), out alas));
                    while (!berhasil)
                    {
                        Console.WriteLine("Tolong hanya masukkan angka saja");
                        berhasil = (double.TryParse(Console.ReadLine(), out alas));
                    }
                    Console.WriteLine("Tolong masukkan ukuran tinggi segitiga");                   
                    double tinggi;
                    bool berhasil1 = (double.TryParse(Console.ReadLine(), out tinggi));
                    while (!berhasil1)
                    {
                        Console.WriteLine("Tolong Hanya masukkan angka saja");
                        berhasil1 = (double.TryParse(Console.ReadLine(), out tinggi));
                    }    
                    double hasilsegitiga = alas * tinggi / 2;
                    Console.WriteLine("Hasil= " + hasilsegitiga + " satuan");
                    Console.WriteLine("Terima kasih sudah menggunakan aplikasi kami");
                }
                if (bangunandatar == 2)
                {
                    Console.WriteLine("Tolong gunakan tanda koma untuk angka desimal!");
                    Console.WriteLine("Tolong masukkan ukuran panjang persegi");                   
                    double panjang;
                    bool berhasil = (double.TryParse(Console.ReadLine(), out panjang));
                    while (!berhasil)
                    {
                        Console.WriteLine("Tolong Hanya masukkan angka saja");
                        berhasil = (double.TryParse(Console.ReadLine(), out panjang));
                    }
                    Console.WriteLine("Tolong masukkan ukuran lebar persegi");                   
                    double lebar;
                    bool berhasil1 = (double.TryParse(Console.ReadLine(), out lebar));
                    while (!berhasil1)
                    {
                        Console.WriteLine("Tolong Hanya masukkan angka saja");
                        berhasil1 = (double.TryParse(Console.ReadLine(), out lebar));
                    }                   
                    double hasilpersegi = panjang * lebar;
                    Console.WriteLine("Hasil= " + hasilpersegi + " satuan");
                    Console.WriteLine("Terima kasih sudah menggunakan aplikasi kami");
                }
                if (bangunandatar == 3)
                {
                    Console.WriteLine("Tolong gunakan tanda koma untuk angka desimal!");
                    Console.WriteLine("Tolong masukkan ukuran alas A trapesium");
                    double alasA;
                    bool berhasil = (double.TryParse(Console.ReadLine(), out alasA));
                    while (!berhasil)
                    {
                        Console.WriteLine("Tolong Hanya masukkan angka saja");
                        berhasil = (double.TryParse(Console.ReadLine(), out alasA));
                    }
                    Console.WriteLine("Tolong masukkan ukuran alas B trapesium");                   
                    double alasB;
                    bool berhasil1 = (double.TryParse(Console.ReadLine(), out alasB));
                    while (!berhasil1)
                    {
                        Console.WriteLine("Tolong Hanya masukkan angka saja");
                        berhasil1 = (double.TryParse(Console.ReadLine(), out alasB));
                    }                   
                    Console.WriteLine("Tolong masukkan ukuran tinggi trapesium");
                    double tinggi;
                    bool berhasil2 = (double.TryParse(Console.ReadLine(), out tinggi));
                    while (!berhasil2)
                    {
                        Console.WriteLine("Tolong Hanya masukkan angka saja");
                        berhasil2 = (double.TryParse(Console.ReadLine(), out tinggi));
                    }
                    double alastotal = alasA + alasB;
                    double hasiltrapesium = alastotal * tinggi / 2;
                    Console.WriteLine("Hasil= " + hasiltrapesium + " satuan");
                    Console.WriteLine("Terima kasih sudah menggunakan aplikasi kami");
                }
                if (bangunandatar == 4)
                {
                    Console.WriteLine("Tolong gunakan tanda koma untuk angka desimal!");
                    Console.WriteLine("Tolong masukkan ukuran jari-jari lingkaran");
                    double jari2;
                    bool berhasil = (double.TryParse(Console.ReadLine(), out jari2));
                    while (!berhasil)
                    {
                        Console.WriteLine("Tolong Hanya masukkan angka saja");
                        berhasil = (double.TryParse(Console.ReadLine(), out jari2));
                    }
                    double pi = 3.14;
                    double hasillingkaran = pi * jari2 * jari2;
                    Console.WriteLine("Hasil= " + hasillingkaran + " satuan");
                    Console.WriteLine("Terima kasih sudah menggunakan aplikasi kami");
                }
          
                if (bangunandatar == 5)
                {
                    forloop = false;
                    Console.WriteLine("Terima kasih sudah menggunakan aplikasi kami");
                }
                else
                {
                    Console.WriteLine("Tolong masukkan angka dari 1 sampai 5 saja");
                    forloop = true;
                }
                
               }
                
               }

            
            
            
            
            
            
            
            
        }
    }

