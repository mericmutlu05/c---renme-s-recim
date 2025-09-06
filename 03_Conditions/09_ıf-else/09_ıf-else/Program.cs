namespace _09_ıf_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bir sayı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            if(sayi1%2==0)
            {
                Console.WriteLine("sayınız çifttir");
            }
            else if(sayi1%2==1)
            {
                Console.WriteLine("sayınız tektir");
            }
            else
                Console.WriteLine("hatalı karakter girdiniz");
        }
    }
}
