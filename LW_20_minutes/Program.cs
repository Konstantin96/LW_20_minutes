using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_20_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            task2();
        }

        /// <summary>
        /// Даны два целых положительных числа произвольной длины (стоящие из любого количества цифр)
        /// </summary>
        static ulong task1()
        {
            //1234567889012345678890123457
            //68890123456788901234567889012

            ulong a = 0;
            if (UInt64.TryParse(Console.ReadLine(), out a))
            {
                ulong ba = 0;
                if (UInt64.TryParse(Console.ReadLine(), out ba))
                    return a + ba;
            }

            return 0;
        }

        static void task2()
        {
            ulong a = UInt64.Parse(Console.ReadLine());
            ulong s = 0;
            while (a > 0)
            {
                s = s + a % 10;
                a = a / 10;
            }
            Console.WriteLine(s);
        }
    }
}
