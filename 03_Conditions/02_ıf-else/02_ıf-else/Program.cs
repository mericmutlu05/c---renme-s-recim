namespace _02_ıf_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "meric";
            if(ad=="meriç")
            {
                Console.WriteLine("KUllacı adı doğru");
            }
            else
            { 
                Console.WriteLine("kullanıcı adı yanlıs");
            }

            Console.ReadKey();
        }
    }
}
