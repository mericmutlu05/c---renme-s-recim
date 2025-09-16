namespace _03_Method_Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1 
            // Kullanıcıdan bir sayı girmesini isteyip girilen sayının iki katını alan ekrana yazdıran programı yazalım. 
            // ikiKatiniAl();
            #endregion

            #region Örnek 2
            // Birden 100'a kadar olan tek sayıları ekrana yazdıran methodu yazalım.
            // tekSayiYazdir();
            #endregion

            #region Örnek 3
            // Parametre olarak aldığı sayının küpünü ekrana yazdıran methodu yazalım.
            //kupAl(3);
            #endregion

            #region Örnek 4
            //Parametre olarak aldığı 2 sayının çarpımını ekrana yazdıran methodu yazalım.
            //carpimAl(5,4);
            #endregion

            #region Örnek 5
            //Parametre olarak aldığı 3 adet string parametreyi aralara "-" atarak birleştirip ekrana yazdıran programı yazalım.
            //stringBirlestir("Onur", "Yağız", "12144");
            //Console.WriteLine(stringBirlestirV2("Salih", "Oğulcan", "3561")); 
            #endregion

            #region Örnek 6
            //Parametre olarak aldığı int dizisinin içerisindeki en büyük değeri bulup geri dönen methodu yazalım. Geri dönen değeri ekrana yazdıralım.
            int[] sayilar = { 19, 3454, 46431, 1523563, 322536457 };
            //Console.WriteLine(enBuyukBul(sayilar));

            #endregion

            #region Örnek 7
            //Parametre olarak aldığı int dizisinin içerisindeki sayıların ortalamasını bulup geri dönen methodu yazalım. Geri dönen değeri ekrana yazdıralım.
            // Console.WriteLine(ortalamaBul(sayilar));
            #endregion

            #region Örnek 8
            //Parametre olarak aldığı 2 adet string dizisini birleştirip yeni bir dizi olarak geri dönen methodu yazalım.
            string[] dizi1 = { "Alper", "Salih", "Ali Fethi"};
            string[] dizi2 = { "Meriç", "Oğulcan", "Abide" };
            string[] dizi3 = diziBirlestir(dizi1,dizi2);

            foreach(string dizi in dizi3)
            {
                Console.WriteLine(dizi);
            }
            #endregion
        }

        static void ikiKatiniAl()
        {
            Console.WriteLine("Bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Girilen sayının iki katı: {0}",sayi * 2);
        }

        static void tekSayiYazdir()
        {
            #region Yöntem 1
            //for (int i = 0; i < 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Yöntem 2
            for (int i = 0;i < 100; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

        }

        static void kupAl(int sayi)
        {
            Console.WriteLine("Sayının küpü: {0}",sayi * sayi * sayi);
            //Console.WriteLine("Sayının küpü: {0}",Math.Pow(sayi,3));

        }

        static void carpimAl(int sayi1, int sayi2)
        {
            Console.WriteLine("Sayıların çarpımı: " + sayi1 * sayi2);
        }

        static void stringBirlestir(string isim, string soyisim,string no)
        {
            Console.WriteLine("{0}-{1}-{2}",isim,soyisim,no);
            
        }

        static string stringBirlestirV2(string isim,string soyisim,string no)
        {
            return string.Format("{0}-{1}-{2}", isim, soyisim, no);
        }

        static int enBuyukBul(int[] dizi)
        {
            return dizi.Max();
        }

        static double ortalamaBul(int[] dizi)
        {
            return dizi.Average();
        }

        static string[] diziBirlestir(string[] dizi, string[] dizi2)
        {
            return dizi.Concat(dizi2).ToArray();
        }
    }
}
