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

        }
    }
}
