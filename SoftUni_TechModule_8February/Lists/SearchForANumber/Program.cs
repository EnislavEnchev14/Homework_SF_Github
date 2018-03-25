using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchForANumber
{
    class Program
    {
        static void Main()
        {
            List<int> inputList = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToList();

            int[] conditions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<int> result = new List<int>();

            int elementsToTake = conditions[0];

            int elementsToDelete = conditions[1];

            for (int i = 0; i < elementsToTake; i++)
            {
                result.Add(inputList[i]);
            }

            for (int i = 0; i < elementsToDelete; i++)
            {
                result.RemoveAt(0);
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == conditions[2])
                {
                    Console.WriteLine("YES!");
                    return;
                }                              
            }

            Console.WriteLine("NO!");


        }
    }
}
