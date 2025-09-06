namespace _05_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aylık gelirinizi giriniz");
            double maas = Convert.ToInt32(Console.ReadLine());
            double yenigelir;
            if(maas <= 22000)
            {
                yenigelir=maas - maas * 0.12;
            }
            else
            {
                yenigelir = maas - maas * 0.18;
            }

            Console.WriteLine($"yeni maasınız: {yenigelir} ");
        }
    }
}
