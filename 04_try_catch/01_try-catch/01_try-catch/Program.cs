namespace _01_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try-catch (dene ve yakala)
            //hata ayıklamak için kullanıyoruz
            // try bloğunda yapmak istediğimiz işi yazarız. try kısmında bir hata oluşursa catche düşer.

            //try
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("hatalı işlem");
            //}

            try
            {
                Console.WriteLine("bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {

                Console.WriteLine("hatalı karakter girişi"+ex);
            }




        }
    }
}
