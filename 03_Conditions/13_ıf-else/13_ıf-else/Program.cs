namespace _13_ıf_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 99;
            int sayi2 = 100;
            #region scope'siz kullanım
            //if(sayi>sayi2)
            //    Console.WriteLine("sayı sayı 2 den buyuk ");
            //else if(sayi<sayi2)
            //    Console.WriteLine("sayı sayı2' dem büyük");
            //else
            //    Console.WriteLine("sayılar birbirine eşit");



            #endregion

            #region iç içe if kullanımı
            //if (sayi>0)
            //{
            //    if(sayi<100)
            //    {
            //        Console.WriteLine("sayı 100'den küçüktür");
            //    }
            //    else
            //    {
            //        Console.WriteLine("sayı 100'den büyüktür");
            //    }


            //}
            //else
            //{
            //    Console.WriteLine("sayı 0'dan küçüktür");
            //}
            #endregion

            #region ternary kullanım(üçlü kullanım)
            //? işareti : if anlamına gelir 
            //: işareti : else anlamına gelir
            string sonuc = sayi > sayi2 ? "sayı büyüktür sayi'den ":"sayi büyük değildir sayi2' den";
            Console.WriteLine("ternary if else kullanımı "+sonuc);
            #endregion
        }
    }
}