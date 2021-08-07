using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int one, two, three, four, five, six;
            Console.WriteLine("Введите номер билета\n");
            Console.WriteLine("Введите 1 число билета:"); one = int.Parse(Console.ReadLine());
            if (one > 9)
            {
                Console.WriteLine("В билете не может быть у одного числа больше 2 знаков"); 
                return;
            }
            Console.WriteLine("Введите 2 число билета:"); two = int.Parse(Console.ReadLine());
            if (two > 9)
            {
                Console.WriteLine("В билете не может быть у одного числа больше 2 знаков");
                return;
            }
            Console.WriteLine("Введите 3 число билета:"); three = int.Parse(Console.ReadLine());
            if (three > 9)
            {
                Console.WriteLine("В билете не может быть у одного числа больше 2 знаков");
                return;
            }
            Console.WriteLine("Введите 4 число билета:"); four = int.Parse(Console.ReadLine());
            if (four > 9)
            {
                Console.WriteLine("В билете не может быть у одного числа больше 2 знаков");
                return;
            }
            Console.WriteLine("Введите 5 число билета:"); five = int.Parse(Console.ReadLine());
            if (five > 9)
            {
                Console.WriteLine("В билете не может быть у одного числа больше 2 знаков");
                return;
            }
            Console.WriteLine("Введите 6 число билета:"); six = int.Parse(Console.ReadLine());
            if (six > 9)
            {
                Console.WriteLine("В билете не может быть у одного числа больше 2 знаков");
                return;
            }
            if (one+two+three==four+five+six)
            {
                Console.WriteLine("Билет счасливый");
            }
            else
            {
                Console.WriteLine("Билет не счасливый");
            }
        }
    }
}
