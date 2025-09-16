namespace _02_Method_Summary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //summary blokları methodları developerlara methodun ne iş yaptığına dair bilgi vermek amacıyla kullanılır.

            Console.WriteLine();

            //summary bloğu olmayan methodlarda herhangi bir açıklama görünmez.
            aciklamasizmethod();

            //summary bloklarının içerisinde yazanlar açıklama olarak methodun üstüne gelindiğinde yada yazım 
            //aşamasında parantez açıldığında görülebilir.
            aciklamlimethod();
           

            static void aciklamasizmethod()
            {
                Console.WriteLine("açıklamasız method çalıştı");
            }
           
           /// <summary>
           ///Bu Method ekrana "açıklamalı method çalıştı"yazısı yazar
           /// </summary>
            static void aciklamlimethod()
            {
                Console.WriteLine("açıklamalı method çalıştı");
            }

        }
    }
}
