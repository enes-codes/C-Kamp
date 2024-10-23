using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler
            /*
                double number = 4.85;
                Console.WriteLine(number);
                Console.Read();
            */

            /*
                double applePrice = 14.85, orangePrice = 20.95, strawberryPrice = 45, potatoPrice = 9.74, tomatoPrice = 6.88;
                Console.WriteLine("**** Manav Menü Fiyatları ****");
                Console.WriteLine();
                Console.WriteLine("---- Elma Birim Fiyati: "+applePrice+" TL");
                Console.WriteLine("---- Portakal Birim Fiyati: " + orangePrice + " TL");
                Console.WriteLine("---- Çilek Birim Fiyati: " + strawberryPrice + " TL");
                Console.WriteLine("---- Patates Birim Fiyati: " + potatoPrice + " TL");
                Console.WriteLine("---- Domates Birim Fiyati: " + tomatoPrice + " TL");
                Console.WriteLine();
                Console.WriteLine("**** Manav Menü Fiyatları ****");

                double appleGram = 1.245, orangeGram = 2.650, strawberryGram = 0.750, potatoGram = 4.859, tomatoGram = 3.745;
                Console.WriteLine("-------------------------------------------");

                double appleTotalPrice = applePrice * appleGram;
                double orangeTotalPrice = orangePrice * orangeGram;
                double strawberryTotalPrice = strawberryPrice * strawberryGram;
                double potatoTotalPrice = potatoPrice * potatoGram;
                double tomatoTotalPrice = tomatoPrice * tomatoGram;

                Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + 
                    applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
                Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " +
                        orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
                Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " +
                        strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
                Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " +
                        potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
                Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " +
                        tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------");

                 double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + 
                    potatoTotalPrice + strawberryTotalPrice + tomatoTotalPrice;

                Console.WriteLine("Alışveriş Toplam Tutarı: " +shoppingTotalPrice+" TL");
                Console.Read();
            */
            #endregion

            #region Char Degiskenler
            /*
                char symbol = 'A';
                Console.WriteLine(symbol);
                Console.Read()
            */
            #endregion

            #region Klavyeden Veri Girisleri - String
            /*
                Console.WriteLine("**** Hava Yolları Yolcu Bilgisi ****");
                Console.WriteLine();

                string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

                Console.Write("Yolcu Adı: ");
                passengerName = Console.ReadLine();
                Console.Write("Yolcu Soyadı: ");
                passengerSurname = Console.ReadLine();
                Console.Write("İlçe Bilgisi: ");
                passengerDistrict = Console.ReadLine();
                Console.Write("Şehir Bilgisi: ");
                passengerCity = Console.ReadLine();
                Console.Write("Yolcu Yaşı: ");
                passengerAge = Console.ReadLine();
                Console.Write("Yolcu Tc No: ");
                passengerIdentityNumber = Console.ReadLine();

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Tc No: "+passengerIdentityNumber+" - Ad Soyad: "+passengerName+" "
                    +passengerSurname+" - Adres: "+passengerDistrict+"/"+passengerCity+" - Yaş: "+passengerAge);
                Console.Read();
            */
            #endregion

            #region Klavyeden Veri Girisleri - Int
            /*
                int shoesPrice = 1000, computerPrice = 20000, chairPrice = 5000, tvPrice = 12000;

                Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
                int shoesCount = int.Parse(Console.ReadLine());
                Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
                int computerCount = int.Parse(Console.ReadLine());
                Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
                int chairCount = int.Parse(Console.ReadLine());
                Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
                int tvCount = int.Parse(Console.ReadLine());

                int shoesTotalPrice = shoesCount * shoesPrice;
                int computerTotalPrice = computerCount * computerPrice;
                int chairTotalPrice = chairCount * chairPrice;
                int tvTotalPrice = tvCount * tvPrice;

                int totalPrice = chairTotalPrice + computerTotalPrice + computerTotalPrice + tvTotalPrice;
                Console.WriteLine();
                Console.WriteLine("Toplam Ödemeniz Gerreken Tutar: " + totalPrice);
                Console.Read();
            */
            #endregion

            #region Klavyeden Veri Girisler - Double
            /*
                double exam1, exam2, exam3, result;

                Console.Write("Lütfen 1.Sınav Notunuzu Giriniz: ");
                exam1= double.Parse(Console.ReadLine());
                Console.Write("Lütfen 2.Sınav Notunuzu Giriniz: ");
                exam2 = double.Parse(Console.ReadLine());
                Console.Write("Lütfen 3.Sınav Notunuzu Giriniz: ");
                exam3 = double.Parse(Console.ReadLine());

                result = (exam1 + exam2 + exam3) / 3;
                Console.WriteLine();
                Console.WriteLine("Sınav Ortalamanız: "+result);
                Console.Read();
            */
            #endregion

            #region Klavyeden Veri Girisleri - Char
            /*
                char gender;
                Console.Write("Lütfen Cinsiyetiniz Baş Harfini Giriniz: ");
                gender = char.Parse(Console.ReadLine());
                Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);
                Console.Read();
            */
            #endregion


        }
    }
}
