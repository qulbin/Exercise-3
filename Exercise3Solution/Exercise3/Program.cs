using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihBerangkat = 0;
            int pilihTujuan = 0;
            bool validasiPilihan = true;
            string pilih = "";
            List<string> ListHasil = new List<string>();


            pilihBerangkat:
            string[] kota = new string[5];
            kota[0] = "1. Gotham";
            kota[1] = "2. Metropolis";
            kota[2] = "3. Sin City";
            kota[3] = "4. Pewter City";
            kota[4] = "5. Starling City";

            Console.WriteLine("Pilih kota keberangkatan : ");
            Console.WriteLine(kota[0]);
            Console.WriteLine(kota[1]);
            Console.WriteLine(kota[2]);
            Console.WriteLine(kota[3]);
            Console.WriteLine(kota[4]);

            
            validasiPilihan = true;
            while (validasiPilihan)
            {
                
                try
                {
                    Console.Write("Silahkan pilih: ");
                    pilihBerangkat = int.Parse(Console.ReadLine());
                    while (pilihBerangkat < 1 || pilihBerangkat > 5)
                    {
                        Console.Write("Tolong input antara 1 sampai 5 : ");
                        pilihBerangkat = int.Parse(Console.ReadLine());

                    }
                    validasiPilihan = false;
                }
                catch
                {
                    Console.WriteLine("INPUT SALAH!");
                    goto pilihBerangkat;
                }

                Console.WriteLine("Pilih kota Tujuan : ");
                Console.WriteLine(kota[0]);
                Console.WriteLine(kota[1]);
                Console.WriteLine(kota[2]);
                Console.WriteLine(kota[3]);
                Console.WriteLine(kota[4]);

                validasiPilihan = true;
                gotoTujuan:
                try
                {
                    Console.Write("Silahkan pilih: ");
                    pilihTujuan = int.Parse(Console.ReadLine());
                    while (pilihTujuan < 1 || pilihTujuan > 5)
                    {
                        Console.Write("Tolong input antara 1 sampai 5 : ");
                        pilihTujuan = int.Parse(Console.ReadLine());
                    }
                    validasiPilihan = false;
                }
                catch
                {
                    Console.WriteLine("INPUT SALAH!");
                    goto gotoTujuan;
                }
            }
            




            int[,] jarakKota = new int[5, 5];
            jarakKota[0, 0] = 0;
            jarakKota[0, 1] = 2400;
            jarakKota[0, 2] = 3506;
            jarakKota[0, 3] = 2178;
            jarakKota[0, 4] = 5670;
            jarakKota[1, 0] = 2400;
            jarakKota[1, 1] = 0;
            jarakKota[1, 2] = 4500;
            jarakKota[1, 3] = 5666;
            jarakKota[1, 4] = 3700;
            jarakKota[2, 0] = 3506;
            jarakKota[2, 1] = 4500;
            jarakKota[2, 2] = 0;
            jarakKota[2, 3] = 6788;
            jarakKota[2, 4] = 8775;
            jarakKota[3, 0] = 2178;
            jarakKota[3, 1] = 5666;
            jarakKota[3, 2] = 6788;
            jarakKota[3, 3] = 0;
            jarakKota[3, 4] = 1300;
            jarakKota[4, 0] = 5670;
            jarakKota[4, 1] = 3700;
            jarakKota[4, 2] = 8775;
            jarakKota[4, 3] = 1300;
            jarakKota[4, 4] = 0;

            
            string hasil = string.Format("jarak dari {0} sampai {1} adalah {2}", kota[pilihBerangkat - 1], kota[pilihTujuan - 1], jarakKota[pilihBerangkat - 1, pilihTujuan - 1]);
            Console.WriteLine(hasil);


            // Penambahan ke list nya untuk history
            ListHasil.Add(hasil);

            input_lagi:
            validasiPilihan = false;
            while (!validasiPilihan)
            {
                try
                {
                    Console.Write("\nLanjutkan input atau keluarkan list semua output? [Y/N]: ");
                    pilih = Console.ReadLine();
                    if (pilih == "Y" || pilih == "y")
                    {
                        Console.WriteLine("");
                        goto pilihBerangkat;
                    }
                    else if (pilih == "N" || pilih == "n")
                    {
                        Console.WriteLine("\n========= History =========");
                        foreach (string item in ListHasil)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input harus Y atau N, ulangi kembali..");
                        goto input_lagi;

                    }
                    validasiPilihan = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Inputan salah, coba lagi..\n");
                }

            }
        }
    }
}
