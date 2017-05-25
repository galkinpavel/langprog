using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_лабораторная
{
    class Program
    {
        static int n, k, low, high;           //n - строка, k - столбец   
        static void Enter()
        {
            Console.Write("Введите число строк массива: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите число столбцов массива: ");
            k = int.Parse(Console.ReadLine());
            Console.Write("Введите нижнюю границу массива: ");
            low = int.Parse(Console.ReadLine());
            Console.Write("Введите верхнюю границу массива: ");
            high = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Random rand = new Random();     //создаем экземпляр класса random
            Enter();                   //вызываем ввод параметров программы
            double[,] massive = new double[n, k];           //создаем вещественный массив
            /* Далее идет заполнение массива вещественными числами
             */
            for(int i = 0; i < n; ++i)
            {
                for (int j = 0; j < k; ++j)
                {
                    massive[i, j] = rand.Next(low, high);/// + rand.NextDouble();
                }
            }
            /* Далее идет вывод массива вещественных чисел
             */
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < k; ++j)
                {
                    Console.Write(massive[i, j] + " ");
                }
                Console.WriteLine();
            }
            /* Определение максимального элемента массива и их количества
             */
            double max = 0.0;
            int count = 1;                          //cчетчик количества максимальных чисел
            int position_n = 0, position_k = 0;           //позиция одного из (первого) максимального числа
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < k; ++j)
                {
                    if (massive[i, j] == max)
                    {
                        count++;
                    }
                    if (massive[i, j] > max)
                    {
                        max = massive[i, j];
                        position_n = i;
                        position_k = j;
                    }
                }
            }
            /*Вывод позиций максимальных чисел и подсчет позиций остальных максимальных чисел*/
            if (count == 1)
            {
                Console.WriteLine("Максимальное число: " + max + "\nПозиция: [{0}, {1}]", position_n + 1, position_k + 1);
            }
            else
            {
                Console.WriteLine("Максимальное число: " + max + "\nПозиции:");
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < k; ++j)
                    {
                        if (massive[i, j] > max)
                        {
                            max = massive[i, j];
                        }
                        if (massive[i, j] == max)
                        {
                            Console.WriteLine("[{0}, {1}]", i + 1, j + 1);
                        }
                    }
                }
            }
            /* Перемещение вверх по столбцу (изменяется индекс строки, т. е. строка передвигается вверх) 
             */
            double buf = 0;
            if (position_n != 0)
            {
                for (int i = position_n; i != 0; --i)
                {
                    for(int j = 0; j < k; ++j)
                    {
                        buf = massive[i, j];
                        massive[i, j] = massive[i - 1, j];
                        massive[i - 1, j] = buf;
                        buf = 0.0;
                    }

                }
            }
            /* Перемещение влево по строке (изменяется индекс столбца, т. е. столбец передвигается влево)
             */
            buf = 0.0;
            if (position_k != 0)
            {
                for (int j = position_k; j != 0; --j)
                {
                    for (int i = 0; i < n; ++i)
                    {
                        buf = massive[i, j];
                        massive[i, j] = massive[i, j - 1];
                        massive[i, j - 1] = buf;
                        buf = 0.0;
                    }

                }
            }
            /* Вывод измененного массива
             */
            Console.WriteLine("Выводится массив, в котором строка и столбец с первым встретившимся макисмальным числом переставлены на первую позицию:");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < k; ++j)
                {
                    Console.Write(massive[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
/*Дана (построчно) вещественная матрица размером 7x4. Переставляя ее 
строки и столбцы, добиться того, чтобы наибольший элемент(один из
них) оказался в верхнем левом углу.*/
