using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLforAll;

namespace TaskMatrix
{
    class TaskMatrix
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            int n;
            int[,] array;
            int passes = 0;
            int[][,] jaggedarray = new int[100][,];
            do
            {
                Start(out array, out n, out key);
                jaggedarray[passes] = array;
                passes += 1;
            }
            while (key.Key == ConsoleKey.Y);
            {
                if (key.Key == ConsoleKey.N)
                {
                    Matrix.PrintArray(array);
                    Console.ReadKey();
                }
                else if (key.Key == ConsoleKey.T)
                {
                    Matrix.PrintArray(array);
                    Console.WriteLine();
                    Console.WriteLine("==============");
                    Console.WriteLine();
                    Matrix.PrintTransArray(array);
                    Console.ReadKey();
                }
                else if (key.Key == ConsoleKey.U)
                {
                    Matrix.PrintArray(array);
                    Console.WriteLine();
                    Console.WriteLine("==============");
                    Console.WriteLine();
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j < i)
                                array[i, j] = 0;
                        }
                    }
                    Matrix.PrintArray(array);
                    Console.ReadKey();

                }
                else if (key.Key == ConsoleKey.L)
                {
                    Matrix.PrintArray(array);
                    Console.WriteLine();
                    Console.WriteLine("==============");
                    Console.WriteLine();
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j > i)
                                array[i, j] = 0;
                        }
                    }
                    Matrix.PrintArray(array);
                    Console.ReadKey();

                }
                else if (key.Key == ConsoleKey.Q)
                {

                    Matrix.PrintAllArray(jaggedarray, passes);
                    Console.ReadKey();
                }
            }
        }

        static void Start(out int[,] array, out int n, out ConsoleKeyInfo key)
        {
            Console.Write("Enter matrix rank: ");
            n = Matrix.ReadNumberFromConsole();
            array = new int[n, n];
            Matrix.Filling(n, array);
            Console.WriteLine("To enter new matrix rank press Y");
            Console.WriteLine("To print transpose matrix press T");
            Console.WriteLine("To print upper triangular matrix press U");
            Console.WriteLine("To print lower triangular matrix press L");
            Console.WriteLine("To print matrix press N");
            Console.WriteLine("To print all entered matrix press Q");
            Console.WriteLine("To exit press any another key");
            key = Console.ReadKey();
            Console.WriteLine("\n");
        }
    }
}
