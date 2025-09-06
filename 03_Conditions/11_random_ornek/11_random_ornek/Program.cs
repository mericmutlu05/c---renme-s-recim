namespace _11_random_ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
       Basla:
            Console.WriteLine("şanslı sayıyı giriniz");
            int sanslisayi = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int ramdomsayi = rnd.Next(1,6);
            if(ramdomsayi==sanslisayi)
            {
                Console.WriteLine("tebrikler kazandınız");
            }
            else
                Console.WriteLine($"tekrar deneyiniz random sayı {ramdomsayi}");
                
            goto Basla;

           
        }
    }
}
