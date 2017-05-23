//Определить объем конуса с заданным радиусом основания R и высотой H
using System;
namespace Konus
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите радиус основания конуса: ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту конуса: ");
            double H = Convert.ToDouble(Console.ReadLine());
            
            double V = (Math.PI * Math.Pow(R, 2) * H)/3;
            
            Console.WriteLine("Объем конуса, в котором H = " + H + ", и R = " + R + ", равен " + V + ".");
        }
    }
}