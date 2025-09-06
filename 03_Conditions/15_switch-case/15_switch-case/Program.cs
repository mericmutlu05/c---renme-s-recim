namespace _15_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan bir sayısal değer girmesini isteyin. girilen sayıya göre haftanın kaçıncı günü oldupunu bize 
            //soyleyen kodu yazın. girilen değer 1-7 arasında değilsedoğru değer girmesini sağlayın

            Console.WriteLine("bir sayısal değer giriniz");
            int gun = Convert.ToInt32(Console.ReadLine());

            switch(gun)
            {
                case 1 :
                    Console.WriteLine("pazar günü");
                    break;

                case 2:
                    Console.WriteLine("pazartesi günü");
                    break;
                case 3:
                    Console.WriteLine("salı günü");
                    break;
                case 4:
                    Console.WriteLine("çarşamba");
                    break;
                case 5:
                    Console.WriteLine(  "perşembe");
                    break;
                case 6:
                    Console.WriteLine("cuma");
                    break;
                case 7:
                    Console.WriteLine("cumartesi");
                    break;
                default:

                    Console.WriteLine("hatalı rakam girdiniz");
                        break;
            }   


        }
    }
}
