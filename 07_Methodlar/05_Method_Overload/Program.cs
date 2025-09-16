using static System.Net.Mime.MediaTypeNames;

namespace _05_Method_Overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(); methodunu çağırırken "()" parantez işaretini yazdığımızda çıkan tooltip(açıklama balonu)'nun sol tarafından "+17 overloads" gibi bir yazı çıkar karşımıza.
            Console.WriteLine();
            Console.WriteLine("deneme");
            Console.WriteLine(10.5);

            ekranaYaz();
            ekranaYaz(10);
            ekranaYaz("test");
            ekranaYaz("test", "test2");

            topla(10.5, 24.5);
            topla(10, 20);
            topla(10, 10, 10);


        }

        static void ekranaYaz()
        {
            Console.WriteLine("Dönüş değeri yok!");
        }

        static void ekranaYaz(string text)
        {
            Console.WriteLine($"{text}");
        }

        static void ekranaYaz(int number)
        {
            Console.WriteLine($"{number}");
        }

        static void ekranaYaz(string text, string text2)
        {
            Console.WriteLine(text + " " + text2);
        }

        static void topla(double sayi, double sayi2)
        {
            Console.WriteLine("Sonuç: {0}",sayi + sayi2);
        }

        static void topla(int sayi, int sayi2)
        {
            Console.WriteLine("Sonuç: {0}", sayi + sayi2);
        }

        static void topla(int sayi, int sayi2,int sayi3)
        {
            Console.WriteLine("Sonuç: {0}", sayi + sayi2 + sayi3);
        }
    }
}
