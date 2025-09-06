namespace _01_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types 
            //int tipinde değişken tanımlama, tam sayılar için kullanılır.

            int sayi = 10;
            int sayi1 = 20;

            //sayi ve sayi1 değişkenleri yukarıda tanımlandığı için tekrar kullanılamaz !!

            //string tipinde değişken tanımlama , içerisinde metinsel ifadeler tutar. 
            string deneme = "Meriç";

            // char tipinde değişken tanımlama , içerisinde sadece tek bir karakter saklayabilir.
            char karakter = 'A';

            //bool tipinde değişken tanımlama , true veya false değer atanabilir.
            bool deger = false;

            //Tarih (datetime) tipinde değişken tanımlama
            DateTime bugun = DateTime.Now;

            //ondalık değerlerde ise double kullanılır
            double ondalikli = 10.5f;
            float ondalikli2 = 1.0f;
            decimal ondalikli3 = 1.0m;

            Console.WriteLine("Value typlar - stack (ramin sol bolgesi)");
            Console.WriteLine($"int tipinin max değeri:{int.MaxValue}ve min değeri : {int.MinValue}");

            Console.WriteLine("referans typlar heap (ramin sağ bölgesi )");
            Console.WriteLine("object");// içerisinde bütün tipleri barındadır.
            Console.WriteLine("string");
            #warning buraya tekrar bak.

            Console.ReadKey();
        }

    }
}
