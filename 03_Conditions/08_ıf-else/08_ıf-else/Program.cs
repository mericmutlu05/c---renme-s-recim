namespace _08_ıf_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("final notunuzu giriniz");
            double final = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vize notunuzu giriniz");
            double vize = Convert.ToDouble(Console.ReadLine());

            if(final<0 && vize <0)
            {
                Console.WriteLine("hatalı giriş 0 dam az notunuz olamaz");
            }
            else if (final > 100 && vize > 100)
            {
                Console.WriteLine("hatalı giriş 100 dem fazla notunuz olamaz");
            }
            else
            {
                //double ortalama = (vize - vize * 0.4) + (final - final * 0.60);
                double ortalama = vize * 0.40 + final * 0.60;

                if (ortalama>0 && ortalama<=20)
                {
                    Console.WriteLine($"ortalamanız {ortalama} harf notunuz : ff");
                }
                else if (ortalama >= 21 && ortalama <= 35)
                {
                    Console.WriteLine($"Ortalamanız: {ortalama} - Harf notunuz: DD");
                }

                else if (ortalama >= 36 && ortalama <= 45)
                {
                    Console.WriteLine($"Ortalamanız: {ortalama} - Harf notunuz: CC");
                }

                else if (ortalama >= 46 && ortalama <= 70)
                {
                    Console.WriteLine($"Ortalamanız: {ortalama} - Harf notunuz: BB");
                }

                else if (ortalama >= 71 && ortalama <= 100)
                {
                    Console.WriteLine($"Ortalamanız: {ortalama} - Harf notunuz: AA");
                }


            }


        }
    }
}
