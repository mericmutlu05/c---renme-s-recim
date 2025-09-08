namespace _04_While_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while döngüsü kullanarak kullanıcıdan 5 ade sayı girmesini isteyip 
            //girilen sayıların toplamını ekrana yazdıran programı yazalım

            int sayac=1;
            int toplam = 0;
            while (sayac<=5)
            {
                Console.WriteLine($"{sayac}. sayıyı giriniz");
                toplam += int.Parse(Console.ReadLine());
                sayac++;
            }
            Console.WriteLine(toplam);
           
        }
    }
}
