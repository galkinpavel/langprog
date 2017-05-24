using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static bool HasAlphabeticalOrder(string text)
        {
            // запятые и пробелы предусматриваю на всякий случай
            text = text.Trim(new char[] { ' ', '.', ',' });
            for (int i = 1; i < text.Length; i++)
            {
                // если текущий символ не больше предыдущего на единицу
                // то буквы расположены не по алфавиту
                if (text[i - 1] != text[i] - 1)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.WriteLine("{0} по алфавиту? {1}", text, HasAlphabeticalOrder(text));
            string текст_по_алфавиту = "ЖЗИЙКЛМНОПРСТУФХ.";
            string текст_не_по_алфавиту = "ЖЗИВЙКЛМНОПМРСТУФХ.";
            Console.WriteLine("{0} по алфавиту? {1}", текст_по_алфавиту, HasAlphabeticalOrder(текст_по_алфавиту));
            Console.WriteLine("{0} по алфавиту? {1}", текст_не_по_алфавиту, HasAlphabeticalOrder(текст_не_по_алфавиту));
        }
    }
}
