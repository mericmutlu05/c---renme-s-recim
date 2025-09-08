using System.ComponentModel.DataAnnotations;

namespace _11_Foreach_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region örnek-1
            // İçerisinde ürün fiyatları bulunan bir int dizisi oluşturup değerlerini oluşturma anında atayalım. 
            // Sonrasında her bir ürünün fiyatının yüzde 10 zam yapılmış halini ekrana yazdıralım. 

            //int[] fiyat = { 200, 300, 400, 500 };
            //foreach (var item in fiyat)
            //{
            //    Console.WriteLine($"{item},%10 zamlı fiyat : {item * 1.10}");
            //}

            #endregion

            #region örnek-2
            //5 karakter uzunluğunda bir string dizisi oluşturup değerlerini oluşturma 
            //anında atayalım ve dizinin içindeki en uzun değeri bulup ekrana yazdıralım


            //string[] isimler = { "meric", "tarık", "salih", "abdurrezak" };
            //string enuzunkelime = "";

            //foreach (var item1 in isimler)
            //{
            //    if (item1.Length>enuzunkelime.Length)
            //    {
            //          enuzunkelime=item1;
            //    }
            //}
            //Console.WriteLine(enuzunkelime);


            #endregion

            #region örnek 3

            //diziye rastgele atanan 10 adet sayının ortalamasını bulup ekrana yazdıran programı yazdıralım

            int[] sayilar = new int[10];
            Random random = new Random();

            int counter = 0;

            foreach (int sayi in sayilar)
            {
                sayilar[counter] = random.Next(1, 101);
                Console.WriteLine(sayilar[counter]);
                counter++;
            }

            int toplam = 0;

            foreach (var sayi1 in sayilar)
                toplam += sayi1;
            Console.WriteLine("Ortalama: {0}", toplam / 10);



            #endregion

        }
    }
}
