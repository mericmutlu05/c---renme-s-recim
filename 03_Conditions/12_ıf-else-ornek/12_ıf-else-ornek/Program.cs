namespace _12_ıf_else_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınan 3 adet sayının içinde 2'nin katları olan sayıların toplamını ekramda gösteriniz.

            Console.WriteLine("1 ci sayıyı giriniz ");
            int sayi1 =int.Parse(Console.ReadLine());

            Console.WriteLine("2 ci sayıyı giriniz ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("3 cü sayıyı giriniz");
            int sayi3 = int.Parse(Console.ReadLine());

            int toplam=0;

            if(sayi1%2==0)
            {
                toplam=toplam += sayi1;
                Console.WriteLine("girdiğiniz sayı çifttir");
            }

            if (sayi2% 2 == 0)
            {
                toplam = toplam += sayi2;
                Console.WriteLine("girdiğiniz sayı çifttir");
            }

            if (sayi3 % 2 == 0)
            {
                toplam = toplam += sayi3;
                Console.WriteLine("girdiğiniz sayı çifttir");
            }

            Console.WriteLine($"girilen sayıların toplamı{toplam}");


        }
    }
}
