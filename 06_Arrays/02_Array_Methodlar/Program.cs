namespace _02_Array_Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayis = { 1220,230,340,430,520,60,70};
            #region for ile yazdırma

            

            //for (int i = 0; i < sayis.Length; i++)
            //{
            //    Console.WriteLine(sayis[i]);
            //}

            #endregion

            #region array sort
            Array.Sort(sayis);
            //for (int i = 0; i < sayis.Length; i++)
            //{
            //    Console.WriteLine(sayis[i]);
            //}

            #endregion

            #region arrayreverse metot

            string isim = "meriç";
            char[] isimdizisi = new char[isim.Length];
            for (int i = 0; i < isim.Length; i++)
            {
                isimdizisi[i] = isim[i];
            }
            Array.Reverse(isimdizisi);

            for (int i = 0; i < isim.Length; i++)
            {
                Console.WriteLine(isimdizisi[i]);
            }

            #endregion
        }
    }
}
