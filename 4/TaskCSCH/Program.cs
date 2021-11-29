using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskCSCH
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
                int[] a = new int[n];
                Console.WriteLine("Массив: ");
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    a[i] = rnd.Next(-5, 5);
                    Console.Write(a[i].ToString().PadLeft(5, ' '));
                }
                Console.WriteLine();

                int m = 0;
                for (int i = 0; i < n; i++)
                    if (Math.Abs(a[m]) > Math.Abs(a[i]))
                        m = i;
                Console.WriteLine("Минимальный по модулю элемент: " + a[m]);

                if (a[m] == 0)
                {
                    int sum = 0;
                    for (int i = m + 1; i < n; i++)
                        sum = sum + a[i];
                    Console.WriteLine("Сумма элементов после первого нуля: " + sum);
                }
                else
                    Console.WriteLine("Нет нулевых элементов!");

                // переставляем значения
                for (int i = 0; i < a.Length / 2; i = i + 2)
                {
                    int tmp = a[i + a.Length / 2];
                    a[i + a.Length / 2] = a[i];
                    a[i] = tmp;
                }

                Console.WriteLine("Измененный массив: ");
                for (int i = 0; i < n; i++)
                    Console.Write(a[i].ToString().PadLeft(5, ' '));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
