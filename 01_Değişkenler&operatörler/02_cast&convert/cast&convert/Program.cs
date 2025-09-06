namespace cast_convert
   {
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Convert 1
            //String bir ifadeyi int'e çevirme işlemi 
            string str = "10";
            int sayi = Convert.ToInt32(str);
            #endregion

            #region cast 1
            // int bir değeri string'e çevirme işlemi 
            int sayi2 = 10;
           // string deneme = sayi2.ToString();
            Console.WriteLine(sayi2);
            #endregion

            #region cast 2

            string deneme1 = "10,5";
            // double sayi3 = Convert.ToDouble(deneme1);
            double sayi4 = double.Parse(deneme1);
            Console.WriteLine(sayi4);

            #endregion

        }
    }
}
