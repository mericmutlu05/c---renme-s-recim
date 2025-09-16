namespace _02_Method_Summary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Summary bloklar methodları developer'lara methodun ne iş yaptığına dair bilgi vermek amacıyla kullanılır. 
            Console.WriteLine();

            // Summary bloğu olmayan methodlarda herhangi bir açıklama gözükmez
            aciklamasizMethod();

            // Summary bloklarının içerisinde yazanlar açıklama olarak methodun üstüne gelindiğinde ya da yazım aşamasında parantez açıldığında görülebilir. 
            aciklamaliMethod();

            int toplam = Topla(faktoriyelHesapla(5), faktoriyelHesapla(7));
            Console.WriteLine("Sayıların toplamı: " + toplam);

            Console.WriteLine(faktoriyelHesapla(5));

        }

        static void aciklamasizMethod()
        {
            Console.WriteLine("Açıklamasız method çalıştı!");
        }
        
        /// <summary>
        /// Bu method ekrana "Açıklamalı Method Çalıştı" yazısı yazar.
        /// </summary>
        static void aciklamaliMethod()
        {
            Console.WriteLine("Açıklamalı method çalıştı!");
        }

        /// <summary>
        /// Girilen iki sayının toplamını alıp return eder.
        /// </summary>
        /// <param name="sayi">toplama işlemi için gereken birinci sayı</param>
        /// <param name="sayi2">toplama işlemi için gereken ikinci sayı</param>
        /// <returns>Sayıların toplamını döner.</returns>
        static int Topla(int sayi, int sayi2)
        {
            return sayi + sayi2;
        }

        /// <summary>
        /// Bu metod verilen sayının faktoriyelini hesaplar.
        /// Algoritma açıklaması için <see href="https://tr.wikipedia.org/wiki/Fakt%C3%B6riyel"/> adresine bakınız
        /// </summary>
        /// <param name="sayi">faktoriyel için gereken sayı</param>
        /// <returns></returns>
        static int faktoriyelHesapla(int sayi)
        {
            if (sayi <= 1)
                return sayi;
            else
                return sayi * faktoriyelHesapla(sayi - 1);
        }
    }
}
