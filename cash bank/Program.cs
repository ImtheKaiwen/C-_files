using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cash_bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            gen:
            Console.WriteLine("Cinsiyetinizi seçiniz");
            Console.WriteLine("1-Kadın 2-Erkek");
            string userinput = Console.ReadLine();
            
            string gender = "";
           if(int.TryParse(userinput,out int numb5))
            {
                if (numb5==1)
                {
                    gender ="Bayan";
                }
                else if(numb5==2)
                {
                    gender = "Bay";
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                    goto gen;
                }
             }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                goto gen;
            }

            
             Console.WriteLine("Lütfen isminizi giriniz");
             string name = Console.ReadLine();
             Console.WriteLine("Lütfen soyisminizi giriniz");
             string surname= Console.ReadLine();

             Console.WriteLine( "Cash Bank'a Hoşgeldiniz "+gender +" "+name+" "+surname);
            enter:
            Console.WriteLine();
            Console.WriteLine("1-Para çekme");
            Console.WriteLine("2-Para yatırma");
            Console.WriteLine("3-Diğer işlemler");
            Console.WriteLine("q-Çıkış");
            istan:
            Console.WriteLine();
            int x=0;
          ConsoleKeyInfo ch1 = Console.ReadKey();
            if (ch1.Key== ConsoleKey.NumPad1)
            {
                x = 1;
                goto sss;
            }
            else if(ch1.Key== ConsoleKey.NumPad2) { x = 2; goto sss;}
            else if( ch1.Key== ConsoleKey.NumPad3) { x = 3; goto sss;}
            else if(ch1.Key == ConsoleKey.Q) { x = 4; goto sss; }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Lütfen geçerli bir girdi giriniz");
                goto istan;
            }
            sss:
            switch (x)
            {
                case 1:
                    akk:
                    Console.WriteLine();
                    Console.WriteLine("1-Çekmek istediğiniz miktarı girmek için ");
                    Console.WriteLine("k-Geri gel");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.NumPad1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("miktar :");
                        akk1:
                        string miktar= Console.ReadLine();
                        if (int.TryParse(miktar,out int nbmiktar))
                        {
                            
                            Console.WriteLine("Bankamızdan"+" "+nbmiktar+"tl"+" "+"çekmiş bulunmaktasınız");
                            Console.WriteLine("Geri gelmek için k'yı tuşlayınız");
                            akk3:
                            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                            if(consoleKeyInfo.Key == ConsoleKey.K)
                            {
                                Console.WriteLine("");
                                goto akk;
                                
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Lütfen geçerli bir girdi tuşlayınız");

                                goto akk3;
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                            goto akk1;
                        }

                    }
                    else if(key.Key== ConsoleKey.K)
                    {
                        goto enter;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Lütfen geçerli bir girdi tuşlayınız");
                        goto akk;
                    }
                    break;

                case 2:
                    aa12:
                    Console.WriteLine();
                    Console.WriteLine("Lütfen yatırmak istediğiniz miktarı giriniz");
                    string miktar2= Console.ReadLine();
                    if(int.TryParse(miktar2,out int numb6))
                    {
                        Console.WriteLine();
                        Console.WriteLine("İşleminiz tamamlanmıştır");
                        Console.WriteLine("Geri gelmek için k'yı tuşlayınız");
                        asd1:
                        ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                        if (consoleKeyInfo.Key == ConsoleKey.K)
                        {
                            goto enter;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Lütfen geçerli girdiği tuşlayınız");
                            goto asd1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lütfen sayı giriniz ");
                        goto aa12;
                    }
                    break; 
                    case 3:
                    enter1:
                    Console.WriteLine();
                    Console.WriteLine("1-Transfer işlemleri");
                    Console.WriteLine("2-Bakiye bilgileri");
                    Console.WriteLine("3-geri gel");
                    int y = 0;
                    ConsoleKeyInfo key11= Console.ReadKey();
                    if(key11.Key == ConsoleKey.NumPad1) { y = 1; }
                    else if(key11.Key == ConsoleKey.NumPad2) { y = 2; }
                    else if (key11.Key == ConsoleKey.NumPad3) { y = 3; }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                        goto enter1;
                    }
                    switch (y)
                    {
                        case 1:
                            olur:
                            Console.WriteLine();
                            Console.WriteLine("Lütfen transfet etmek istediğiniz miktarı giriniz");
                            string transfer12= Console.ReadLine();
                            if(int.TryParse(transfer12, out int num44))
                            {
                                num44 = num44;
                            }
                            else
                            {
                                Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                                goto olur;
                            }
                            takecardnumber1:
                            Console.WriteLine();
                            Console.WriteLine("Lütfen transfer etmek istediğiniz kartın numarasını giriniz");
                            string cardnumber1= Console.ReadLine();
                            if(cardnumber1.Length == 11 && long.TryParse(cardnumber1,out long number1))
                            {
                                oha1:
                                Console.WriteLine("kart numarası"+ " "+number1);
                                Console.WriteLine("Kart numarasının doğru olduğundan emin misiniz ?");
                                Console.WriteLine("1-Evet");
                                Console.WriteLine("2-hayır");
                                int xy = 0;
                                ConsoleKeyInfo yn5 = Console.ReadKey();
                                if (yn5.Key == ConsoleKey.NumPad1)
                                {
                                    xy = 1;
                                }
                                else if (yn5.Key == ConsoleKey.NumPad2) { xy = 2; }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                                    goto oha1;
                                }
                                switch (xy)
                                {
                                    case 1:
                                        Console.WriteLine("İşleminiz tamamlanmıştır");
                                        goto enter1;
                                        break;
                                        case 2:
                                        goto takecardnumber1;
                                        break;
                                        default: Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                                        break;
                                }

                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Lütfen geçerli bir kart numarası giriniz");
                                goto takecardnumber1;
                            }
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Bakiye bilgileri");
                            Console.WriteLine("500tl");
                            quit:
                            Console.WriteLine();
                            Console.WriteLine("Geri gelmek için q yu tuşlayınız");
                            string quit= Console.ReadLine();
                            if (quit == "q")
                            {
                                goto enter1;
                            }
                            else
                            {
                                Console.WriteLine("Lütfen geçerli harfi giriniz");
                                goto quit;
                            }

                            break;
                            case 3:
                            goto enter;
                    }
                    break;
                    case 4:
                    Console.WriteLine();
                    Console.WriteLine("çıkış yapmak için q yu tuşlayınız");
                    string quit3= Console.ReadLine();
                    if(quit3 == "q")
                    {
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                    goto enter;
                    break;

            }


           
           Console.ReadLine();
        }
    }
}
