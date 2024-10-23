using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Yazdirma Komutlari
            /*
                Console.WriteLine("Merhaba Dünya");
                Console.Write("Selam");

                Console.Read();
            */

            /*
                Console.WriteLine("**** Yemek Kategorileri ****");
                Console.WriteLine();
                Console.WriteLine("1-Çorbalar");
                Console.WriteLine("2-Ana Yemekler");
                Console.WriteLine("3-Soğuk Başlangıçlar");
                Console.WriteLine("4-Salatalar");
                Console.WriteLine("5-Tatlılar");
                Console.WriteLine("6-İçecekler");
                Console.WriteLine();
                Console.WriteLine("**** Yemek Kategorileri ****");

                Console.Read();
            */
            #endregion

            #region String Degiskenler
            /*
                string name;
                name = "Murat";
                Console.Write(name);

                Console.Read();
            */
            /*
                string customerName,customerSurname,customerEmail,customerPhone,district,city;

                customerName = "Ali";
                customerSurname = "Çınar";
                customerPhone = "+90 500 400 30 20";
                customerEmail = "deneme@gmail.com";
                district = "Kadıköy";
                city = "İstanbul";

                Console.WriteLine("*** Rezervasyon Kartı ****");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Müşteri: "+customerName + " " +customerSurname);
                Console.WriteLine("İletişim: " +customerPhone);
                Console.WriteLine("Email Adres: " +customerEmail);
                Console.WriteLine("Adres: "+district +"/"+city);
                Console.WriteLine("------------------------------------------------");

                customerName = "Ayşegül";
                customerSurname = "Kaya";
                customerPhone = "+90 500 600 70 80";
                customerEmail = "deneme@gmail.com";
                district = "Sapanca";
                city = "Sakarya";

                Console.WriteLine();

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
                Console.WriteLine("İletişim: " + customerPhone);
                Console.WriteLine("Email Adres: " + customerEmail);
                Console.WriteLine("Adres: " + district + "/" + city);
                Console.WriteLine("------------------------------------------------");

                Console.Read();
            */

            #endregion

            #region Int Degiskenler
            /*
                int number = 24;
                Console.WriteLine(number);
                Console.Read();
            */

            /*
                int hamburgerPrice = 300, cokePrice = 35, waterPrice = 10, friesPrice = 50, pizzaPrice = 250, lemonadePrice = 30;
                Console.WriteLine("**** Restoran Menü Fiyatı ****");
                Console.WriteLine();
                Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
                Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
                Console.WriteLine("-----Kola: " + cokePrice + " TL");
                Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
                Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
                Console.WriteLine("-----Su: " + waterPrice + " TL");
                Console.WriteLine();
                Console.WriteLine("**** Restoran Menü Fiyatı ****");
                Console.WriteLine();

                int hamburgerCount=3,cokeCount=3,waterCount=3,friesCount=1,pizzaCount=0,lemonadeCount=0;
                int totalHamburgerPrice = 0, totalCokePrice = 0, totalWaterPrice = 0,
                    totalFriesPrice = 0, totalPizzaPrice = 0, totalLemonadePrice = 0;

                totalHamburgerPrice = hamburgerPrice * hamburgerCount;
                totalCokePrice= cokePrice * cokeCount;
                totalFriesPrice= friesPrice * friesCount;
                totalWaterPrice= waterPrice * waterCount;
                totalPizzaPrice= pizzaPrice * pizzaCount;
                totalLemonadePrice= lemonadePrice * lemonadeCount;

                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Hamburger Tutarı: "+totalHamburgerPrice +" TL");
                Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
                Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
                Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
                Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
                Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

                int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice +
                    totalCokePrice + totalWaterPrice + totalLemonadePrice;

                Console.WriteLine();
                Console.WriteLine("Toplam Ödenecek Tutar: "+totalPrice +" TL");
                Console.Read();
            */
            #endregion



        }
    }
}
