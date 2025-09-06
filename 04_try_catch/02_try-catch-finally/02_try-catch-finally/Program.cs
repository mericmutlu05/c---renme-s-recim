namespace _02_try_catch_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //finally hata alma durumunda yada almama durumunda her türlü çalışır.
            try
            {
                Console.WriteLine("bir sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("hata oluştu");

            }
            finally
            {
                Console.WriteLine("her türlü çalışır");
            }
        }
    }
}
