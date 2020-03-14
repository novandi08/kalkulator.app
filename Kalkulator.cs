using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih;
            int keluar, a, b, c;
            Console.WriteLine("Pilih Menu Calculator: ");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Input nomer menu (1..4) : ");
            pilih = Int32.Parse(Console.ReadLine());
            Console.WriteLine("");
           


            if (pilih == 1)
            {
                Console.Write("Inputkan nilai a : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan nilai b : ");
                b = Convert.ToInt32(Console.ReadLine());
                c = a + b;
                Console.WriteLine("");
                Console.WriteLine("Hasil Penambahan " + (a) + "  +  " + (b) + " = " + (c) + "   ");
            }
            else if (pilih == 2)
            {
                Console.Write("Inputkan nilai a : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan nilai b : ");
                b = Convert.ToInt32(Console.ReadLine());
                c = a - b;
                Console.WriteLine("");
                Console.WriteLine("Hasil Pengurangan " + (a) + "  -  " + (b) + " = " + (c) + "   ");
            }
            else if (pilih == 3)
            {
                Console.Write("Inputkan nilai a : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan nilai b : ");
                b = Convert.ToInt32(Console.ReadLine());
                c = a * b;
                Console.WriteLine("");
                Console.WriteLine("Hasil Perkalian " + (a) + "  x  " + (b) + " = " + (c) + "   ");
            }
            else if (pilih == 4)
            {
                Console.Write("Inputkan nilai a : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan nilai b : ");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("");
                Console.WriteLine("Hasil Pembagian " + (a) + "  :  " + (b) + " = " + (c) + "   ");

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
                Console.WriteLine("");
            }
            {
                Console.WriteLine("");
                Console.WriteLine("Tekan Sembarang key untuk keluar");
                keluar = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}