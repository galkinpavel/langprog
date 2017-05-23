using System;
namespace exponentation_with_menu
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Добро пожаловать в программу вычисления значения выражения [a^n]!\nВведите число, соответствующее вашему запросу:");
            int external = 0, _internal, n = 1;
            double a = 2, counter = 1, rezult = 1;
            do
            {
                Console.WriteLine("1 - [Ввод исходных данных]\n2 - [Просмотр исходных данных или данных по умолчанию]\n3 - [Расчет]\n4 - [Выход]");
                external = int.Parse(Console.ReadLine());
                switch (external)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Введите [a] в выражении a^n: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите натуральное число [n] в выражении a^n: ");
                        n = int.Parse(Console.ReadLine()); 
                        Console.WriteLine("Нажмите ENTER...");
                        Console.ReadLine();
                        Console.Clear();
                    break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("[a] = " + a + ".\n[n] = " + n + ". Нажмите ENTER...");
                        Console.ReadLine();
                        Console.Clear();
                    break;
                    case 3:
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Выберите метод решения:");
                            Console.WriteLine("1 - [Цикл с предусловием while]\n2 - [Цикл с постусловием do]\n3 - [Цикл с параметром for]\n4 - [Выход]");
                            _internal = int.Parse(Console.ReadLine());
                            switch (_internal)
                            {
                                case 1:
                                    Console.Clear();
                                    rezult = 1;
                                    counter = 1;
                                    while (counter <= n)
                                    {
                                        rezult *= a;
                                        counter++;
                                    }
                                    Console.WriteLine("a^n = " + rezult + ", где " + "[a] = " + a + ".[n] = " + n + ". Нажмите ENTER...");
                                    Console.ReadLine();
                                    Console.Clear();
                                break;
                                case 2:
                                    Console.Clear();
                                    rezult = 1;
                                    counter = 1;
                                    do
                                    {
                                        rezult *= a;
                                        counter++;
                                    } while (counter <= n);
                                    Console.WriteLine("a^n = " + rezult + ", где " + "[a] = " + a + ".[n] = " + n + ". Нажмите ENTER...");
                                    Console.ReadLine();
                                    Console.Clear();                                
                                break;
                                case 3:
                                    Console.Clear();
                                    for (counter = 1, rezult = 1; counter <= n; rezult *= a, counter++);
                                    Console.WriteLine("a^n = " + rezult + ", где " + "[a] = " + a + ".[n] = " + n + ". Нажмите ENTER...");
                                    Console.ReadLine();
                                    Console.Clear();
                                break;
                            }
                        } while (_internal < 4);
                    Console.Clear();
                    break;
                }
            } while (external < 4);
            Console.Clear();
            Console.WriteLine("Спасибо за использование программы! Ждем Вас снова. (Для выхода нажмите любую клавишу...)");
            Console.Read();
        } 
    }
}