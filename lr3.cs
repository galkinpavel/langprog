/*
Даны целые числа X, Y, Z. Если числа не равны, то 
заменить каждое из них одним и тем же числом, 
равным меньшему из исходных, а если равны,
вывести сообщение об этом.
*/
using System;
namespace Konus
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите целые числа: ");   
            Console.WriteLine("X = ");
            double X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y = ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Z = ");
            double Z = Convert.ToDouble(Console.ReadLine());
            
            if ((X == Y) && (X == Z) && (Y == Z))   
            {
                Console.WriteLine("Введенные числа равны");
            }
            
            else  
            {
                double max;
                if (X > Y)   
                {
                    max = X;
                }
                else  
                {
                    max = Y;
                }
                if (max < Z)
                {
                    max = Z;
                }
                X = max;
                Y = max;
                Z = max;
                Console.WriteLine("X = " + X);
                Console.WriteLine("Y = " + Y);
                Console.WriteLine("Z = " + Z);
            }
            
        }
    }
}