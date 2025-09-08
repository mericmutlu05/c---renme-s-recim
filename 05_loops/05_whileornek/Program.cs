namespace _05_whileornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciadi = "clatbeast04";
            string sifre = "95069506Alm";
            int sayac = 0;

            while (true)
            {
                Console.WriteLine("kullanıcı adınızı giriniz");
                string kullanıcıgiris = Console.ReadLine();
                Console.WriteLine("Kullanıcı şifrenizi giriniz");
                string kullanicisifre = Console.ReadLine();
                if (kullaniciadi==kullanıcıgiris && kullanicisifre==sifre)
                {
                    Console.WriteLine("başarılı giriş yönlendiriliyorsunuz");
                    break;
                }

                else  
                {
                   
                    Console.WriteLine("kullanıcı adı ve şifre hatalı");
                     sayac++;
                    if (sayac==3)
                    {
                        Console.WriteLine("hesabınız kitlenmiştir");
                        break;
                    }
                }
                

            }
        }
    }
}
