namespace _04_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BANKAMATİK
            /*

            *   2500 tl parası olacak 
           Bir bankamatik düşünülerek tasarlanacak bir program  için 
           Kartlı işlem    1
           Kartsız işlem   2
           //********Kartlı işlem bölümü
           Şifre istenecek=> Şifre:ab18
           ==> şifrenin 3 defa yanlış olması halinde sistemden atılacak,değilse Ana Menü
           //*******************Ana Menü 
           Para Çekmek için    1
           Para yatırmak için  2
           Para Transferleri   3
           Eğitim Ödemeleri    4
           Ödemeler            5
           Bilgi Güncelleme    6
           //*********************Seçim 1************
           Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye
           Ana menüye dönmek için   9
           Çıkmak için             0
           //******************Seçim 2***********************
           Kredi Kartına   1
           Kendi Hesabınıza yatırmak için  2
           Ana Menü        9
           Çıkmak için     0
           //------------------------------------
           //----1
           Kredi kardı için en az 12 haneli kart numarasını girsin
           bakiye yeterli ise hesaptan kredi kartına para yatırılaca
           Ana Menü        9
           Çıkmak için     0
           //--------------------------
           //---2
           hesaba yatırılacak para değeri istenir veişlem gerçekleştirilir
           Ana Menü        9
           Çıkmak için     0
           //*****************************Seçim 3
           Başka Hesaba EFT    1
           Başka Hesaba Havale 2
           //---------------------------------
           //--1
           EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
           yatılacak para istenir ,hesap uygun ise işlem gerçekleşir değilse
           Ana Menü        9
           Çıkmak için     0
           //-----------------------------
           //---2
           hesap için 11 haneli hesap numarası işlemler doğru ise
           gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
           Ana Menü        9
           Çıkmak için     0
           //****************Seçim 4
           Eğitim Ödemeleri sayfası arızalı
           Ana Menü        9
           Çıkmak için     0
           //****************************Seçim 5
           Elektrik Faturası       1
           Telefon Faturası        2
           İnternet faturası       3
           Su Faturası             4
           OGS Ödemeleri           5
           //-----------------------------------------
           //---1 => bütün faturala için aşağıdaki şart yeterli
           fatura tutarı istenir, hesap uygun ise yatırılır değilse
           Ana Menü        9
           Çıkmak için     0
           //-----------------------------------
           //***************Seçim 6
           Şifre değiştirmek için 1
           Şifre değiştirme işlemi gerçekleştirilir
           Ana Menü        9
           Çıkmak için     0


          //********Kartsız işlem bölümü

          //*******************Ana Menü 
          CepBank Para Çekmek 1
           Para yatırmak için  2
           Kredi Kartı Ödeme   3
           Eğitim Ödemeleri    4
           Ödemeler            5

           //*********************Seçim 1************
           TC kimlik no ve cep telefonu numarasını girsin doğruysa kişiye 1000 ödeme
           Yapın yanlış ise 3 kere daha denetin Hakkı bittiğinde 1 saat kilitleyin.
Ana menüye dönmek için   9
           Çıkmak için              0
           //******************Seçim 2***********************
           Nakit ödeme     1
           Hesaptan ödeme  2
           Ana Menü        9
           Çıkmak için     0
           //------------------------------------
           //----1
        Kredi kartı için en az 12 haneli kart numarasını girsin

        Tc kimlik numarasını girsin. 11 hane olup olmadığını kontrol edin.
           Nakit olarak ödeme gerçekleştirin.
           Ana Menü        9
           Çıkmak için     0
           //--------------------------
           //---2
           Kredi kartı için en az 12 haneli kart numarasını girsin
Hesap numarasını girsin

           Ana Menü        9
           Çıkmak için     0
           //*****************************Seçim 3
           Başka Hesaba EFT    1
           Başka Hesaba Havale 2
           //---------------------------------
           //--1
           EFT numarası istenecek ve başında tr olmalı ve sonrasında 12 haneli sayı işlemleri doğru ise
           yatılacak para istenir, hesap uygun ise işlem gerçekleşir değilse
           Ana Menü        9
           Çıkmak için     0
           //-----------------------------
           //---2
           hesap için 11 haneli hesap numarası işlemler doğru ise
           gönderilecek para miktarı, hesap uygun ise transfer olacak ,değilse
           Ana Menü        9
           Çıkmak için     0
           //****************Seçim 4
           Eğitim Ödemeleri sayfası arızalı
           Ana Menü        9
           Çıkmak için     0
           //****************************Seçim 5
           Elektrik Faturası       1
           Telefon Faturası        2
           İnternet faturası       3
           Su Faturası             4
           OGS Ödemeleri           5
           //-----------------------------------------
           //---1 => bütün faturala için aşağıdaki şart yeterli
           fatura tutarı istenir, hesap uygun ise yatırılır değilse
           */
            #endregion

            int bakiye = 2500;

            bool uygulamaAcik = true;

            string dogruSifre = "ab18";

            Console.WriteLine("********** BANKAMATİK UYGULAMASI **********\n");

            while (uygulamaAcik)
            {
                Console.WriteLine("Ana menüye hoş geldiniz!");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("1- Kartlı İşlem");
                Console.WriteLine("2- Kartsız İşlem");
                Console.WriteLine("0- Çıkış");
                Console.Write("Seçiminiz: ");
                string anaSecim = Console.ReadLine();

                if (anaSecim == "1")
                {
                    int sifreHakki = 3;
                    bool sifreDogruMu = false;

                    while (sifreHakki > 0)
                    {
                        Console.Write("Lütfen şifrenizi giriniz: ");
                        string girilenSifre = Console.ReadLine();

                        if (girilenSifre == dogruSifre)
                        {
                            sifreDogruMu = true;
                            break;
                        }
                        else
                        {
                            sifreHakki--;
                            Console.WriteLine("Hatalı şifre. Kalan hakkınız: " + sifreHakki);
                        }
                    }

                    if (!sifreDogruMu)
                    {
                        Console.WriteLine("3 defa hatalı şifre girdiniz. Sistemden çıkış yapılıyor...");
                        uygulamaAcik = false;
                    }
                    else
                    {
                        bool kartliMenu = true;
                        while (kartliMenu)
                        {
                            Console.WriteLine("\nKartlı İşlemler Ana Menü:");
                            Console.WriteLine("1- Para Çekme");
                            Console.WriteLine("2- Para Yatırma");
                            Console.WriteLine("3- Para Transferleri");
                            Console.WriteLine("4- Eğitim Ödemeleri");
                            Console.WriteLine("5- Ödemeler");
                            Console.WriteLine("6- Bilgi Güncelleme (Şifre Değiştirme)");
                            Console.WriteLine("9- Ana Menüye Dön");
                            Console.WriteLine("0- Çıkış");
                            Console.Write("Seçiminiz: ");
                            string kartliSecim = Console.ReadLine();

                            if (kartliSecim == "1")
                            {
                                Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                                string cekilecekTutarStr = Console.ReadLine();
                                int cekilecekTutar = 0;

                                try
                                {
                                    cekilecekTutar = int.Parse(cekilecekTutarStr);

                                    if (cekilecekTutar <= 0)
                                    {
                                        Console.WriteLine("Geçersiz tutar girdiniz!");
                                    }
                                    else
                                    {
                                        if (bakiye >= cekilecekTutar)
                                        {
                                            bakiye -= cekilecekTutar;
                                            Console.WriteLine("Para çekme işlemi başarılı. Güncel bakiye: " + bakiye);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yetersiz bakiye.");
                                        }
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("Geçersiz tutar girdiniz!");
                                }

                                Console.WriteLine("9- Ana Menü, 0- Çıkış");
                                Console.Write("Seçiminiz: ");
                                string altSecim = Console.ReadLine();
                                if (altSecim == "0")
                                {
                                    uygulamaAcik = false;
                                    kartliMenu = false;
                                }
                            }
                            else if (kartliSecim == "2")
                            {
                                bool paraYatirmaMenu = true;
                                while (paraYatirmaMenu)
                                {
                                    Console.WriteLine("\nPara Yatırma Seçenekleri:");
                                    Console.WriteLine("1- Kredi Kartına");
                                    Console.WriteLine("2- Kendi Hesabınıza");
                                    Console.WriteLine("9- Ana Menüye Dön");
                                    Console.WriteLine("0- Çıkış");
                                    Console.Write("Seçiminiz: ");
                                    string yatirmaSecim = Console.ReadLine();

                                    if (yatirmaSecim == "1")
                                    {
                                        Console.Write("Kredi kartı numarasını giriniz (en az 12 hane): ");
                                        string krediKartNo = Console.ReadLine();
                                        if (krediKartNo.Length < 12)
                                        {
                                            Console.WriteLine("Kredi kartı numarası 12 haneden az olamaz!");
                                        }
                                        else
                                        {
                                            Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                                            string yatirilacakTutarStr = Console.ReadLine();
                                            int yatirilacakTutar = 0;

                                            try
                                            {
                                                yatirilacakTutar = int.Parse(yatirilacakTutarStr);

                                                if (yatirilacakTutar <= 0)
                                                {
                                                    Console.WriteLine("Geçersiz tutar girdiniz!");
                                                }
                                                else
                                                {
                                                    if (bakiye >= yatirilacakTutar)
                                                    {
                                                        bakiye -= yatirilacakTutar;
                                                        Console.WriteLine("Kredi kartına ödeme başarılı. Güncel bakiye: " + bakiye);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Yetersiz bakiye.");
                                                    }
                                                }
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Geçersiz tutar girdiniz!");
                                            }
                                        }
                                    }
                                    else if (yatirmaSecim == "2")
                                    {
                                        Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                                        string yatirHesapStr = Console.ReadLine();
                                        int yatirHesap = 0;
                                        try
                                        {
                                            yatirHesap = int.Parse(yatirHesapStr);
                                            if (yatirHesap <= 0)
                                            {
                                                Console.WriteLine("Geçersiz tutar girdiniz!");
                                            }
                                            else
                                            {
                                                bakiye += yatirHesap;
                                                Console.WriteLine("Para yatırma işlemi başarılı. Güncel bakiye: " + bakiye);
                                            }
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Geçersiz tutar girdiniz!");
                                        }
                                    }
                                    else if (yatirmaSecim == "9")
                                    {
                                        paraYatirmaMenu = false;
                                    }
                                    else if (yatirmaSecim == "0")
                                    {
                                        uygulamaAcik = false;
                                        paraYatirmaMenu = false;
                                        kartliMenu = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Geçersiz seçim!");
                                    }
                                }
                            }
                            else if (kartliSecim == "3")
                            {
                                bool transferMenu = true;
                                while (transferMenu)
                                {
                                    Console.WriteLine("\nPara Transfer Seçenekleri:");
                                    Console.WriteLine("1- Başka Hesaba EFT");
                                    Console.WriteLine("2- Başka Hesaba Havale");
                                    Console.WriteLine("9- Ana Menüye Dön");
                                    Console.WriteLine("0- Çıkış");
                                    Console.Write("Seçiminiz: ");
                                    string transferSecim = Console.ReadLine();

                                    if (transferSecim == "1")
                                    {
                                        Console.Write("EFT Numarası (başında 'TR' + 12 hane) giriniz: ");
                                        string eftNo = Console.ReadLine();

                                        if (eftNo.StartsWith("TR") && eftNo.Length == 14)
                                        {
                                            Console.Write("Göndermek istediğiniz tutar: ");
                                            string eftTutarStr = Console.ReadLine();
                                            int eftTutar = 0;
                                            try
                                            {
                                                eftTutar = int.Parse(eftTutarStr);

                                                if (eftTutar <= 0)
                                                {
                                                    Console.WriteLine("Geçersiz tutar!");
                                                }
                                                else
                                                {
                                                    if (bakiye >= eftTutar)
                                                    {
                                                        bakiye -= eftTutar;
                                                        Console.WriteLine("EFT işlemi başarılı. Güncel bakiye: " + bakiye);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Yetersiz bakiye.");
                                                    }
                                                }
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Geçersiz tutar girdiniz!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("EFT numarası hatalı!");
                                        }
                                    }
                                    else if (transferSecim == "2")
                                    {
                                        Console.Write("Hesap numarası (11 hane) giriniz: ");
                                        string hesapNo = Console.ReadLine();

                                        if (hesapNo.Length == 11)
                                        {
                                            Console.Write("Göndermek istediğiniz tutar: ");
                                            string havaleTutarStr = Console.ReadLine();
                                            int havaleTutar = 0;
                                            try
                                            {
                                                havaleTutar = int.Parse(havaleTutarStr);

                                                if (havaleTutar <= 0)
                                                {
                                                    Console.WriteLine("Geçersiz tutar!");
                                                }
                                                else
                                                {
                                                    if (bakiye >= havaleTutar)
                                                    {
                                                        bakiye -= havaleTutar;
                                                        Console.WriteLine("Havale işlemi başarılı. Güncel bakiye: " + bakiye);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Yetersiz bakiye.");
                                                    }
                                                }
                                            }
                                            catch
                                            {
                                                Console.WriteLine("Geçersiz tutar girdiniz!");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hesap numarası 11 hane olmalıdır!");
                                        }
                                    }
                                    else if (transferSecim == "9")
                                    {
                                        transferMenu = false;
                                    }
                                    else if (transferSecim == "0")
                                    {
                                        uygulamaAcik = false;
                                        transferMenu = false;
                                        kartliMenu = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Geçersiz seçim!");
                                    }
                                }
                            }
                            else if (kartliSecim == "4")
                            {
                                Console.WriteLine("Eğitim Ödemeleri sayfası arızalı.");
                                Console.WriteLine("9- Ana Menü, 0- Çıkış");
                                string altSecim = Console.ReadLine();
                                if (altSecim == "0")
                                {
                                    uygulamaAcik = false;
                                    kartliMenu = false;
                                }
                            }
                            else if (kartliSecim == "5")
                            {
                                bool odemeMenu = true;
                                while (odemeMenu)
                                {
                                    Console.WriteLine("\nÖdemeler Menüsü:");
                                    Console.WriteLine("1- Elektrik Faturası");
                                    Console.WriteLine("2- Telefon Faturası");
                                    Console.WriteLine("3- İnternet Faturası");
                                    Console.WriteLine("4- Su Faturası");
                                    Console.WriteLine("5- OGS Ödemeleri");
                                    Console.WriteLine("9- Ana Menüye Dön");
                                    Console.WriteLine("0- Çıkış");
                                    Console.Write("Seçiminiz: ");
                                    string odemeSecim = Console.ReadLine();

                                    if (
                                        odemeSecim == "1" ||
                                        odemeSecim == "2" ||
                                        odemeSecim == "3" ||
                                        odemeSecim == "4" ||
                                        odemeSecim == "5"
                                    )
                                    {
                                        Console.Write("Fatura tutarını giriniz: ");
                                        string faturaTutarStr = Console.ReadLine();
                                        int faturaTutar = 0;
                                        try
                                        {
                                            faturaTutar = int.Parse(faturaTutarStr);

                                            if (faturaTutar <= 0)
                                            {
                                                Console.WriteLine("Geçersiz tutar!");
                                            }
                                            else
                                            {
                                                if (bakiye >= faturaTutar)
                                                {
                                                    bakiye -= faturaTutar;
                                                    Console.WriteLine("Fatura ödendi. Güncel bakiye: " + bakiye);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Yetersiz bakiye.");
                                                }
                                            }
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Geçersiz tutar!");
                                        }
                                    }
                                    else if (odemeSecim == "9")
                                    {
                                        odemeMenu = false;
                                    }
                                    else if (odemeSecim == "0")
                                    {
                                        odemeMenu = false;
                                        kartliMenu = false;
                                        uygulamaAcik = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Geçersiz seçim!");
                                    }
                                }
                            }
                            else if (kartliSecim == "6")
                            {
                                Console.WriteLine("Şifre değiştirmek için '1' e basınız, aksi hâlde ana menüye dönülür.");
                                string sifreDegistirSecim = Console.ReadLine();
                                if (sifreDegistirSecim == "1")
                                {
                                    Console.Write("Yeni şifrenizi giriniz: ");
                                    string yeniSifre = Console.ReadLine();
                                    if (!string.IsNullOrEmpty(yeniSifre))
                                    {
                                        dogruSifre = yeniSifre;
                                        Console.WriteLine("Şifreniz başarıyla güncellendi!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Şifre boş olamaz!");
                                    }
                                }
                            }
                            else if (kartliSecim == "9")
                            {
                                kartliMenu = false;
                            }
                            else if (kartliSecim == "0")
                            {
                                kartliMenu = false;
                                uygulamaAcik = false;
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz seçim!");
                            }
                        }
                    }
                }
                else if (anaSecim == "2")
                {
                    bool kartsizMenu = true;
                    while (kartsizMenu)
                    {
                        Console.WriteLine("\nKartsız İşlem Ana Menü:");
                        Console.WriteLine("1- CepBank Para Çekmek");
                        Console.WriteLine("2- Para Yatırma");
                        Console.WriteLine("3- Kredi Kartı Ödeme");
                        Console.WriteLine("4- Eğitim Ödemeleri");
                        Console.WriteLine("5- Ödemeler");
                        Console.WriteLine("9- Ana Menüye Dön");
                        Console.WriteLine("0- Çıkış");
                        Console.Write("Seçiminiz: ");
                        string kartsizSecim = Console.ReadLine();

                        if (kartsizSecim == "1")
                        {
                            int cepbankHak = 3;
                            bool isCepbankOk = false;

                            while (cepbankHak > 0)
                            {
                                Console.Write("TC Kimlik No (11 hane): ");
                                string tckn = Console.ReadLine();

                                Console.Write("Cep Telefon No (10 hane): ");
                                string cepTel = Console.ReadLine();

                                if (tckn.Length == 11 && cepTel.Length == 10)
                                {
                                    isCepbankOk = true;
                                    break;
                                }
                                else
                                {
                                    cepbankHak--;
                                    Console.WriteLine("Bilgiler hatalı. Kalan deneme hakkı: " + cepbankHak);
                                }
                            }

                            if (!isCepbankOk)
                            {
                                Console.WriteLine("Hakkınız bitti. 1 saat kilitlenmiştir.");
                            }
                            else
                            {
                                Console.WriteLine("CepBank üzerinden 1000 TL ödemenizi alabilirsiniz.");
                            }

                            Console.WriteLine("9- Ana Menü, 0- Çıkış");
                            string altSecim = Console.ReadLine();
                            if (altSecim == "0")
                            {
                                kartsizMenu = false;
                                uygulamaAcik = false;
                            }
                        }
                        else if (kartsizSecim == "2")
                        {
                            bool kartsizYatirMenu = true;
                            while (kartsizYatirMenu)
                            {
                                Console.WriteLine("\nKartsız Para Yatırma:");
                                Console.WriteLine("1- Nakit Ödeme");
                                Console.WriteLine("2- Hesaptan Ödeme");
                                Console.WriteLine("9- Ana Menüye Dön");
                                Console.WriteLine("0- Çıkış");
                                Console.Write("Seçiminiz: ");
                                string kartsizYatirSecim = Console.ReadLine();

                                if (kartsizYatirSecim == "1")
                                {
                                    Console.Write("Kredi kartı numarası (en az 12 hane) giriniz: ");
                                    string kkartNo = Console.ReadLine();
                                    if (kkartNo.Length < 12)
                                    {
                                        Console.WriteLine("Kart numarası en az 12 hane olmalı!");
                                    }
                                    else
                                    {
                                        Console.Write("TC Kimlik Numaranızı (11 hane) giriniz: ");
                                        string tckn = Console.ReadLine();
                                        if (tckn.Length == 11)
                                        {
                                            Console.WriteLine("Nakit olarak ödeme kabul edildi (örnek).");
                                        }
                                        else
                                        {
                                            Console.WriteLine("TC kimlik numarası 11 haneli olmalı!");
                                        }
                                    }
                                }
                                else if (kartsizYatirSecim == "2")
                                {
                                    Console.Write("Kredi kartı numarası (en az 12 hane) giriniz: ");
                                    string kkartNo = Console.ReadLine();
                                    if (kkartNo.Length < 12)
                                    {
                                        Console.WriteLine("Kart numarası en az 12 hane olmalı!");
                                    }
                                    else
                                    {
                                        Console.Write("Hesap numarası giriniz: ");
                                        string hesapNo = Console.ReadLine();
                                        Console.WriteLine("Hesaptan ödeme işlemi tamamlandı (örnek).");
                                    }
                                }
                                else if (kartsizYatirSecim == "9")
                                {
                                    kartsizYatirMenu = false;
                                }
                                else if (kartsizYatirSecim == "0")
                                {
                                    kartsizYatirMenu = false;
                                    kartsizMenu = false;
                                    uygulamaAcik = false;
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz seçim!");
                                }
                            }
                        }
                        else if (kartsizSecim == "3")
                        {
                            bool kartsizTransfer = true;
                            while (kartsizTransfer)
                            {
                                Console.WriteLine("\nKredi Kartı Ödeme Menüsü:");
                                Console.WriteLine("1- Başka Hesaba EFT");
                                Console.WriteLine("2- Başka Hesaba Havale");
                                Console.WriteLine("9- Ana Menüye Dön");
                                Console.WriteLine("0- Çıkış");
                                Console.Write("Seçiminiz: ");
                                string transferSecim = Console.ReadLine();

                                if (transferSecim == "1")
                                {
                                    Console.Write("EFT Numarası (başında 'TR' + 12 hane) giriniz: ");
                                    string eftNo = Console.ReadLine();
                                    if (eftNo.StartsWith("TR") && eftNo.Length == 14)
                                    {
                                        Console.Write("Göndermek istediğiniz tutar: ");
                                        string eftTutarStr = Console.ReadLine();
                                        int eftTutar = 0;
                                        try
                                        {
                                            eftTutar = int.Parse(eftTutarStr);

                                            if (eftTutar <= 0)
                                            {
                                                Console.WriteLine("Geçersiz tutar!");
                                            }
                                            else
                                            {
                                                if (bakiye >= eftTutar)
                                                {
                                                    bakiye -= eftTutar;
                                                    Console.WriteLine("EFT işlemi başarılı. Güncel bakiye: " + bakiye);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Yetersiz bakiye.");
                                                }
                                            }
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Geçersiz tutar girdiniz!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("EFT numarası hatalı!");
                                    }
                                }
                                else if (transferSecim == "2")
                                {
                                    Console.Write("Hesap numarası (11 hane) giriniz: ");
                                    string hesapNo = Console.ReadLine();
                                    if (hesapNo.Length == 11)
                                    {
                                        Console.Write("Göndermek istediğiniz tutar: ");
                                        string havaleTutarStr = Console.ReadLine();
                                        int havaleTutar = 0;
                                        try
                                        {
                                            havaleTutar = int.Parse(havaleTutarStr);

                                            if (havaleTutar <= 0)
                                            {
                                                Console.WriteLine("Geçersiz tutar!");
                                            }
                                            else
                                            {
                                                if (bakiye >= havaleTutar)
                                                {
                                                    bakiye -= havaleTutar;
                                                    Console.WriteLine("Havale işlemi başarılı. Güncel bakiye: " + bakiye);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Yetersiz bakiye.");
                                                }
                                            }
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Geçersiz tutar!");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hesap numarası 11 hane olmalıdır!");
                                    }
                                }
                                else if (transferSecim == "9")
                                {
                                    kartsizTransfer = false;
                                }
                                else if (transferSecim == "0")
                                {
                                    kartsizTransfer = false;
                                    kartsizMenu = false;
                                    uygulamaAcik = false;
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz seçim!");
                                }
                            }
                        }
                        else if (kartsizSecim == "4")
                        {
                            Console.WriteLine("Eğitim ödemeleri sayfası arızalı.");
                            Console.WriteLine("9- Ana Menü, 0- Çıkış");
                            string altSecim = Console.ReadLine();
                            if (altSecim == "0")
                            {
                                kartsizMenu = false;
                                uygulamaAcik = false;
                            }
                        }
                        else if (kartsizSecim == "5")
                        {
                            bool kartsizOdeme = true;
                            while (kartsizOdeme)
                            {
                                Console.WriteLine("\nKartsız Ödemeler Menüsü:");
                                Console.WriteLine("1- Elektrik Faturası");
                                Console.WriteLine("2- Telefon Faturası");
                                Console.WriteLine("3- İnternet Faturası");
                                Console.WriteLine("4- Su Faturası");
                                Console.WriteLine("5- OGS Ödemeleri");
                                Console.WriteLine("9- Ana Menüye Dön");
                                Console.WriteLine("0- Çıkış");
                                Console.Write("Seçiminiz: ");
                                string odemeSecim = Console.ReadLine();

                                if (odemeSecim == "1" || odemeSecim == "2" || odemeSecim == "3" || odemeSecim == "4" || odemeSecim == "5")
                                {
                                    Console.Write("Fatura tutarını giriniz: ");
                                    string faturaTutarStr = Console.ReadLine();
                                    int faturaTutar = 0;
                                    try
                                    {
                                        faturaTutar = int.Parse(faturaTutarStr);
                                        if (faturaTutar <= 0)
                                        {
                                            Console.WriteLine("Geçersiz tutar!");
                                        }
                                        else
                                        {
                                            if (bakiye >= faturaTutar)
                                            {
                                                bakiye -= faturaTutar;
                                                Console.WriteLine("Fatura ödendi. Güncel bakiye: " + bakiye);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Yetersiz bakiye.");
                                            }
                                        }
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Geçersiz tutar girdiniz!");
                                    }
                                }
                                else if (odemeSecim == "9")
                                {
                                    kartsizOdeme = false;
                                }
                                else if (odemeSecim == "0")
                                {
                                    kartsizOdeme = false;
                                    kartsizMenu = false;
                                    uygulamaAcik = false;
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz seçim!");
                                }
                            }
                        }
                        else if (kartsizSecim == "9")
                        {
                            kartsizMenu = false;
                        }
                        else if (kartsizSecim == "0")
                        {
                            kartsizMenu = false;
                            uygulamaAcik = false;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz seçim!");
                        }
                    }
                }
                else if (anaSecim == "0")
                {
                    uygulamaAcik = false;
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim!");
                }
            }

            Console.WriteLine("Uygulamadan çıkılıyor. İyi günler dileriz.");

        }
    }
}
