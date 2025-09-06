namespace _10_random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rastgelesayi = rnd.Next();
            Console.WriteLine($"rastgele sayınız : {rastgelesayi}");



        }
    }
}
