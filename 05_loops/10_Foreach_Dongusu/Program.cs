namespace _10_Foreach_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach döngüsü ve string dizisi kullanımı

            string[] csinif = { "meric","tarık","salih"};
            #region for ile yazdırma
            for (int i = 0; i < csinif.Length; i++)
            {
                Console.WriteLine(csinif[i]);
            }


            #endregion

            foreach (var item in csinif)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region int dizisi ile foreach kullanımı
            int[] sayilar = {1,2,3,4,5,6,7,8,9 };

            foreach (var sayidizisi in sayilar)
            {
                Console.WriteLine(sayidizisi);
            }


            #endregion

            int[] sayikumesi = {1,2,3,4,5,6,7,8,9 };
            foreach (var item1 in sayikumesi)
            {
                foreach (var item2 in sayikumesi)
                {
                    Console.WriteLine($"{item1}*{item2}:{item1 * item2}");
                    Console.WriteLine("------------");
                }
            }

        }
    }
}
