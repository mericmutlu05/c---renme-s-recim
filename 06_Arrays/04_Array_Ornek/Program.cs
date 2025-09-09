namespace _04_Array_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan ürün sayısını isteyerek verilen sayıya göre kullanıcıdan bir ürün isimleri isteyen kodlamayı giriniz

            Console.WriteLine("Ürün sayısını giriniz");
            int urunsayisi = int.Parse(Console.ReadLine());
            string[] urundizisi = new string[urunsayisi];

            for (int urun = 0; urun < urundizisi.Length; urun++)
            {
                Console.WriteLine($"{urun+1}. Ürünün Adını giriniz");
                urundizisi[urun] = Console.ReadLine();
            }
            foreach (var urun in urundizisi)
            {
                Console.WriteLine(urun);
            }


        }
    }
}
