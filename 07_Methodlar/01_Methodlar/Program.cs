using System.Reflection.Metadata.Ecma335;

namespace _01_Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Geriye Değer Döndürmeyen Methodlar 
            // Geriye değer döndürmeyen ifadesi, methodun gövdesi yani method
            // tanımlarken hangi türde olacağını söylemediğimiz void türlü methodlar için kullanılır. 
            // ornekMethod();

            //parametre almayan ve geriye değer döndürmeyen method çağırma yöntemi 
            // method çağırılırken parametre almıyor olsa bile sonunda parantez aç kapa yapılması gerekir. 
            //parametreAlmayanGeriyeDegerDondurmeyenMethod();

            // bir parametre alan ve geriye değer döndürmeyen method tetikleme yöntemi
            //birParametreAlanGeriyeDegerDondurmeyenMethod(10);

            //ikiParametreAlanGeriyeDegerDondurmeyenMethod(10,20);

            //ucParametreAlanGeriyeDegerDondurmeyenMethod("Salih Oğulcan", 10, 45);

            #endregion


            #region Geriye Değer Döndüren Methodlar
            // Geriye değer döndürme ifadesi,
            // methodun gövdesi hangi türde ise return ifadesi kullanılarak gövdedeki tür ne ise return de aynı tip verilir.
            // Yani gövde string ise return ""; olmak zorunda!

            //int sayi = parametreAlmayanGeriyeDegerDondurenMethod();
            //Console.WriteLine($"Dönen değer: {sayi}");

            //string deger = parametreAlmayanGeriyeStringDegerDondurenMethod();
            //Console.WriteLine($"Dönen değer: {deger}");

            //DateTime tarih = parametreAlmayanGeriyeDateTimeDegerDondurenMethod();
            //Console.WriteLine("Dönen değer: {0}",tarih);

            //int sayi2 = parametreAlanGeriyeDegerDondurenMethod(10);
            //Console.WriteLine("Dönen değer: {0}",sayi2);

            //int carpim = ikiParametreAlanGeriyeDegerDondurenMethod(20, 15);
            //Console.WriteLine("Dönen değer: {0}",carpim);

            string result = ucParametreAlanGeriyeDegerDondurenMethod(10,"Test",DateTime.Now.AddDays(10));
            Console.WriteLine("Dönen değer: {0}",result);






            #endregion
        }

        static void ornekMethod()
        {
            Console.WriteLine("Örnek Method Çalıştı..");
        }

        static void parametreAlmayanGeriyeDegerDondurmeyenMethod()
        {
            Console.WriteLine("Parametre almayan geriye değer döndürmeyen method çalıştı...");
        }

        static void birParametreAlanGeriyeDegerDondurmeyenMethod(int par1)
        {
            Console.WriteLine("Bir parametre alan geriye değer döndürmeyen method çalıştı: " + par1);
        }

        static void ikiParametreAlanGeriyeDegerDondurmeyenMethod(int par1, int par2)
        {
            Console.WriteLine($"İki parametre alan geriye değer döndürmeyen method çalıştı: par1: {par1} par2: {par2}");
        }

        static void ucParametreAlanGeriyeDegerDondurmeyenMethod(string par1,int par2,int par3)
        {
            Console.WriteLine($"Üç parametre alan geriye değer döndürmeyen method çalıştı: par1: {par1} par2: {par2}, par3: {par3}");
        }

        static int parametreAlmayanGeriyeDegerDondurenMethod()
        {
            Console.WriteLine("Parametre almayan geriye değer döndüren method çalıştı.");
            return 100;
        }

        static string parametreAlmayanGeriyeStringDegerDondurenMethod()
        {
            Console.WriteLine("Parametre almayan geriye string değer döndüren method çalıştı.");
            return "İşlem başarıyla tamamlandı";
            
        }

        static DateTime parametreAlmayanGeriyeDateTimeDegerDondurenMethod()
        {
            Console.WriteLine("Parametre almayan geriye DateTime değer döndüren method çalıştı.");
            return DateTime.Now;
        }

        static int parametreAlanGeriyeDegerDondurenMethod(int par1)
        {
            Console.WriteLine("Parametre alan geriye değer döndüren method çalıştı. par1: {0}",par1);
            return par1 * 2;
        }

        static int ikiParametreAlanGeriyeDegerDondurenMethod(int par1,int par2)
        {
            Console.WriteLine("Parametre alan geriye değer döndüren method çalıştı. par1: {0}, par2: {1} ", par1,par2);
            return par1 * par2;
        }
        
        static string ucParametreAlanGeriyeDegerDondurenMethod(int par1, string par2, DateTime par3)
        {
            Console.WriteLine("Parametre alan geriye değer döndüren method çalıştı. par1: {0}, par2: {1} , par3: {2} ", par1, par2,par3);
            return "İşlem Tamamlandı!";
        }

    }
}
