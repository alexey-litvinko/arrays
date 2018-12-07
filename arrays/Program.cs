using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static ulong Vvod(string prigl)
        {
            ulong number;
            ulong element;
            while (true)
            {
                Console.WriteLine(prigl);
                string input = Console.ReadLine();
                if (ulong.TryParse(input, out number))
                {
                    element = number;
                    return element;
                }
                else
                {
                    Console.WriteLine("Неправильно! Введите целое положительное число.");
                }
            }
        }
        static double Element(string prigl)
        {
            double number;
            double element;
            while (true)
            {
                Console.WriteLine(prigl);
                string input = Console.ReadLine();
                if (double.TryParse(input, out number))
                {
                    element = number;
                    return element;
                }
                else
                {
                    Console.WriteLine("Неправильно введен элемент!");
                }
            }
        }
        static double[,] Array_input(string prigl, ulong i, ulong j)
        {
            double[,] array = new double[i, j];
            for (ulong a = 0; a < i; ++a)
            {
                for (ulong b = 0; b < j; ++b)
                {
                    array[a, b] = Element("Введите значение элемента массива");
                    Console.WriteLine("[" + a + "," + b + "]" + array[a,b]);
                }
            }            
            return array;
        }

        static void Main(string[] args)
        {
            ulong i = Vvod("Введите количество строк первого массива");
            ulong j = Vvod("Введите количество столбцов первого массива");
            double[,] first_array = Array_input("Введите элементы первого массива", i, j);
            ulong n = Vvod("Введите количество строк второго массива");
            ulong m = Vvod("Введите количество столбцов второго массива");
            double[,] second_array = Array_input("Введите элементы второго массива", n, m);
            ulong x = i > n ? i : n;
            ulong y = j > m ? j : m;
            double[,] sum_array = new double[x, y];
            for (ulong a = 0; a < x; ++a)
            {
                for (ulong b = 0; b < y; ++b)
                {
                    try
                    {
                        sum_array[a, b] = first_array[a, b];                        
                    }
                    catch
                    {
                        sum_array[a, b] = 0;
                    }
                    try
                    {
                        sum_array[a, b] += second_array[a, b];                       
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine("Массив сумм элементов первого и второго массивов");
            for (ulong a = 0; a < x; ++a)
            {
                for (ulong b = 0; b < y; ++b)
                {
                    Console.Write(sum_array[a, b] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}