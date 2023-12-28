using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Yazı_yazma_hızı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yanliskelimesayisi = 0;

            int dogrukelimesayisi = 0; //değişken

            int dogruharfsayisi = 0; //değişken

            int yanlisharfsayisi= 0; //değişken

            //Aşşağıda kelime seçmede kullanılıcak olan kelimeleri seçer

            string[] isimler = { "merhaba","bugün","güzel","bir","gün","Güneş","parlıyor","ve","hava","çok","güzel","dışarıda","kuşlar","ötüşüyor","ve","insanlar","mutlu","parkta","çocuklar","oynuyor","gülüyorlar","ve","keyifli","zaman","geçiriyorlar","Yakındaki","kafe","taze","kahve","kokusuyla","dolup","taşıyor","Barista","güleryüzlü","ve","içten","bir","şekilde","siparişleri","hazırlıyor","Kitap","okuyan","insanlar","sessizce","sayfalarını","çeviriyor","ve","huzurlu","bir","atmosfer","oluşturuyorlar",

                                 "akşam","saatine","doğru","güneş","batıyor","ve","gökyüzü","rengarenk","bir","hal","alıyor","akşam","yemeği","için","sevdiklerinizle","bir","araya","gelip","lezzetli","yemekler","yiyorsunuz","Masada","sohbetler","gülüşmeler","ve","anılar","paylaşılıyor","Yemek","sonrasında","tatlı","bir","tat","ile","damağınızı","şenlendiriyorsunuz",

                                 "gecenin","ilerleyen","saatlerinde","yıldızlar","parlıyor","gökyüzü","sonsuz","gibi","görünüyor","sessizlik","hakim","ve","doğanın","doğal","seslerini","duyuyorsunuz","Rüzgar","hafifçe","esiyor","ve","ağaçlar","hışırdıyor","uzun","bir","günün","ardından","yavaş","yavaş","uyumaya","hazırlanıyorsunuz","Yastığınıza","başınızı","koyduğunuzda","huzurla","uyuyakalıyorsunuz","yeni",

                                 "sabah","uyandığınızda","güne","taze","bir","başlangıç","yapmak","için","hazırsınız","Yeni","maceralar","yeni","deneyimler","ve","yeni","keşifler","sizi","bekliyor","Hayatın","sunduğu","güzellikleri","keşfetmeye","devam","ediyorsunuz","Her","gün","bir","öğrenme","fırsatı","ve","büyüme","şansı","olarak","karşınıza","çıkıyor",

                                 "hayatta","minnettarlıkla","dolu","olmak","küçük","mutlulukları","kutlamak","ve","sevdiklerinize","değer","vermek","sizi","gerçek","anlamda","zengin","kılacaktır","Şimdi","yeni","bir","günün","başlangıcı","ve","yeni","bir","maceranın","başlangıcı","için","hazırsınız","Haydi","yeni","güzelliklerle","dolu","bir","gün","sizi","bekliyor",
                                 "elma", "armut", "karpuz", "portakal", "muz", "üzüm", "çilek", "kiraz", "şeftali", "erik", "mandalina", "limon", "greyfurt", "kivi", "ananas", "nar", "vişne", "ceviz", "fındık", "badem", "fıstık", "fındık", "kestane", "zeytin", "şam", "zeytin", "mantar", "patates", "havuç", "domates", "salatalık", "biber", "soğan", "sarımsak", "brokoli", "karnabahar", "ıspanak", "marul", "taze", "soğan", "pırasa", "kırmızı", "lahana", "beyaz", "lahana", "semiz", "ot", "maydanoz", "taze", "nane", "taze", "tutku", "otu", "rezene", "dereotu", "rezene", "tarhun", "taze", "hardal", "roka", "dulavrat", "otu", "roka", "turp", "taze", "soğan", "yer", "elması", "kereviz", "kereviz", "sapı", "lahana", "sapı", "biberiye", "kekik", "fesleğen", "defne", "adaçayı", "nane", "kurutulmuş", "biber", "salça", "domates", "sos", "hardal", "ketçap", "sirke", "zeytinyağı", "sızma", "zeytinyağı", "soya", "sos", "limon", "suyu", "portakal", "suyu", "nar", "suyu", "greyfurt", "suyu", "vişne", "suyu", "üzüm", "suyu", "elma", "suyu", "armut", "suyu", "kızılcık", "suyu", "kiraz", "suyu", "ayran", "süt", "yoğurt", "taze", "peynir", "beyaz", "peynir", "eski", "peynir", "kaşar", "peynir", "çedar", "peynir", "tulum", "peynir", "lor", "peynir", "salam", "sosis", "pastırma", "sucuk", "kavurma", "mantar", "zeytin", "çekirdeği", "fıstık", "çekirdeği", "kabak", "çekirdeği", "ayçiçek", "çekirdeği", "susam", "çekirdeği", "çörek", "otu", "kimyon", "karabiber", "kırmızı", "biber", "kakule", "tarçın", "karanfil", "köri", "rezene", "zerdeçal", "hardal", "toz", "şeker", "tuz", "tuzlu", "sos", "soya", "sos", "hardal", "sos", "ketçap", "sos", "sirke", "sos", "mayonez", "sos", "sarımsak", "sos", "maydanoz", "sos", "yoğurt", "sos", "tahin", "sos", "acı", "sos", "barbekü", "sos", "soğan", "sos", "acı", "biber", "sos", "salsa", "sos", "sızma", "zeytinyağı", "taze", "zeytin", "zeytin", "salamura", "reçel", "bal", "pekmez", "marmelat", "reçine", "akasya", "reçine", "çam", "reçine", "sakız", "şekerleme", "lokum", "akide", "şeker", "şeker", "pare", "şeker", "çikolata", "çikolata", "kakao", "kakao", "toz", "vanilya", "tarçın", "baharat", "kimyon", "baharat", "kekik", "baharat", "biberiye", "baharat", "nane", "baharat", "defne", "baharat", "adaçayı", "baharat", "hardal", "baharat", "karanfil", "baharat", "köri", "baharat", "zerdeçal", "baharat", "kimyon", "tane", "kekik", "tane", "biberiye", "tane", "nane", "tane", "defne", "tane", "adaçayı", "tane", "hardal", "tane", "karanfil", "tane", "köri", "tane", "zerdeçal", "tane", "kimyon", "tane", "kekik", "tane", "biberiye", "tane", "nane", "tane", "defne", "tane", "adaçayı", "tane", "hardal", "tane", "karanfil", "tane", "köri", "tane", "zerdeçal", "tane", "kimyon", "tane", "kekik", "tane", "biberiye", "tane", "nane", "tane", "defne", "tane", "adaçayı", "tane", "hardal", "tane", "karanfil", "tane", "köri", "tane", "zerdeçal", "tane", "kimyon", "tane", "kekik", "tane", "biberiye", "tane", "nane", "tane", "defne", "tane", "adaçayı", "tane", "hardal", "tane", "karanfil", "tane", "köri", "tane", "zerdeçal", "tane", "kimyon", "tane", "kekik", "tane", "biberiye", "tane", "n"

 };
            
            Random newrandom = new Random(); // yeni random nesnesi oluşturur

            Stopwatch time = new Stopwatch(); // yeni kronometre nesnesi oluşturur

            string randomfirst = isimler[newrandom.Next(isimler.Length)];

            string randomname = randomfirst.ToLower();

            Console.WriteLine("Lütfen başlamak için enter tuşuna basınız ");
            Console.ReadKey();
            
            bool kontrol = true; //Döngünün kontrol edilmesi için gerekli olan değişkeni oluşturur

            start: //Buradaki start değişkenine gelir 

            while (kontrol) //İçerisi true iken
            {
                time.Start(); //Kronometreyi başlatır 

                Console.WriteLine(randomname);

                string kullanicigirdisi = Console.ReadLine(); //Kullanıcıdan Bir değer girmesini ister 

                Console.Clear();

                while (time.Elapsed.TotalMinutes<1)
                {
                    string randomkelime = isimler[newrandom.Next(isimler.Length)];

                    if (randomkelime==randomfirst)
                    {
                        randomkelime = isimler[newrandom.Next(isimler.Length)];
                    }

                    string randomlar = randomkelime.ToLower();

                    string oncekikelime = randomlar;


                    Console.WriteLine(randomlar); // Ekrana bu kelimeyi yazdırır

                    kullanicigirdisi = Console.ReadLine(); //Kullanıcıdan Bir değer girmesini ister 
                    

                    if (kullanicigirdisi == randomlar ) //Eğer kullanıcının girdiği kelime seçilen kelime ile aynı ise
                    {
                        dogruharfsayisi += randomlar.Length; //randomlar değikeninin içerdiği harf sayısı kadar harfi dogru girilen harflerin içerisine ekle 

                        dogrukelimesayisi++; //Doğru dogruharfsayisini bir arttırır 

                    }

                    else //Kullanıcının girdiği kelime seçilen kelimeye eşit değilse 
                    {
                        Console.Beep(); //Beep sesini çıkartır 

                        if (randomlar.Length<kullanicigirdisi.Length)
                        {
                            for (int i = 0; i < randomlar.Length-1; i++)
                            {
                                if (randomlar[i] == kullanicigirdisi[i])
                                {
                                    dogruharfsayisi++;
                                }
                                else
                                {
                                    yanlisharfsayisi++;
                                }
                            }
                        }
                        else if (randomlar.Length>=kullanicigirdisi.Length)
                        {
                            for (int i = 0; i < kullanicigirdisi.Length-1; i++)
                            {
                                if (randomlar[i] == kullanicigirdisi[i])
                                {
                                    dogruharfsayisi++;
                                }
                                else
                                {
                                    yanlisharfsayisi++;
                                }
                            }
                        }
                        
                        yanliskelimesayisi++; // yanlisharfsayisi'nı bir arttırır

                    }

                    Console.Clear();
                }
                time.Stop(); //Kronometreyi durdurur
                time.Reset();


                Console.WriteLine("\tSkorunuz !");
                Console.WriteLine("Doğru yazdığınız kelime sayısı :"+" "+dogrukelimesayisi);
                Console.WriteLine("yanlış yazdığınız kelime sayısı :"+" "+yanliskelimesayisi);
                Console.WriteLine("Doğru yazdığınız harf sayısı :"+" "+dogruharfsayisi);
                Console.WriteLine("Yanlış yazdığınız harf sayısı :"+" "+yanlisharfsayisi);
                Console.WriteLine();
                Console.WriteLine("Tekrar oynamak ister misiniz ?");
                Console.WriteLine("Yeninden oynamak için E tuşunu çıkmak için H tuşunu tuşlayınız ");
                bool kontrol1=true; //Aşşağıdaki döngüyü kontrol etmek için oluşturulan değişken

                while (kontrol1) // kontrol1 ture iken
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if (keyInfo.Key == ConsoleKey.E) //Kullanıcını girdiği harf E iken
                    {
                        dogruharfsayisi = 0;
                        yanlisharfsayisi = 0;
                        dogrukelimesayisi = 0;
                        yanliskelimesayisi=0;
                        Console.Clear (); 
                        kontrol1 = false; // İçteki döngüyü kırarak dışarıdaki döngüye tekrar girer
                        
                    }
                    else if (keyInfo.Key == ConsoleKey.H) //Kullanıcının girdiği harf H iken
                    {
                        Console.Clear () ;
                        kontrol = false; //Kontrol değişkenini false yaparak döngüyü kırar ve uygulamayı bitirir.
                        goto start;

                    }
                    else
                    {

                        Console.WriteLine("Lütfen geçerli bir harf giriniz !"); //Kullanıcıya hata verir

                    }
                }
            }
            

        }
    }
}
