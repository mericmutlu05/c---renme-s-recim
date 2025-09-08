namespace _07_Do_While_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-100 arasında rastgeele sistem tarafından belirlenen sayıyı bulma oyunu yazalım

            Random rnd = new Random();
            int randomsayi = rnd.Next(1,5);
            int girilensayi = 0;
            int hak = 1;

            do
            {
                Console.WriteLine("Rastgele Rakam Bilme Oyununa HoşGeldin !!");
                Console.WriteLine("şanslı sayıyı tahmin etmeye çalış");
                girilensayi = Convert.ToInt32(Console.ReadLine());
                if (girilensayi > randomsayi)
                {
                    Console.WriteLine("girilen sayı random sayıdan büyüktür");
                    
                }
                if (girilensayi < randomsayi)
                {
                    Console.WriteLine("girilensayı random sayıdan küçütür");
                }

                else
                {

                }
                    
              
            } while (girilensayi != randomsayi);
            




        }
    }
}
