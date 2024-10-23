using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Dongusu
            /*
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("C# Kamp");
                }
                Console.Read();
            */

            /*
                for (int i = 1; i <=20; i++)
                {
                    Console.WriteLine(i);
                }
                Console.Read();
            */

            /*
                for (int i = 3; i <=50; i+=3) 
                {
                    Console.WriteLine(i);
                }
                Console.Read();
            */

            /*
                Console.Write("Lütfen Ekrana Yazılmasını İstediğiniz Adedi Giriniz: ");
                int finishValue = int.Parse(Console.ReadLine());

                for (int i = 1; i <=finishValue; i++)
                {
                    Console.WriteLine("Yaşasın Cumhuriyet");
                }
                Console.Read();
            */
            #endregion

            #region For Dongusu Ile Karar Yapilari
            /*
                for (int i = 1; i <=100; i++) 
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.Read();
            */

            /*
                int totalValue = 0;
                for (int i = 1; i <=10; i++)
                {
                    totalValue += i;
                }
                Console.WriteLine(totalValue);
                Console.Read();
            */

            /*
                int totalValue = 0;
                for (int i = 1; i < 20; i++)
                {
                    if (i % 2 == 0)
                    {
                        totalValue += i;
                        Console.WriteLine(" "+i);
                    }
                }
                Console.WriteLine("+__");
                Console.WriteLine(" "+totalValue);
                Console.Read();
            */

            /*
                int count = 0;
                for (int i = 1; i <= 60; i++)
                {
                    if (i % 7 == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                Console.Read();
            */

            /*
                int bacterium = 1;
                for (int i = 1; i <=24; i++)
                {
                    bacterium *= 2;
                    Console.WriteLine(i+".Saat Sonunda: " +bacterium);
                }
                Console.Read();
            */
            #endregion

            #region While Dongusu 
            /*
                int i = 1;
                while (i <= 10) 
                {
                        Console.WriteLine("Merhaba Donguler");
                        i++;
                }
                Console.Read();
            */

            /*
                int i = 1;
                int sum = 0;
                while (i <=10)
                {
                    sum += i;
                    i++;
                }
                Console.WriteLine(sum);
                Console.Read();
            */
            #endregion

            #region While Dongusu Ile Karar Yapilari
            /*
                int i = 1;
                while (i <= 10)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
                Console.Read();
            */
            #endregion

            #region Ornek Proje Uygulamasi
            /*
                Console.Write("Sayıyı Giriniz: ");
                int number = int.Parse(Console.ReadLine());
                int ones, tens, hundreds, sum;
                ones = number % 10;
                tens = (number % 10) / 10;
                hundreds = number / 100;
                Console.WriteLine(ones + "-" + tens + "-"+hundreds);
                sum = ones + tens + hundreds;
                Console.WriteLine(sum);
                Console.Read();
            */
            #endregion
        }
    }
}
