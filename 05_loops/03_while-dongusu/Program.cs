namespace _03_while_dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region sayı 10 oluncaya kadar dönen while döngüsü
            //int sayi = 1;
            //while (sayi <= 10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            #endregion

            #region değer true olduğu sürece dönen döngü

            //bool durum = true;
            //while (durum==true)
            //{
            //    Console.WriteLine(durum);
            //    Console.WriteLine("devam etmek istiyormusunuz?(E/H)");
            //    string cevap = Console.ReadLine();
            //    if (cevap == "H")
            //        durum = false;
                
            //}
            //    Console.WriteLine("döngüden çıkıldı");
            #endregion

            #region continue ve break kullanımı

            int sayac = 0;
            while(sayac<=10)
            {
                sayac++;
                if(sayac==3)
                {
                    continue;
                }
                if (sayac==5)
                {
                    break;
                        
                }
                Console.WriteLine(sayac);
            }

            #endregion

        }
    }
}
