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
            int e, count = 0;
            char i;
            do
            {
                Console.WriteLine("Введите символ");
                e = Console.Read();

                if (e >= 65 && e <= 90)
                {
                    e += 32;
                    i = (char)e;
                    Console.WriteLine(i);

                }
                else if (e >= 97 && e <= 122)
                {
                    e -= 32;
                    i = (char)e;
                    Console.WriteLine(i);
                }
                else if (e == 46)
                {
                    break;
                }
                else
                {
                    i = (char)e;
                    Console.WriteLine(i);
                }
                count++;
            } while (i != '.');
            Console.WriteLine("Всего введено " + count + " символов");
        }
    }
}
