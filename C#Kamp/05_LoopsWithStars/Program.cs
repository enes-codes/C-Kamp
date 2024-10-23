using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ornek Uygulama Projesi - Alt Alta 10 Tane Yildiz
            /*
                for (int i = 1; i <=10; i++)
                {
                    Console.WriteLine("*");
                }
                Console.Read();
            */
            #endregion

            #region Ornek Uygulama Projesi - Yan Yana 10 Tane Yildiz
            /*
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("*");
                }
                Console.Read();
            */
            #endregion

            #region Ornek Uygulama Projesi - Yan Yana 10 Tane Yildiz Her Satırda 10 Yildiz
            /*
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("**********");
                }
                Console.Read();
            */
            #endregion

            #region Dik Ucgen
            /*
                for (int i = 1; i <=5; i++)
                {
                    for (int j = 1; j <= i ; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.Read();
            */
            #endregion

            #region Ters Dik Ucgen
            /*
                for (int i = 5; i <= 1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.Read();
            */
            #endregion

            #region Dik Ve Ters Dik Ucgen 
            /*
                for (int i = 1; i <=5; i++)
                {
                    for (int j = 1; j <=i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (int k = 4; k >= 1; k--)
                {
                    for (int m = 1; m <= k; m++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.Read();
            */
            #endregion

            #region Baklava Dilimi
            /*
                int n = 5;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = n-1; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2*i-1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = n-1; i >= 1; i--)
                {
                    for (int j = n - 1; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.Read();
            */
            #endregion

            #region Piramit
            /*
                int n = 5;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = n - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.Read();
            */
            #endregion

            #region Ters Piramit
            /*
                int n = 5;
                for (int i = n; i >= 1; i--)
                {
                    for (int j = n - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.Read();
            */
            #endregion
        }
    }
}
