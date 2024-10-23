using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If - Else (String)
            /*
                Console.Write("Lütfen Şifreyi Giriniz: ");
                string password = Console.ReadLine();
                if (password == "abcd")
                {
                    Console.WriteLine("Şifre Doğru");
                }
                else
                {
                    Console.WriteLine("Şifre Yanlış Tekrar Deneyiniz...");
                }
                Console.Read();

            */

            /*
                Console.Write("Ülkeyi Giriniz: ");
                string country = Console.ReadLine();
                Console.Write("Başkenti Giriniz: ");
                string capital = Console.ReadLine();

                if (capital == "Ankara" & country == "Türkiye")
                {
                    Console.Write("Veriler Doğru");
                }
                else
                {
                    Console.Write("Veriler Yanlış Lütfen Tekrar Deneyiniz...");
                }
                Console.Read();
            */

            /*
                Console.Write("Lütfen Şehir Girişi Yapınız: ");
                string city = Console.ReadLine();

                if (city=="adana"| city=="ankara"|city=="bursa"|city=="trabzon")
                {
                    Console.WriteLine("Şehir Mevcut");
                }
                else
                {
                    Console.WriteLine("Şehir Mevcut Değil");
                }                
                Console.Read();
            */

            /*
                Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
                string username = Console.ReadLine();
                if (username != "admin")
                {
                    Console.Write("Bu Kullanıcı Adı Kabul Edilemez");
                }
                else
                {
                    Console.Write("Hoş Geldiniz");
                }
                Console.Read();
            */

            #endregion

            #region If - Else (Int)
            /*
                Console.Write("Sayıyı Giriniz: ");
                int number = int.Parse(Console.ReadLine());
                if (number == 5)
                {
                    Console.WriteLine("Sayı Doğru");
                }else
                {
                    Console.WriteLine("Sayı Yanlış Lütfen Tekrar Deneyiniz...");
                }
                Console.Read();

            */

            /*
                string result = "";

                Console.Write("Sınav - 1: ");
                int exam1 = int.Parse(Console.ReadLine());
                Console.Write("Sınav - 2: ");
                int exam2 = int.Parse(Console.ReadLine()); 
                Console.Write("Sınav - 3: ");
                int exam3 = int.Parse(Console.ReadLine());

                int average = (exam1 + exam2 + exam3) / 3;
                Console.Write("Sınavların Ortalaması: "+average);

                if (average>0 & average <=50)
                {
                    result = "Sonuç Vasat";
                }
                if (average > 50 & average <=70){
                    result = "Sonuç Orta";
                }
                if (average > 70 & average <= 84)
                {
                    result = "Sonuç İyi";
                }
                if(average > 84)
                {
                    result = "Sonuç Mükemmel";
                }
                Console.WriteLine();
                Console.WriteLine(result);
                Console.Read();
            */
            #endregion

            #region Mod İslemleri
            /*
                int number = 26;
                int result = number % 5;
                Console.WriteLine(result);
                Console.Read();
            */

            /*
                Console.Write("Lütfen 1.Sayıyı Giriniz: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.Write("Lütfen 2.Sayıyı Giriniz: ");
                int number2 = int.Parse(Console.ReadLine());
                int result = number1 % number2;
                Console.Write("1.Sayının 2.Sayıya Bölümünden Kalan: "+result);
                Console.Read();
            */

            /*
                Console.Write("Lütfen Sayıyı Giriniz: ");
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0) 
                {
                    Console.Write("Sayı Çifttir");
                }
                else
                {
                    Console.Write("Sayı Tektir");
                }
                Console.Read();
            */
            #endregion

            #region Char İslemleri
            /*
                Console.Write("Lütfen Takımınızın Baş Harfini Giriniz: ");
                char team = char.Parse(Console.ReadLine());

                if (team == 'g' || team == 'G')
                {
                    Console.Write("Tuttuğunuz Takım : Galatasaray");
                }
                if (team == 'f' || team == 'F')
                {
                    Console.Write("Tuttuğunuz Takım : Fenerbahçe");
                }
                if (team == 'b' || team == 'B')
                {
                    Console.Write("Tuttuğunuz Takım : Beşiktaş");
                }
                if (team == 't' || team == 'T')
                {
                    Console.Write("Tuttuğunuz Takım : Trabzon");
                }
                Console.Read();
            */
            #endregion

            #region Ornek Proje Uygulamasi 
            /*
                Console.WriteLine("**** Restoran Menü ****");
                Console.WriteLine();
                Console.WriteLine("-----------------------");
                Console.WriteLine("1-Ana Yemekler");
                Console.WriteLine("2-Çorbalar");
                Console.WriteLine("3-Pizzalar");
                Console.WriteLine("4-İçecekler");
                Console.WriteLine("5-Tatlılar");
                Console.WriteLine("-----------------------");
                Console.WriteLine();

                Console.Write("Detayını Görmek İstediğiniz Menüyü Seçiniz: ");
                string menuItem = Console.ReadLine();

                if (menuItem == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("------- Ana Yemekler -------");
                    Console.WriteLine();
                    Console.WriteLine("1-Köri Soslu Tavuk");
                    Console.WriteLine("2-Kızartma Tabağı");
                    Console.WriteLine("3-Faulye Pilav");
                    Console.WriteLine("4-Fırında Somon");
                    Console.WriteLine("5-Patlıcan Musakka");
                    Console.WriteLine();
                    Console.WriteLine("------- Ana Yemekler -------");
                    Console.WriteLine();

                }
                if (menuItem == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine("------- Çorbalar -------");
                    Console.WriteLine();
                    Console.WriteLine("1-Mercimek Çorbası");
                    Console.WriteLine("2-Ezogelin Çorbası");
                    Console.WriteLine();
                    Console.WriteLine("------- Çorbalar -------");
                    Console.WriteLine();

                }
                if (menuItem == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine("------- Pizzalar -------");
                    Console.WriteLine();
                    Console.WriteLine("1-Margaritha");
                    Console.WriteLine("2-Tavuklu Pizza");
                    Console.WriteLine("3-Akdeniz Pizza");
                    Console.WriteLine();
                    Console.WriteLine("------- Pizzalar -------");
                    Console.WriteLine();

                }
                if (menuItem == "4")
                {
                    Console.WriteLine();
                    Console.WriteLine("--- İçecekler ---");
                    Console.WriteLine();
                    Console.WriteLine("1-Kola");
                    Console.WriteLine("2-Ayran");
                    Console.WriteLine("3-Su");
                    Console.WriteLine();
                    Console.WriteLine("--- İçecekler ---");
                    Console.WriteLine();

                }
                if (menuItem == "5")
                {
                    Console.WriteLine();
                    Console.WriteLine("--- Tatlılar ---");
                    Console.WriteLine();
                    Console.WriteLine("1-Triliçe");
                    Console.WriteLine("2-Kazandibi");
                    Console.WriteLine("3-Sütlaç");
                    Console.WriteLine();
                    Console.WriteLine("--- Tatlılar ---");
                    Console.WriteLine();

                }

                Console.Read();
            */
            #endregion

            #region Switch Case 
            /*
                Console.Write("Lütfen Ay Girişi Yapınız: ");
                int monthNumber = int.Parse(Console.ReadLine());

                switch (monthNumber)
                {
                    case 1: Console.Write("Ocak"); break;
                    case 2: Console.Write("Şubat"); break;
                    case 3: Console.Write("Mart"); break;
                    case 4: Console.Write("Nisan"); break;
                    case 5: Console.Write("Mayıs"); break;
                    case 6: Console.Write("Haziran"); break;
                    case 7: Console.Write("Temmuz"); break;
                    case 8: Console.Write("Ağustos"); break;
                    case 9: Console.Write("Eylül"); break;
                    case 10: Console.Write("Ekim"); break;
                    case 11: Console.Write("Kasım"); break;
                    case 12: Console.Write("Aralık"); break;
                    default: Console.Write("Hatalı Veri Girişi Yaptınız"); break;
                }
                Console.Read();
            */

            /*
                int number1, number2, result;
                char symbol1;

                Console.Write("1.Sayıyı Giriniz: ");
                number1 = int.Parse(Console.ReadLine());
                Console.Write("2.Sayıyı Giriniz: ");
                number2 = int.Parse(Console.ReadLine());

                switch (symbol1)
                {
                    case '+':
                        result = number1 + number2;
                        Console.Write("Toplama: "+result);
                        break;

                    case '-':
                        result = number1 - number2;
                        Console.Write("Çıkarma: " + result);
                        break;

                    case '*':
                        result = number1 * number2;
                        Console.Write("Çarpma: " + result);
                        break;

                    case '/':
                        result = number1 / number2;
                        Console.Write("Bölme: " + result);
                        break;
                }
                Console.Read();
            */
            #endregion
        }
    }
}
