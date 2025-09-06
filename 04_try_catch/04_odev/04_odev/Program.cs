namespace _04_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
        BASLA:
            Console.WriteLine("cinsiyetiniz E/K");
            string cinsiyet = Convert.ToString(Console.ReadLine());
            Console.WriteLine("maaş giriniz");
            double maas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("yaşınızı giriniz");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("çalışılan gün sayısını giriniz");
            int caslismagünü = Convert.ToInt32(Console.ReadLine());
            
            try
            {
                switch (cinsiyet)
                {

                    case "e":
                    case "E":
                    case "ERKEK":
                    case "erkek":

                        if (yas > 60)
                        {
                            maas = maas * 10;
                            Console.WriteLine($"emekli oldunuz ikramiyeniz :{maas} ");

                        }
                        else if (caslismagünü > 6000)
                        {
                            maas = maas * 11;
                            Console.WriteLine($"emekli oldunuz ikramiyeniz :{maas} ");
                        }
                        else
                            Console.WriteLine("emekli olamadınız");


                        break;



                    case "k":
                    case "K":
                    case "KADIN":
                    case "kadın":



                        break;
                }
            }
            catch (Exception)
            {
                goto BASLA;
                Console.WriteLine("HATA MESSAGE");
            }
            

            

        }
    }
}
