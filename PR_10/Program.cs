//********************************************************************************************
//*Практическая работа №10                                                                   *   
//* Выполнил: Кондаков.П.А.,группа 2ИСП                                                      *
//* Задание: получение практических навыков алгоритмизации и программирования вычислительных *
//*процессов с использованием двумерных массивов;                                            *
//********************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PR_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Объявление и инициализация
            int n, m, i = 0, j = 0;
            Console.Write("Выберите размерность массива n : 4 или 3:");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;

            int[,] mas = new int[n, m];
            //2.
            Random rnd = new Random();
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    mas[i, j] = rnd.Next(-10, 10);
                    Console.WriteLine(i);
                    mas[i, j] = rnd.Next(-10, 10);
                    Console.WriteLine(j);
                }
            }
            for (i = 0; i < m; i++)
            {


                for (j = 0; j < n; j++)
                {

                    Console.Write(mas[i, j] + " ");
                }
                Console.Write("\n");

            }
            Console.WriteLine("");
            int buffer;
            int buffer2;
            Console.WriteLine("Результирующий массив");
            if (n == 3) //это для нечетного
            {
                for (i = 0; i < m; i++)
                {
                    buffer = mas[i, 0];
                    mas[i, 0] = mas[i, 1];
                    mas[i, 1] = buffer;
                }

                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {


                        Console.Write(mas[i, j] + " ");
                    }
                    Console.Write("\n");
                }
                buffer = 0;
            }


            else //это для чётного
            {
                for (i = 0; i < m; i++)
                {
                    buffer = mas[i, 0];
                    buffer2 = mas[i, 3];
                    mas[i, 0] = mas[i, 1];
                    mas[i, 3] = mas[i, 2];
                    mas[i, 1] = buffer;
                    mas[i, 2] = buffer2;
                }
                for (i = 0; i < m; i++)
                {
                    for (j = 0; j < n; j++)
                    {


                        Console.Write(mas[i, j] + " ");
                    }
                    Console.Write("\n");
                }
            }
            Console.ReadKey();
        }
        
    }
}

        