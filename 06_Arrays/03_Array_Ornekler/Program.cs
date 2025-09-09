namespace _03_Array_Ornekler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region ornek 1
            //5 elemanlı bir diziye isim atayıp kullanıcıya gösteriniz.
            string[] isimler = { "meriç", "fethi", "murat", "ece" };
            for (int i = 0; i < isimler.Length; i++)
            {
                if (i == isimler.Length - 1)
                {
                    Console.WriteLine(isimler[i]);
                }// son elemana erişmek için
            }
            #endregion


            #region ornek2

            //sayısal olarak eleman tutan 12 elemanlı bir dizinin 5 elemanı tek sayı,7 elemanıda çift sayıdır 
            // dizinin tek ve çift elemanlarını ayrı ayrı toplayıp gösteriniz.

            int[] sayilar = {1,2,4,5,6,7,8,9,10,12,14,11 };

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            int teksayitoplam = 0;
            int ciftsaiıtoplam = 0;
            foreach (var sayi in sayilar)
            {
                if (sayi%2==0)
                {
                    ciftsaiıtoplam += sayi;
                }
                else
                {
                    teksayitoplam += sayi;
                }
            }
            Console.WriteLine(ciftsaiıtoplam);
            Console.WriteLine(teksayitoplam);


            #endregion
        }
    }
}
