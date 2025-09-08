namespace _08_Do_While_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sistemin rastgele üretmiş olduğu sayıyı kullanıcıdan bulması için kod bloğu
            //yazarak , eğer kullanıcının küçük sayı girdiyse kullanıcının küçük sayı girdiğinin uyarısını versin
            //kullanıcının bu 3 adımlı tahmin oyununda 5 hakkı olsun
            //rastgeleüretilen sayı (10,100)arasında olsun
            //try catch do while ile yapılacak

            Random random = new Random();
            int rastgelensayi = random.Next(10,100);
            int sayac = 0;

            try
            {
                do
                {
                    Console.WriteLine("rastgele bir 10-100 arası sayı giriniz");
                    int kulgelensayi = int.Parse(Console.ReadLine());
                    if (kulgelensayi> rastgelensayi)
                    {
                        Console.WriteLine("girdiğiniz değer random sayıdan büyük");
                        sayac++;
                        if (sayac == 5)
                        {
                            Console.WriteLine("hakkınız doldu");
                            break;
                        }
                    }
                    else if (kulgelensayi < rastgelensayi)
                    {
                        Console.WriteLine("girdiğiniz değer random sayıdan küçük");
                        sayac++;
                        if (sayac==5)
                        {
                            Console.WriteLine("hakkınız doldu");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("kazandınız");
                        break;
                    }
                        

                    Console.WriteLine($"bilgisar tarafınfan tutulan sayı :  {rastgelensayi}");

                } while (true);
            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
