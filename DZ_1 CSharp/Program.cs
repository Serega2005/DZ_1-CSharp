using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            int s;
            char i;
            do
            {
                Console.WriteLine("Введите символ");
                s = Console.Read();
                if (s >= 65 && s <= 90)
                {
                    s += 32;
                    i = (char)s;
                    Console.WriteLine(i);
                }
                else if (s >= 97 && s <= 122)
                {
                    s -= 32;
                    i = (char)s;
                    Console.WriteLine(i);
                }
                else if (s == 46)
                {
                    break;
                }
                else
                {
                    i = (char)s;
                    Console.WriteLine(i);
                }
            } while (i != 46);
        }
    }
}
