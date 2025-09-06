namespace _14_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch-case
            Console.WriteLine("bir şehir adı giriniz");
            string deger = Console.ReadLine();

            //switch(deger) deger kısmına kontrol edilecek değişken yazılır.
            //case kısmında kıyaslama işlemleri gerçekleştirilir.
            //break ise eşleşme durumunda çalışacak kod bloğunun sona erdiğini gösterir.
            //eğer case'lerdem hiçbirisi kontrol edilen değer ile eşleşmiyorsa default kısmı çalışacaktır.
            switch(deger)
            {
                case "istanbul":
                    Console.WriteLine("istanbulun plaka kodu 34");
                    break;
                case "izmir":
                    Console.WriteLine("izmirin plaka kodu 35");
                    break;
                default:
                    Console.WriteLine("girdiğiniz şehrin plaka kodu bulunamadı");
                    break;
            }
            #endregion

            #region switch-case goto

            string islemtipi = "Ürün Ekle";

            switch(islemtipi)
            {
                case "Stok Eksilt":
                    Console.WriteLine("Stok EKsiltme işlemi Başarıyla gerçekleştirildi");
                    break;
                case "Ürün Ekle":
                    Console.WriteLine("ürün ekleme işleminiz başarıyla gerçekleştirildi");
                    goto case "Stok Arttır";
                    break;
                case "Stok Arttır":
                    Console.WriteLine("stok arttırma işlemi gerçekleştirildi");
                    break;


            }
            #endregion



        }
    }
}
