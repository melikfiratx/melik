using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaOtomasyonu
{
    public class Sinema
    {
    }
    class kullaniciGirisi
    {
        public string ad;
        public string soyad;
        public string mail;
        public int sifre;

        public int Sifre
        {
            get { return sifre; }
            set
            {
                if (value.ToString().Length > 6)
                    sifre = value;
                else Console.WriteLine("Şifre En Az 6 Haneli Olmalıdır!");

            }
        }



        static List<kullaniciGirisi> KullaniciAdi = new List<kullaniciGirisi>();
        static kullaniciGirisi nesne = new kullaniciGirisi();


    }


    public class kartBilgileri
    {
        public ulong kartNo;
        public int ayYil;
        public int cvs;
        public int koltukNo;
        public int biletNo;

    }

    struct sinema
    {
        public string filmAdi;
        public int KoltukNo;
        public int tarih;
        public int seans;

    }
    class Kullanıcı
    {

        class program
        {



            static void Main(string[] args)
            {
                Console.WriteLine("Devam edebilmek için öncelikle kayıt olunuz.");
                kullaniciGirisi kullaniciBilgileri = new kullaniciGirisi();

                Console.WriteLine("Adınız:");
                kullaniciBilgileri.ad = Console.ReadLine();
                Console.WriteLine("Soyadınız:");
                kullaniciBilgileri.soyad = Console.ReadLine();
                Console.WriteLine("Mail Adresiniz:");
                kullaniciBilgileri.mail = Console.ReadLine();
                Console.WriteLine("Rakamlardan oluşan bir şifre oluşturunuz");
                kullaniciBilgileri.sifre = Convert.ToInt32(Console.ReadLine());

                try
                {
                    const string karsılama = "Merhabalar Programa Hoş Geldiniz...\n";
                    Console.Write(karsılama + "Lütfen İsminiz ve şifreniz ile giriş yapınız:");
                    string ad = Console.ReadLine();
                    int sifre = Convert.ToInt32(Console.ReadLine());




                    if (ad == kullaniciBilgileri.ad)
                    {


                        if (sifre == kullaniciBilgileri.sifre)
                        {


                            for (; ; )
                            {
                                Console.WriteLine("\nMenu\n" +
                                "1)Film Bul\n" +
                                "2)Bilet Satın Al\n" +
                                "3)Çıkış\n\n");
                                Console.Write("Menüden seçeneğinizi seçin :");
                                int menu = Convert.ToInt32(Console.ReadLine());
                                bool emir = true;
                                switch (menu)
                                {

                                    case 1:
                                        FilmBul();
                                        break;
                                    case 2:
                                        biletSatinAl();
                                        break;
                                    case 3:
                                        Console.WriteLine("Teşekkür Ederiz!");
                                        emir = false;
                                        break;
                                    default:
                                        Console.WriteLine("Yanlış Menü Değeri");
                                        break;
                                }


                            }

                        }
                    }
                    else if (sifre != kullaniciBilgileri.sifre)
                    {
                        Console.WriteLine("Yanlış şifre");
                    }
                }
                catch (Exception hata)
                {
                    Console.WriteLine("Yanlış Değer : " + hata);

                }

            }



            public static void FilmBul()
            {
                Console.WriteLine("Bir Kategori Seçin:");
                Console.WriteLine("1- Aksiyon");
                Console.WriteLine("2- Korku");
                Console.WriteLine("3- komedi");
                Console.WriteLine("4- Drama");
                Console.WriteLine("5- Bilim Kurgu");

                int kategori = Convert.ToInt32(Console.ReadLine());

                switch (kategori)
                {
                    case 1:
                        Console.WriteLine("Bullet Train Down");
                        Console.WriteLine("Country Line: No Fear");
                        Console.WriteLine("Arisaka");
                        Console.WriteLine("Kod 355");
                        Console.WriteLine("Airborne");
                        break;
                    case 2:
                        Console.WriteLine("Morg");
                        Console.WriteLine("Kutsal Geyiğin Ölümü");
                        Console.WriteLine("Testere: Jigsaw Efsanesi");
                        Console.WriteLine("Ölüm Günün Kutlu Olsun");
                        Console.WriteLine("Kapıdaki Sır");
                        Console.WriteLine("Korku Kayıtları");
                        Console.WriteLine("anne!");
                        Console.WriteLine("Kaçış Odası");
                        break;
                    case 3:
                        Console.WriteLine("Ayı Paddington 2");
                        Console.WriteLine("Kardeşim Benim");
                        Console.WriteLine("İçimdeki Güneş");
                        Console.WriteLine("Sen Kiminle Dans Ediyorsun?");
                        Console.WriteLine("Seni Gidi Seni");
                        Console.WriteLine("Yanlış Anlama");
                        Console.WriteLine("Umudun Öteki Yüzü");
                        Console.WriteLine("Kare");
                        break;
                    case 4:
                        Console.WriteLine("Mucize");
                        Console.WriteLine("Buğday");
                        Console.WriteLine("Kardan Adam");
                        Console.WriteLine("Kutsal Geyiğin Ölümü");
                        Console.WriteLine("Ayaz");
                        Console.WriteLine("Beginner");
                        Console.WriteLine("Yol Ayrımı");
                        Console.WriteLine("Doğu Ekspresinde Cinayet");
                        break;
                    case 5:
                        Console.WriteLine("King Car");
                        Console.WriteLine("We Are Not Alone");
                        Console.WriteLine("Project Skyquake");
                        Console.WriteLine("Final Offer");
                        Console.WriteLine("Mucize Oyuncaklar");
                        Console.WriteLine("Devil's Triangle");
                        Console.WriteLine("Hidden Memories");
                        Console.WriteLine("Lion-Girl");
                        break;
                }

                Console.WriteLine("Favori filmini seç ve bizimle paylaş, film çıkartmalarını mailine gönderelim... ");
                string FavfilmAdi = Console.ReadLine();
                Console.WriteLine("Mail Adresin:");
                string mail = Console.ReadLine();

                Console.ReadKey();

            }


            public static void biletSatinAl()
            {
                Console.WriteLine("Lütfen Sizin İçin Listelenen Filmlerden Seçin:" +
                    "\n(Gösterilen, Top 10 Film)");
                Console.WriteLine("1- Afacan Felix");
                Console.WriteLine("2- Ayrı Dünyalar");
                Console.WriteLine("3- Cumali Ceber 666");
                Console.WriteLine("4- Gizli Gerçek");
                Console.WriteLine("5- Koloni");
                Console.WriteLine("6- Masal Zamanı");
                Console.WriteLine("7- Şarkını Söyle 2");
                Console.WriteLine("8- Şöhretler Okulu");
                Console.WriteLine("9- Ayı Kardeşler: Macera Parkı");
                Console.WriteLine("10- Kaptan Pengu ve Arkadaşları 2");
                Console.WriteLine("Seçiminizi Yapınız:");
                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Seçiminiz: Afacan Felix");
                        string film1 = "Afacan Felix";

                        break;
                    case 2:
                        Console.WriteLine("Seçiminiz: Ayrı Dünyalar");
                        string film2 = "Ayrı Dünyalar";
                        break;
                    case 3:
                        Console.WriteLine("Seçiminiz: Cumali Ceber 666");
                        string film3 = "Cumali Ceber 666";
                        break;
                    case 4:
                        Console.WriteLine("Seçiminiz: Gizli Gerçek");
                        string film4 = "Gizli Gerçek";
                        break;
                    case 5:
                        Console.WriteLine("Seçiminiz: Koloni");
                        string film5 = "Koloni";
                        break;
                    case 6:
                        Console.WriteLine("Seçiminiz: Masal Zamanı");
                        string film6 = "Masal Zamanı";
                        break;
                    case 7:
                        Console.WriteLine("Seçiminiz: Şarkını Söyle 2");
                        string film7 = "Şarkını Söyle 2";
                        break;
                    case 8:
                        Console.WriteLine("Seçiminiz: Şöhretler Okulu");
                        string film8 = "Şöhretler Okulu";
                        break;
                    case 9:
                        Console.WriteLine("Seçiminiz: Ayı Kardeşler: Macera Parkı");
                        string film9 = "Ayı Kardeşler: Macera Parkı";
                        break;
                    case 10:
                        Console.WriteLine("Seçiminiz: Kaptan Pengu ve Arkadaşları 2");
                        string film10 = "Kaptan Pengu ve Arkadaşları 2";
                        break;
                }



                Console.WriteLine("Zaman Seç:");
                Console.WriteLine("1- Sabah");
                Console.WriteLine("2- Öğlen");
                Console.WriteLine("3- Akşam");
                Console.WriteLine("4- Gece");
                int zaman = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Tarih Seç:");
                int bugun = DateTime.Now.Year;
                int ay = DateTime.Now.Month;

                Console.WriteLine("Bugün günlerden " + bugun + "." + ay);
                Console.WriteLine("Biletinizi Almak İstediğiniz Günü Sayı Biçiminde Giriniz:");
                int biletGun = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Biletinizi Almak İstediğiniz Ayı Sayı Biçiminde Giriniz:");
                int biletAy = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Bilgileriniz İşleniyor....");

                Console.WriteLine("Lütfen Boş Koltuklardan Birini Seçiniz:");

                Random rastgele = new Random();
                for (int i = 0; i < 5; i++)
                {
                    int sayi = rastgele.Next(1, 50);
                    Console.WriteLine(sayi.ToString());
                    Console.WriteLine("seçiniz:");
                    int sec = Convert.ToInt32(Console.ReadLine());
                    if (sec == sayi)
                    {
                        Random Rucret = new Random();
                        for (int j = 0; j < 5; j++)
                        {
                            int ucret = rastgele.Next(50, 120);
                            Console.WriteLine(ucret.ToString());


                            Console.WriteLine("Koltuk Numaranız: " + sec + ". Bilet ücreti: " + ucret + " Lütfen Kart Bilgilerinizi Doğru Olarak Giriniz.");
                            kartBilgileri kartbilgisi = new kartBilgileri();
                            Console.WriteLine("Lütfen Kart Numarasını Giriniz:");
                            kartbilgisi.kartNo = (ulong)Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Lütfen Kartın üzerindeki Ay/Yıl seçeneğini giriniz:");
                            kartbilgisi.ayYil = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Lütfen kartın üzerindeki güvenlik kodunu giriniz:");
                            kartbilgisi.cvs = Convert.ToInt32(Console.ReadLine());


                            Console.WriteLine("İşlem Yapılıyor...");

                            Console.WriteLine();

                            Console.WriteLine("Kartınızdan " + ucret + "₺ çekilmiştir. İyi Eğlenceler Dileriz....");



                            break;
                        }
                    }
                    else Console.WriteLine("Koltuk Numaranızı Yanlış Girdiniz!");
                }


            }
        }



    }
}


