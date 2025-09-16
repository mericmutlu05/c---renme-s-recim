using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace _12_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir ödeme sistemi tasarlayacaksınız. 
            // Müşterilerin sipariş toplamını, ödeme işlemi sonrasında yeni bakiyeyi güncelleyip, ve kampanya olduğunda indirim uygulayıp fiyat güncellenecek.
            // 1 - indirimUygula adında bir metod tanımlayın. Burada toplamTutar ve indirimOrani adında iki parametre olsun. Müşteri kampanyadan faydalanıyorsa toplam tutarından indirim tutarını düşürün.
            // 2 - odemeYap  adında bir metod tanımlayın. double toplamTutar double mevcutBakiye ve double yeniBakiye adında parametreler olacak.
            // Müşteri ödeme yaptıktan sonra yeni bakiyesini hesaplayın.Bakiye yetersiz ise hata fırlatın.
            // 3 - siparisTopla adında bir metodunuz olsun. Müşteri birden fazla ürün sipariş edebileceği için urunFiyatları parametresini hangi     keyword     ile tanımlamanız lazım karar verin. Bu diğer metodlar için de geçerli. 
            // 4 - Bu 3 metodta, parametrelerde hangi keyword'ler kullanılacak sizin kararınız. Ama metodlar uygun keyword'lere göre tasarlandı.İyi karar verin.
            // 5 - Main içinde bu metodları uygulayarak;
            //            sipariş toplam fiyatını
            //            indirim uygulandıktan sonra toplam fiyatı
            // ödeme başarılı ise yeni bakiyeyi
            // çıktı olarak ekranda gösterin

            Console.WriteLine("Kaç adet ürün sipariş vereceksiniz? ");
            int urunSayisi = int.Parse(Console.ReadLine());
            
            double[] urunFiyatlari = new double[urunSayisi];

            for(int i = 0; i < urunSayisi; i++)
            {
                Console.WriteLine($"Ürün {i + 1} fiyatını giriniz: ");
                urunFiyatlari[i] = double.Parse(Console.ReadLine());
            }

            double toplamTutar = SiparisTopla(urunFiyatlari);
            Console.WriteLine($"Toplam Sipariş Tutarı: {toplamTutar} TL");

            Console.WriteLine("İndirim oranını giriniz: ");
            double indirimOrani = double.Parse(Console.ReadLine());
            IndirimUygula(ref toplamTutar, indirimOrani);
            Console.WriteLine($"İndirim sonrası toplam tutar: {toplamTutar}");

            Console.WriteLine("Mevcut bakiyeniz: ");
            double mevcutBakiye = double.Parse(Console.ReadLine());
            double yeniBakiye;

            if (OdemeYap(toplamTutar, mevcutBakiye, out yeniBakiye))
            {
                Console.WriteLine("Ödeme başarılı. Yeni bakiyeniz: " + yeniBakiye.ToString("F2"));
            }

            else
            {
                Console.WriteLine("Bakiye yetersiz. Lütfen bakiyenizi kontrol ediniz: " + mevcutBakiye.ToString("F2"));
            }

        }

        static void IndirimUygula(ref double toplamTutar,double indirimOrani=10)
        {
            toplamTutar -= (toplamTutar * indirimOrani * 0.01);
        }

        static bool OdemeYap(double toplamTutar,double mevcutBakiye,out double yeniBakiye)
        {
            if(mevcutBakiye >= toplamTutar)
            {
                yeniBakiye = mevcutBakiye - toplamTutar;
                return true;
            }

            else
            {
                yeniBakiye = mevcutBakiye;
                return false;
            }
        }

        static double SiparisTopla(params double[] urunFiyatlari)
        {
            double toplamTutar = 0;
            foreach (var fiyat in urunFiyatlari)
            {
                toplamTutar += fiyat;
            }

            return toplamTutar;
        }
    }
}
