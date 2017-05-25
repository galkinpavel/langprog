using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_лабораторка
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double R = 0, H = 0, V = 0;
            int t = 0, l = 0;
            do
            {
                Console.Clear();
                do
                {
                    t = 0;
                    Console.WriteLine("Введите радиус основания конуса: ");
                    try
                    {
                        R = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Вводить необходимо число!!!");
                        ++t;
                    }
                } while (t == 1);

                do
                {
                    t = 0;
                    Console.WriteLine("Введите высоту конуса: ");
                    try
                    {
                        H = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Вводить необходимо число!!!");
                        ++t;
                    }
                } while (t == 1);

                l = 0;
                try
                {
                    double s = (1 / 3);
                    V = (Math.PI * Math.Pow(R, 2) * H) * s;
                }
                catch when (double.IsInfinity(V))
                {
                    Console.WriteLine("Слишком большое значение. Программа запустится заново...");
                    Console.ReadLine();
                    ++l;
                }
                catch when (double.IsNaN(V))
                {
                    Console.WriteLine("Неявный ответ. Программа запустится заново...");
                    Console.ReadLine();
                    ++l;
                }
                

            } while (l == 1);
            
            Console.WriteLine("Объем конуса, в котором H = " + H + ", и R = " + R + ", равен " + V + ".");
        }
    }
}
