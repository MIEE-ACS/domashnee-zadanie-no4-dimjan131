using System;

namespace ConsoleMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Введите размер массива: ");
            } while (!int.TryParse(Console.ReadLine(), out n));
            try
            {
                int[,] a = new int[n,n];
                Console.WriteLine("Массив: ");
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        a[i,j] = rnd.Next(-5, 5);
                        Console.Write(a[i,j].ToString().PadLeft(5, ' '));
                    }
                    Console.WriteLine();
                }
               

                int s = 0;
                for (int i = 0; i < n; i++)
                    for (int j = i + 1; j < n; j++)
                        s = s + a[i, j];
                Console.WriteLine("Сумма элементов выше главной диагонали: " + s);

                int locMin = 0;
                for (int i = 1; i < n-1; i++)
                    for (int j = 1; j < n-1; j++)
                        if ((a[i,j] < a[i,j - 1]) && (a[i,j] < a[i,j + 1]) && (a[i,j] < a[i + 1,j]) && (a[i,j] < a[i - 1,j]))
                        {
                            Console.WriteLine("Локальный минимум: " + a[i, j] + " позиция: " + i + ", " + j);
                            locMin++;
                        }

                Console.WriteLine("Кол-во локальных минимумов: " + locMin);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
