using System;
namespace exponentation
{
    public class Program
    {
        public static void Main()
        {
            string repetition = "empty";
            do
            {
                Console.Write("Введите [a] в выражении a^n: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите натуральное число [n] в выражении a^n: ");
                int n = int.Parse(Console.ReadLine());
                double counter = 1;
                double rezult = 1;
                while (counter <= n)
                {
                    rezult *= a;
                    counter++;
                }
                Console.WriteLine("a^n = " + rezult);
                
                rezult = 1;
                counter = 1;
                do
                {
                    rezult *= a;
                    counter++;
                } while (counter <= n);
                Console.WriteLine("a^n = " + rezult);
                for (counter = 1, rezult = 1; counter <= n; rezult *= a, counter++);
                Console.WriteLine("a^n = " + rezult);
                Console.Write("Хотите попробовать снова? Если да, введите [ДА] ");
                repetition = Console.ReadLine();
            } while (repetition == "ДА");
        } 
    }
}