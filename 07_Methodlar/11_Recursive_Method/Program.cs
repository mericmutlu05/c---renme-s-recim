using System.Security.Cryptography;

namespace _11_Recursive_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test(); // Recursive metodların her zaman bir base case'e sahip olması gerekir. 
            //test2(5);

            // parametre olarak aldığı sayıya kadar olan sayıların toplamını alan method
            //int sonuc = kumulatifToplam(10);
            //Console.WriteLine(sonuc);

            int sayi = 50;

            for(int i = 0; i < sayi; i++)
            {
                Console.WriteLine(fibonacci(i) + "");
            }
        
        }

        static void test()
        {
            Console.WriteLine("Test Çalıştı");
            test();
        }

        static void test2(int sayi)
        {
            Console.WriteLine(sayi);
            if (sayi > 0)
                test2(sayi - 1);
        }

        static int kumulatifToplam(int sayi)
        {
            if (sayi > 0)
                return sayi + kumulatifToplam(sayi - 1);
            else
                return 0;
        }

        static int fibonacci(int sayi)
        {
            if (sayi <= 1)
                return sayi;
            return fibonacci(sayi - 1) + fibonacci(sayi - 2);
        }
    }
}
