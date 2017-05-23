using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int external = 0;
                do
                {
                    Console.WriteLine("Добро пожаловать в отчетную программу по теме: 'МАССИВЫ И СТРОКИ'. " +
                    "Введите соответствующую цифру цифру и нажмите ENTER...\n1 - [Создание рандомного упорядоченного массива]" +
                    "\n2 - [Создание рандомного неупорядоченного массива]\n3 - [Создание упорядоченного массива с нерандомными числами]\n4 - [Выход]");
                    external = int.Parse(Console.ReadLine());
                    switch (external)
                    {
                        case 1:
                            one();
                            break;
                        case 2:
                            two();
                            break;
                        case 3:
                            three();
                            break;
                    }
                } while (external < 4);
                Console.Clear();
                Console.WriteLine("Спасибо за использование программы! Ждем Вас снова. Выполнено Галкиным Павлом Александровичем (Для выхода нажмите любую клавишу...)");
                Console.Read();
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Не хватает памяти.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Слишком большое значение");
            }
        }
        static void one()
        {
            Console.Write("Введите размер массива со случайными числами: ");
            int arrayLen = int.Parse(Console.ReadLine());
            Console.Write("Введите нижнюю границу диапазона случайных чисел: ");
            int lowRange = int.Parse(Console.ReadLine());
            Console.Write("Введите верхнюю границу диапазона случайных чисел: ");
            int highRange = int.Parse(Console.ReadLine());
            Console.Write("Введите количество отображаемых символов в одной строке: ");
            int amountString = int.Parse(Console.ReadLine());
            Console.Write("Отобразить массив в обратном порядке?" +
            "Если да, то введите 'ДА' и нажмите ENTER, если нет, просто нажмите ENTER...  ");
            string reverse = Console.ReadLine();
            Console.Write("Отобразить массив из " + arrayLen + " чисел, заполняемый рандомно в промежутке от " + lowRange + " до " +
            highRange + "? Нажмите ENTER...");
            Console.ReadLine();
            int[] array = new int[arrayLen];
            Random rand = new Random();
            for (int counterOfRandom = 0; counterOfRandom < arrayLen; counterOfRandom++)
            {
                array[counterOfRandom] = rand.Next(lowRange, highRange);
            }
            Array.Sort(array);
            if (reverse == "ДА") Array.Reverse(array);
            int counter = 0;
            int counter2 = 0;
            try
            {
                Console.WriteLine("Упорядоченный массив со случайными числами:");
                while (counter <= (arrayLen - 1))
                {
                    counter2 = 1;
                    while (counter2 < amountString)
                    {
                        Console.Write(array[counter] + " ");
                        ++counter2;
                        ++counter;
                    }
                    Console.WriteLine(array[counter]);
                    ++counter2;
                    ++counter;
                }
                Console.WriteLine();
                Console.Write("Нажмите ENTER, чтобы вернуться в меню...");
                Console.ReadLine();
                Console.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine();
                Console.Write("Нажмите ENTER, чтобы вернуться в меню...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void two()
        {
            Console.Write("Введите размер массива со случайными числами: ");
            int arrayLen0 = int.Parse(Console.ReadLine());
            Console.Write("Введите нижнюю границу диапазона случайных чисел: ");
            int lowRange0 = int.Parse(Console.ReadLine());
            Console.Write("Введите верхнюю границу диапазона случайных чисел: ");
            int highRange0 = int.Parse(Console.ReadLine());
            Console.Write("Введите количество отображаемых символов в одной строке: ");
            int amountString0 = int.Parse(Console.ReadLine());
            Console.Write("Отобразить неупорядоченный массив из " + arrayLen0 + " чисел, заполняемый рандомно в промежутке от " + lowRange0 +
            " до " + highRange0 + "? Нажмите ENTER...");
            Console.ReadLine();
            int[] array0 = new int[arrayLen0];
            Random rand0 = new Random();
            for (int counterOfRandom0 = 0; counterOfRandom0 < arrayLen0; counterOfRandom0++)
            {
                array0[counterOfRandom0] = rand0.Next(lowRange0, highRange0);
            }
            int counter0 = 0;
            int counter20 = 0;
            try
            {
                Console.WriteLine("Неупорядоченный массив со случайными числами:");
                while (counter0 <= (arrayLen0 - 1))
                {
                    counter20 = 1;
                    while (counter20 < amountString0)
                    {
                        Console.Write(array0[counter0] + " ");
                        ++counter20;
                        ++counter0;
                    }
                    Console.WriteLine(array0[counter0]);
                    ++counter20;
                    ++counter0;
                }
                Console.WriteLine();
                Console.Write("Нажмите ENTER, чтобы вернуться в меню...");
                Console.ReadLine();
                Console.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine();
                Console.Write("Нажмите ENTER, чтобы вернуться в меню...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void three()
        {
            Console.Write("Введите размер массива с нерандомными числами: ");
            int array2Len = int.Parse(Console.ReadLine());
            int[] array2 = new int[array2Len];
            Console.Write("Введите нижнюю границу заполнения: ");
            int lowRange2 = int.Parse(Console.ReadLine());
            Console.Write("Введите количество отображаемых символов в одной строке: ");
            int amountString2 = int.Parse(Console.ReadLine());
            Console.Write("Отобразить массив из " + array2Len + " чисел, заполняемый с числа " + lowRange2 + "? Нажмите ENTER...");
            Console.ReadLine();
            for (int counterOfNotRandom = 0, number = lowRange2; counterOfNotRandom < array2Len; counterOfNotRandom++, number++)
            {
                array2[counterOfNotRandom] = number;
            }
            int counter3 = 0;
            int counter4 = 0;
            try
            {
                Console.WriteLine("Упорядоченный массив с " + array2Len + " нерандомными числами:");
                while (counter3 <= (array2Len - 1))
                {
                    counter4 = 1;
                    while (counter4 < amountString2)
                    {
                        Console.Write(array2[counter3] + " ");
                        ++counter4;
                        ++counter3;
                    }
                    Console.WriteLine(array2[counter3]);
                    ++counter4;
                    ++counter3;
                }
                Console.WriteLine();
                Console.Write("Нажмите ENTER, чтобы вернуться в меню...");
                Console.ReadLine();
                Console.Clear();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine();
                Console.Write("Нажмите ENTER, чтобы вернуться в меню...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
