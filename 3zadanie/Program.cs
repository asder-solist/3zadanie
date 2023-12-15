using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3zadanie

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во строк в матрице");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов в матрице");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[n,m];
            int[,] matrix2 = new int[n,m];
            int[,] matrix3 = new int[n, m];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                 for (int j = 0; j < m; j++)
                {
                    matrix1[i,j] = rnd.Next(100);
                    matrix2[i, j] = rnd.Next(100);
                    Console.Write(matrix1[i, j] + " ");
                    sum += matrix1[i, j];
                }
                 Console.WriteLine();
            }
            Console.WriteLine($"Сумма чисел 1-ой матрицы:{sum}");
            Console.WriteLine("+");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix3[i,j] = matrix1[i,j] + matrix2[i,j];
                    Console.Write(matrix3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
