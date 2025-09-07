namespace _02_For_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 ile 50 arasındaki çift sayıları ekrana yazdıran program.

            //for (int i = 0; i <=50; i++)
            //{
            //    if (i%2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            #endregion

            #region çarpım tablosu iç içe for döngüsü

            //for (int i = 0; i <=10; i++)
            //{
            //    for (int s = 1; s<=10; s++)
            //    {
            //        int carpım = i * s;
            //        Console.WriteLine($"i:{i}* s:{s}= {carpım}");
            //    }
            //}


            #endregion

            #region alfabe örneği
            //string alfabe = "!*.-abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            //Random ran = new Random();
            //for (int i = 0; i <8; i++)
            //{
            //    Console.WriteLine(alfabe[ran.Next(0,alfabe.Length)]);
            //}
            #endregion

            #region ornek
            //klavyeden girilen bir cümlenin her harfini döngü ile alt alta yazdıran programı yazalım

            //Console.WriteLine("bir kelime giriniz");
            //string kelime = Convert.ToString(Console.ReadLine());

            //for (int i=0 ; i < kelime.Length; i++)
            //{
            //    Console.WriteLine(kelime[i]);
            //}

            #endregion
        }
    }
}
