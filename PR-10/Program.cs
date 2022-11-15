using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Объявление и инициализация
            int n, m, i, j;
            Console.Write("Выберите размерность массива n : 4 или 3"); 
            n=Convert.ToInt32(Console.ReadLine());
            Console.Write("Выберите размерность массива m : 4 или 3"); 
            m=Convert.ToInt32(Console.ReadLine());
                 
                int[,]mas =new int [n,m];
            //2.
            Random rnd =new Random ();
            for(int i=0; i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    int i = rnd.Next(-10, 10);
                    Console.WriteLine(i);
                    int j = rnd.Next(-10, 10);
                    Console.WriteLine(j);
                    mas[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            //3.
            for(i=0;i<m;i++)
            {
                for(j=0;j<n;j++)
                {
                    if(i==j)
                        mas[i,j] = 1;
                }
            }
            //4.
            Console.Write("Результирующий массив");
            for(i=0;i<m;i++)
            {
                for(j=0;j<n;j++)
                {
                    Console.Write(mas[i,j]+" ");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
