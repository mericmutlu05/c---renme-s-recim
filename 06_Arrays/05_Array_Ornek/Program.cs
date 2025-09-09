namespace _05_Array_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kullanıcıdan alınacak ürün sayısına göre ürün isimleri istenerek bir diziye atılacak 
            //ve sonrasında her bir ürün adı yazılarak karşısında fiyatı istendikten sonra bütün ürünlerin isimleri karşısında 
            //fiyatları listeleyiniz.


            Console.WriteLine("Ürün sayısını giriniz");
            int sayi =int.Parse(Console.ReadLine());
            string[] urunler = new string[sayi];
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{i+1}.urunun adını giriniz");
                urunler[i] = Console.ReadLine();
            }
            Console.WriteLine("Urunlerin isimleri");
          
            foreach (var item in urunler)
            {
                Console.WriteLine(item);
            }


          


           
        }
    }
}
