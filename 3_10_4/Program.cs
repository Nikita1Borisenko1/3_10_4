using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace example_3_10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите длину последовательности: ");

            int count = int.Parse(ReadLine());

            int minNumber = int.MaxValue;

            for (int i = 0; i < count; i++)
            {
                Write("Введите число: ");

                int inputNumber = int.Parse(ReadLine());

                if (inputNumber < minNumber)
                {
                    minNumber = inputNumber;
                }
            }

            WriteLine($"Минимальное число последовательности: {minNumber}");
           ReadKey(true);
        }
    }
}