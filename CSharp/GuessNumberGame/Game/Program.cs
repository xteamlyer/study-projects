using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1ое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите 2ое число: ");
            int y = int.Parse(Console.ReadLine());

            Random random = new Random();
            int k = random.Next(x, y);
            int count = 0;
            string str;

            Console.WriteLine("Угадайте число в интервале от {0} до {1}\n", x, y);

            do
            {
                Console.Write("Ваш вариант: ");
                str = Console.ReadLine();

                if (int.Parse(str) < k)
                    Console.WriteLine("Задуманное число больше");
                if (int.Parse(str) > k)
                    Console.WriteLine("Задуманное число меньше");

                count++;
            }
            while (
            int.Parse(str) != k);

            Console.WriteLine("Вы угадали с {0} попытки", count);
            Console.ReadLine();
            
           
        }
    }
}
