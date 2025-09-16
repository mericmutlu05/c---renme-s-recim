namespace _03_Methodlar_Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            /*
             kullanıcıdan 1 sayı girmesini isteyip girilen sayının iki katını alan ekrana yazdıran programı yazalım.
             */
            // ikikatinialan();
            #endregion

            #region Ornek 2
            //birden 100 e kadar olan tek sayıları ekrana yazdıran methodu yazalım.
            // teksayi();

            #endregion

            #region ornek 3

            //parametre olarak girilen sayının küpünü ekrana kazdıran methodu ekrana yazalım
            // kup(3);
            #endregion

            #region ornek 4
            //parametre olarak aldığı 2 sayının çarpımını ekrana yazdıran methodu yazalım.
            // ikisayinincarpimi(10,30);
            #endregion

            #region ornek 5

            //Parametre olarak aldığı 3 adet string parametreyi aralara "-"
            //atarak birleştirip ekrana yazdıran programı yazalım.
            //stringbirlestir("meriç","mutlu","amasya");

            #endregion

            #region ornek 6 

            #endregion

            static void ikikatinialan()
            {
                Console.WriteLine("bir sayı giriniz");
                int sayi = int.Parse(Console.ReadLine());
                sayi = sayi * 2;
                Console.WriteLine(sayi);
            } 
            static void teksayi()
            {
                for (int i = 0; i <= 100; i++)
                {
                    if (i%2==1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            static void kup(int sayi1)
            {
                sayi1 = sayi1 * sayi1 * sayi1;
                Console.WriteLine(sayi1);
            }

            static void ikisayinincarpimi(int sayi1,int sayi2)
            {
                int sonuc = sayi1 * sayi2;
                Console.WriteLine(sonuc);
            }
            static void stringbirlestir(string ad,string soyad,string memleket)
            {
                Console.WriteLine($"{ad}-{soyad}-{memleket}");
            }

        
        }
    }
}
