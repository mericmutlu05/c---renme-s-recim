namespace _09_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınacak ürün sayısına göre her bir ürün fiyatını bir bir isteyip
            //kullanıcıya fiyatların toplamlarını giriniz 
            // try catch ve do while




             while (true)
            {
                try
                {
                    Console.WriteLine("kaç ürün alınacak");
                    int urunsayisi = int.Parse(Console.ReadLine());
                    if (urunsayisi>0)
                    {
                        break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("hatalı ürün sayısı girdiniz");
                }

            }

            do
            {
                try
                {
                    Console.WriteLine();
                }
                catch (Exception)
                {

                    throw;
                }
            } while (true);



        }
    }
}
