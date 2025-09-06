namespace _03_ıf_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("adınızı giriniz");
            //string ad = Console.ReadLine();
            //Console.WriteLine($"adınız : {ad} ");

            //kullanıcıdan aldığınız sayının pozitifmi negatfmi olduğunu gösteren if sorgusunu yazınız
            Console.WriteLine("bir sayı giriniz.");
            int girilensayi = Convert.ToInt32(Console.ReadLine());

            if(girilensayi>0)
            {
                Console.WriteLine("pozitif sayıdır");
            }
            else if(girilensayi<0)
            {
                Console.WriteLine("negatif sayıdır");
            }
            else
                Console.WriteLine("girilen sayı 0 a eşit");
        }
    }
}
