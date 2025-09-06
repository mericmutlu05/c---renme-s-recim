namespace _04_ıf_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan kullanıcı adı ve şifre isteyiniz kullanıcı adı : admin şifre ise admin1905 ise;
            //sisteme giriş yapıldı uyarısı versin . kullanıcı adı veya şifre yanlış durumunda hata versin


            Console.WriteLine("kullanıcı adınızı giriniz");
            string ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("şifrenizi giriniz");
            string sifre = Console.ReadLine();

            if(ad=="admin" && sifre=="Admin1905")
            {
                Console.WriteLine("başarılı giriş");
            }
            else
                Console.WriteLine("hatalı giriş");
        }
    }
}
