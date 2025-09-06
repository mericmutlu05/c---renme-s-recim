namespace _06_ıf_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region örnek 1
            Console.WriteLine("1 ci sayıyı giriniz");
            int sayi1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2 ci sayıyı giriniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            if(sayi1<sayi2)
            {
                Console.WriteLine(sayi2-sayi1);
            
            }
            else if (sayi2 < sayi1)
            {
                Console.WriteLine(sayi1 - sayi2);

            }
            else
            {
                Console.WriteLine("sayılar birbirine eşit");
            }
            #endregion


            #region örnek 2
            Console.WriteLine("Yaşınızı giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());

            if(yas>0 && yas<=12)
            {
                Console.WriteLine("Çocuksun");
            }

            else if (yas > 13 && yas <= 19)
            {
                Console.WriteLine("gençsin");
            }

            else if (yas > 20 && yas <= 64)
            {
                Console.WriteLine("yetişkin");
            }

            else if (yas > 65 && yas <= 120)
            {
                Console.WriteLine("yaşlısın");
            }
            else
                Console.WriteLine("geçersiz yaş girdiniz");

            #endregion
        }
    }
}
