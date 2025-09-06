namespace _07_ıf_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hava sıcaklığını giriniz");
            double derece = Convert.ToDouble(Console.ReadLine());

            if(derece<5)
            {
                Console.WriteLine("hava soğuk kalın giysiler giyin");
            }
            else if(derece>5 && derece<=15)
            {
                Console.WriteLine("hava serin ceket giymeyi unutma");
            }
            else if (derece>15 && derece<=25)
            {
                Console.WriteLine("hava ılık rahat giyinebilirsin");
            }
            else
                Console.WriteLine("hava sıcak uyarısı");
        }
    }
}
