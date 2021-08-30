using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            void PrintELementFromArray(int[] a)
            {
                Console.WriteLine("First Element is {0}", a[0]);
            }

            int[] array = { 1, 2, 3, 4, 5 };
            PrintELementFromArray(array);

            int[] ReturnUserInput()
            {
                int[] a = new int[3];

                for (int i = 0; i <= a.Length; i++)
                {
                    Console.Write("Enter integer");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Integer added to array");
                }
                return a;
            }
            int[] formedArray = ReturnUserInput();

            List<int> ReturnUserInputLists()
            {
                List<int> a = new List<int>();

                for (int i = 0; i <= 3; i++)
                {
                    Console.Write("Enter integer");
                    a[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Integer added to array");
                }
                return a;
            }

            List<int> formedList = ReturnUserInputLists();

            void PrintNames(params string[] names)
            {
                for(int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i] + " ");
                }
                Console.WriteLine();
            }

            PrintNames("Abhi");
            PrintNames("Abhinav", "Gunishetty");
        }
    }
}
