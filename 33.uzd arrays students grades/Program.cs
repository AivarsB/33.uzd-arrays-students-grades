using System;
using System.Collections.Generic;

namespace _33.uzd_arrays_and_average
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsNames = new[] { "Janis", "Juris" };
            int[] student1Rating = new[] { 4, 5, 6, 7, 8 };
            int[] student2Rating = new[] { 5, 6, 7, 8, 9, 4, 5, 6, 1, 1 };

            int[] grades = new int[studentsNames.Length];

            Console.WriteLine($"{studentsNames[0]} {GetAverageValue(student1Rating)}");
            Console.WriteLine($"{studentsNames[1]} {GetAverageValue(student2Rating)}");
        }

        static double GetAverageValue(int[] values)
        {
            var sum = 0;

            foreach (var value in values)
            {
                sum += value;
            }

            return sum / values.Length;
        }
    }
}

// Izveidot 3 masīvus.Pirmajā masīvā ir studentu vārdi.
// Otrajā masīvā ir pirmā studenta atzīmes.Trešajā masīvā ir otrā studenta atzīmes.
// Izvadīt uz ekrāna studenta vārdu un viņa vidējo atzīmi.
