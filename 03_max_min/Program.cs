/*
 Завдання 3. 
 Визначити метод для знаходження у одновимірному масиву максимального та мінімального. 
    Метод повинен повертати ці значення через свої параметри. 
    void MaxMin(int [] arr, .... int max, .... int min)
 */

using System;
using System.Linq;

namespace _03_max_min
{
    class Program
    {
        static void MaxMin(int[] arr, out int max, out int min)
        {
            max = arr.Max();
            min = arr.Min();
        }

        static void Main(string[] args)
        {
            int[] arr = { -3, 5, 9, 1, 17, -5, 0 };

            foreach (var a in arr)
                Console.Write($"{a}\t");

            MaxMin(arr, out int max, out int min);
            Console.WriteLine($"\nMax = {max}\nMin = {min}");
        }
    }
}
