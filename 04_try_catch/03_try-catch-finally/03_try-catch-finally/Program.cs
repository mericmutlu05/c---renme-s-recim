namespace _03_try_catch_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
        BASLA:
            try
            {
                Console.WriteLine("BİR SAYI GİRİNİZ");
                int sayi = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("hatalı işlem");
                Thread.Sleep(5000);
                goto BASLA;
            }
            finally
            {
                Console.WriteLine("ÇALIŞIYORUM");
            }
        }
    }
}
