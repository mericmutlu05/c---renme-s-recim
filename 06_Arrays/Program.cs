namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array Nedir?

            /*
            Diziler (Arrays) 
            string ifadeler aslında birer dizidir.
            diziler birden çok yapıyı içinde barındıran collection yapılardır.
            dizileri tanımlarken sayısını belirttiğimiz veya belirtmediğimiz durumlar vardır.
            dizinin elemanlarını index numaralarına göre işleme alırız ve index numarası her zaman 0'dan başlar.
            dizi tanımlama => int[] dizi=new int[] => instance / örneklem
             */


            #endregion

            #region Array Tanımlaması

            int[] sayilar = {10,2,5,6,89,56,1 };
            //Console.WriteLine(sayilar);

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(i + ". eleman =" + sayilar[i]);
            }


            #endregion


            #region array içerisindeki elemanları yazdırma

            int counter = 0;
            while (counter<sayilar.Length)
            {
                Console.WriteLine(sayilar[counter]);
                counter++;
            }


            #endregion
                 Console.WriteLine("--------------");

            #region foreach ile değer yazdırma
            string[] isimler = new string[4];
            isimler[0] = "ali";
            isimler[1] = "fahri";
            isimler[2] = "tarık";
            isimler[3] = "eyüp";
            //isimler[4]="meriç"; array 4 değer alabildiği için 5 ci index'te runtime zamanında hata verir.

            foreach (var isim in isimler)
            {
               
                Console.WriteLine(isim);
            }
            #endregion

            #region döngü kullanmadan yazdırma
            Console.WriteLine("--------------");
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            #endregion



        }
    }
}
