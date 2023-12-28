using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Bank_Updated
{
    internal class Program
    {
        // kayıt işlemi oluştur daha 
        // Kullanıcı bilgilerini al ve kaydet 
        // kullanıcı bilgileri private olsun
        //daha sonra bankada yapması gereken işlemleri oluştur
        // bakiye göstersin 
        // para yatırma olsun 
        // para transferi olsun
        // diğer işlemler olsun
        // diğer işlemlerde kart işlemleri ve destek işlemi olsun 
        // kullanıcı para yatırırken ve para çekerken bakiyesi olsun
        // kart işlemlerinde kartı kapatma işlemi ve kart derstek olsun
        // kart kapatma işlemi onaylanırsa en başta verilen kart numarasını sil ve yerine yeni bir kart numarası oluştur 
        // oluşturulan kart numarasını eskikart numarası yerine ata
        // kayıt işlemi için bakiyesine yatırılmak üzere 500 tl iste 
        //Kullanıcı bilgilerini görüntüle kısmı da olsun
        static void Main(string[] args)
        {
            string durum = "";
            string bankakartıdurum = "";
            int yas;
            int bakiye = 0;
            Console.WriteLine("Cash Bank'a Hoşgeldiniz !");
            Console.WriteLine("Kayıt işlemleri için aşşağıdaki bilgileri doldurunuz :");
            Console.Write("İsminiz :");string isim= Console.ReadLine();
            Console.Write("Soyisminiz :"); string soyisim= Console.ReadLine();
            Console.Write("Yaşınız :"); bas1: string b= Console.ReadLine(); if(int.TryParse(b, out yas)) { } else { Console.WriteLine("Lütfen Geçerli bir sayı giriniz !"); goto bas1; }
            bool c = true;
            while(c)
            {
                Console.Write("Çalışma durumunuz ");
                Console.Write("(Öğrenci, Çalışan, Doktor, avukat, mühendis, diğer -"); Console.Write(" lütfen küçük harflerle yazınız !)");
                string x = Console.ReadLine();
                switch(x)
                {
                    case "öğrenci":
                        durum = "ÖĞRENCİ"; c = false;
                        break;
                    case "doktor":
                        durum = "DOKTOR"; c = false;
                        break;
                    case "çalışan":
                        durum = "ÇALIŞAN"; c = false;
                        break;
                    case "avukat":
                        durum = "AVUKAT";
                        c   = false;
                        break;
                    case "mühendis":
                        durum = "MÜHENDİS";
                        c = false;
                        break;
                    case "diğer":
                        durum = "DİĞER";
                        c = false;
                            break;
                    default: Console.WriteLine("Lütfen geçerli bir meslek giriniz !"); break;

                }

            }
            bool a = true;
            while(a)
            {
                Console.Write("Daha önce banka hesabınınız var mıydı (var veya yok) :");
                string alim = Console.ReadLine();
                switch (alim)
                {
                    case "var":
                        bankakartıdurum = "VAR";
                        a=false; break;
                    case "yok":
                        bankakartıdurum = "YOK";
                        a=false; break;
                    default: Console.WriteLine("Lütfen geçerli bir cevap yazınız !"); break;
                }

            }
            Musteriislemleri musteri1 = new Musteriislemleri(yas,isim,soyisim,durum,bankakartıdurum,bakiye);    
            Console.WriteLine("Kayıt işleminiz başarıyla tamamlanmıştır");
            bool kontrol = true;
            while(kontrol)
            {
                Console.WriteLine("---------------------------------------------------");
                islemler();
                string secim= Console.ReadLine();
                switch(secim)
                {
                    case "1":
                        Console.WriteLine("Bakiyeniz :"+ " "+ bakiye);
                        break;
                    case "2":
                        bool kontrol1=true;
                        while (kontrol1)
                        {
                            Console.WriteLine("--------------------------------------------");
                            parayatırma();
                            string secim1 = Console.ReadLine();
                            switch (secim1)
                            {
                                case "1":
                                    kontrol1=false; break;
                                case "2":
                                    Console.WriteLine("Bakiyeniz :"+ " "+bakiye+"Tl");
                                    break;
                                case "3":
                                    Console.Write("Yatırmak istediğiniz miktarı giriniz :"); int miktar=int.Parse(Console.ReadLine());
                                    if (miktar < 0)
                                    {
                                        Console.WriteLine("Negatif bir sayı yatıramazsınız!");
                                        break;
                                    }
                                    else
                                    {
                                        bakiye += miktar;
                                    }
                                    break;
                                default: Console.WriteLine("Lütfen geçerli bir sayı giriniz !"); break;
                            }
                        }
                        break;
                    case "3":
                        bool kontrol2=true;
                        while (kontrol2)
                        {
                            paracekme();
                            string secim2 = Console.ReadLine();
                            switch (secim2)
                            {
                                case "1":
                                    kontrol2 = false; break;
                                case "2":
                                    Console.WriteLine("Bakiyeniz :"+" "+bakiye+"Tl");
                                    break;
                                case "3":
                                    Console.Write("Çekmek istediğiniz Miktari giriniz :"); int miktar2=int.Parse(Console.ReadLine());
                                    if(miktar2 < 0)
                                    {
                                        Console.WriteLine("Negatif bir sayı giremezsiniz !");
                                        break;
                                    }
                                    if (miktar2 > bakiye)
                                    {
                                        Console.WriteLine("Bakiyeniz yetersizdir !");
                                        break;
                                    }
                                    else
                                    {
                                        bakiye -= miktar2;
                                    }
                                    break;
                                default: Console.WriteLine("Lütfen geçerli bir sayı giriniz !"); break;
                            }
                        }
                        break;
                    case "4":
                        bool kontrol3=true;
                        while (kontrol3)
                        {
                            paratransferi();
                            string secim3 = Console.ReadLine();
                            switch(secim3)
                            {
                                case "1":
                                    kontrol3 = false; break;
                                case "2":
                                    Console.WriteLine("Bakiyeniz :"+" "+bakiye+"Tl");
                                    break;
                                case "3":
                                    Console.Write("Transfer etmek istediğiniz miktarı giriniz :"); int miktar3 = int.Parse(Console.ReadLine());
                                    if (miktar3 < 0)
                                    {
                                        Console.WriteLine("Negatif bir sayı giremezsiniz !");
                                        break;
                                    }
                                    if(miktar3 > bakiye)
                                    {
                                        Console.WriteLine("Yetersiz bakiye !");
                                        break;
                                    }
                                    Console.Write("Lütfen transfer yapmak istediğiniz kart numarasınız giriniz :"); string kartnumarasi= Console.ReadLine   ();
                                    
                                    if (kartnumarasi.Length!=11 && long.TryParse(kartnumarasi,out long kartb))
                                    {
                                        Console.WriteLine("Lütfen geçerli bir kart numarası giriniz !");
                                        break;
                                    }
                                    else
                                    {
                                        bakiye -= miktar3;
                                        Console.WriteLine("İşleminiz tamamlanmıştır !");
                                        break;
                                    }
                                default: Console.WriteLine("Lütfen geçerli bir sayı giriniz !"); break;
                            }
                        }
                        break;
                    case "5":
                        bool kontrol4 = true;
                        while (kontrol4)
                        {
                            digerislemler();
                            string secim4 = Console.ReadLine();
                            switch (secim4)
                            {
                                case "1":
                                    Console.WriteLine(" ----------- Kullanıcı bilgileri ----------");
                                    musteri1.kullanicibilgileri();
                                    break;
                                case "2":
                                    Console.WriteLine("Destek ekibimizle iletişime geçmek için Şu numarayı arayabilirsiniz :");
                                    Console.WriteLine("---05422645740---");
                                    break;
                                case "3":
                                    kontrol4 = false; break;
                                default: Console.WriteLine("Lütfen geçerli bir sayı giriniz !"); break;
                            }
                        }
                        break;
                    case "6":
                        kontrol= false;
                        break;

                }
            }
        }
        static void islemler()
        {
            Console.WriteLine("Yapmak istediğiniz İşlemi seçiniz :");
            Console.WriteLine("1-Bakiye göster");
            Console.WriteLine("2-Para yatırma ");
            Console.WriteLine("3-Para çekme");
            Console.WriteLine("4-Para transferi");
            Console.WriteLine("5-Diğer işlemler");
            Console.WriteLine("6-Çıkış");
        }
        static void parayatırma()
        {
            Console.WriteLine("1-Geri gelmek ");
            Console.WriteLine("2-Varolan bakiyeyi görüntüleme ");
            Console.WriteLine("3-para yatırma işlemine devam et");
        }
        static  void paracekme()
        {
            Console.WriteLine("1-Geri gelmek ");
            Console.WriteLine("2-Varolan bakiyeyi göster");
            Console.WriteLine("3-Para cekme islemine devam et");
        }
        static void paratransferi()
        {
            Console.WriteLine("1-Geri gelmek");
            Console.WriteLine("2-Bakiye göster");
            Console.WriteLine("3-Transfer işleminine devam et");
        }
        static void digerislemler()
        {
            Console.WriteLine("1-Kullanıcı bilgileri ");
            Console.WriteLine("2-Destek ");
            Console.WriteLine("3-Geri gel");
        }
    }
}
