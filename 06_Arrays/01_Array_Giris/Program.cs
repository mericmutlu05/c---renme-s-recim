namespace _01_Array_Giris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array Nedir?
            /* Diziler(Arrays) 
             * String ifadeler aslında birer dizidir. 
             * Diziler birden çok yapıyı içinde barındıran collection yapılardır. 
             * Dizileri tanımlarken sayısını belirttiğimiz veya belirtmediğimiz durumlar vardır. 
             * Dizinin elemanlarını index numaralarına göre işleme alırız ve index numarası her zaman 0'dan başlar. 
             * Dizi tanımlama => int[] dizi = new int[] => instance / örneklem
             */
            #endregion

            #region Array Tanımlaması 
            int[] sayilar = { 4, 42, 14314, 1425, 5464, 14, 1 };
            //Console.WriteLine(sayilar);

            //for(int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(i + ".eleman=" + sayilar[i]);
            //}
            #endregion

            #region Array içindeki elemanları yazdırma
            //int counter = 0;
            //while(counter < sayilar.Length)
            //{
            //    Console.WriteLine(sayilar[counter]);
            //    counter++;
            //}
            #endregion

            #region Foreach ile değerleri yazdırma
            string[] isimler = new string[4];
            isimler[0] = "Ali";
            isimler[1] = "Fahri";
            isimler[2] = "Oğulcan";
            isimler[3] = "Eyüp";
            //isimler[4] = "Onur"; // Array 4 değer alabildiği için 5.index'te runtime zamanında hata verir.

            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}
            #endregion


            #region Döngü kullanmadan yazdırma
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            #endregion
        }
    }
}
