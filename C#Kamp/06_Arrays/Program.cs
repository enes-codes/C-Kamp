using System;using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Ornekleri
            /*
                string[] colors = new string[4];
                colors[0] = "Kırmızı";
                colors[1] = "Sarı";
                colors[2] = "Beyaz";
                colors[3] = "Mavi";

                Console.WriteLine(colors[2]);
                Console.Read();
            */

            /*
                string[] cities = new string[5];
                cities[0] = "Milano";
                cities[1] = "Budapeşte";
                cities[2] = "Lyon";
                cities[3] = "Kahine";
                cities[4] = "Üsküp";
                Console.WriteLine(cities[1]);
                Console.Read();
            */

            /*
                int[] numbers = new int[10];
                numbers[0] = 50;
                numbers[1] = 50;
                numbers[2] = 50;
                numbers[3] = 50;
                numbers[7] = 50;
                Console.WriteLine(numbers[5]);
                Console.Read();
            */

            /*
                string[] cities = new string[] { "Prag", "Atina", "Roma", "Ankara", "Bursa" };
                Console.WriteLine(cities[1]);
                Console.Read();
            */
            #endregion

            #region Dizideki Elemanlari Listeleme
            /*
                string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
                for (int i = 0; i < colors.Length; i++)
                {
                    Console.WriteLine(colors[i]);
                }
                Console.Read();
            */

            /*
                int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 3 == 0)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
                Console.Read();
            */

            /*
                char[] symbols = { 'a', 'b', 'c', 'x', 'y', 'z' };
                for (int i = 0; i < symbols.Length; i++)
                {
                    Console.WriteLine(symbols[i]);
                }
                Console.Read();
            */

            /*
                int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
                int maxNumber = myArray[0];
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] > maxNumber)
                    {
                        maxNumber = myArray[i];
                    }
                }
                Console.WriteLine(maxNumber);
                Console.Read();
            */

            /*
                string[] persons = { "Ali", "Mehmet", "Ayşe", "Fatma", "Hayriye" };
                Console.WriteLine(persons.Length);
                Console.Read();
            */

            /*
                int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
                Array.Sort(numbers);
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
                Console.Read();
            */

            /*
                int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
                Array.Reverse(numbers);
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
                Console.Read();
            */
            #endregion

            #region Dizi Metot
            /*
                string[] customers = { "Ali", "Buse", "Ayşe", "Merve", "Çınar" };
                int index = Array.IndexOf(customers, "Ayşe");
                Console.WriteLine(index);
                Console.Read();
            */

            /*
                int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
                Console.WriteLine("Dizinin En Büyük Elemanı: "+ numbers.Max()+" Dizinin En Küçük Elemanı: "+numbers.Min());
                Console.Read();
            */

            /*
                int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);
                Console.Read();
            */

            /*
                int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
                Console.WriteLine("Çift Sayılar");
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Tek Sayılar");
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 1)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
                Console.Read();
            */
            #endregion

            #region Kullanicidan Deger Alma
            /*
                string[] cities = new string[5];
                for (int i = 0; i < cities.Length; i++)
                {
                    Console.Write($"Lütfen {i+1}. Şehri Giriniz: ");
                    cities[i] = Console.ReadLine();
                }
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                for (int i = 0; i < cities.Length; i++)
                {
                    Console.WriteLine(cities[i]);
                }
                Console.Read();
            */
            #endregion
        }
    }
}
