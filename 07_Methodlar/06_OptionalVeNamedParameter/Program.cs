namespace _06_OptionalVeNamedParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // optional parametre: isteğe bağlı parametreler, methodun çağrılması sırasında belirtilmesi zorunlu olmayan parametrelerdir. 
            // Bu parametreler metod tanımında varsayılan değerler alır. Eğer metod çağrılırken ilgili parametre için bir değer sağlanmazsa, bu varsayılan değer kullanılır. 

            // optional parametre göndermeden de methodu çağırabiliriz.
            urunYazdir("İphone 15", 87000,"Telefon");
            urunYazdir("Lenovo", 45000);

            // Named Parametre: Adlandırılmış parametreler, metod çağrılırken parametrelerin sıralamasından bağımsız olarak parametre adı ile birlikte değerlerinin belirtilmesini izin verir. 
            // Bu özellikle çok sayıda isteğe bağlı parametresi olan metodlar için kodun okunabilirliğini arttırır.
            urunYazdir(fiyat: 13000, adi: "Klavye", kategori: "Elektronik");
            urunYazdir(kategori: "Kamera", fiyat: 1200, adi: "Canon");

            
        }

        static void urunYazdir(string adi, double fiyat, string kategori = "Bilgisayar")
        {
            Console.WriteLine($"Ürün adı: {adi} Fiyatı: {fiyat} Kategorisi: {kategori}");
        }

       
    }
}
