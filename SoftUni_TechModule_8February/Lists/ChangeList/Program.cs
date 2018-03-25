using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main()
        {
            List<int> inputList = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "Even" & inputLine != "Odd")
            {
                string[] command = inputLine
                    .Split(' ')
                    .ToArray();

                if (command[0] == "Delete")
                {
                    int number = int.Parse(command[1]);

                    for (int i = 0; i < inputList.Count; i++)
                    {
                        inputList.Remove(number);
                    }

                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    inputList.Insert(index, element);
                }

                    inputLine = Console.ReadLine();
            }

            if (inputLine == "Odd")
            {

                foreach (var element in inputList)
                {
                    if (element % 2 != 0)
                    {
                        Console.Write(element + " ");
                    }
                }

            }
            else
            {
                foreach (var element in inputList)
                {
                    if (element % 2 == 0)
                    {
                        Console.Write(element + " ");
                    }
                }
            }
        }
    }
}
