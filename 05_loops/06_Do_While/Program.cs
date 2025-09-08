namespace _06_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do while döngüsünün while'dan tek farkı her halükarda bir kez çalışacak olmasıdır.
            #region sayı 10 olana kadar dönen do-while döngüsü
            //int sayi = 0;
            //do
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //} while (sayi<=10);


            #endregion

            #region döngü içerisinde continue ve break kullanımı

            int counter = 0;
            do
            {
                counter++;
                if (counter==5 || counter==6)
                {
                    continue;
                }
                if (counter==8)
                {
                    break;
                }
                Console.WriteLine(counter);
            } while (counter<=10);

            #endregion

        }
    }
}
