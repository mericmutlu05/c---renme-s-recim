namespace _03_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int sayi = 7;
           // toplam = sayi + toplam;
            toplam += sayi;
            Console.WriteLine(toplam);
            //Operatörler
            //Atama Operatörleri 
            /*
            
            = atama operatörü sağdaki veriyi soldaki değiken yapısına atar.
            += arttırma operatörü
            -= azaltma operatörü


            //Compresion operatör (karsılaştırma operatörü)
            true veya false değer döner.

            == eşitmi
            != eşit değilse
            < küçüktür
            > büyüktür
            >= büyük eşittir
            <= küçük eşittir

            //Mantıksal Operatörler
            && (ve)
            || (veya)

             */

            int sayi1 = 10;
            int sayi2 = 20;

            bool karsilastir1 = sayi1 > sayi2;//false
            bool karsilastir2 = sayi2 < sayi1;//false
            bool karsilastir3 = sayi1 < sayi2;//true
            bool karsilastir4 = sayi1 <= sayi2;//true
            bool karsilastir5 = sayi1 >= sayi2;//false

            Console.WriteLine(karsilastir1);
            Console.WriteLine(karsilastir2);
            Console.WriteLine(karsilastir3);
            Console.WriteLine(karsilastir4);
            Console.WriteLine(karsilastir5);

        }
    }
}
