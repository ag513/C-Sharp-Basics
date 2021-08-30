using System;

namespace HellowWorld
{
    class SwitchCases
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your Bike Engine capacity(in CC)");
            string bikeCC = Console.ReadLine();
            switch (bikeCC)
            {
                case "250":
                    Console.WriteLine("Low end bike");
                    break;
                case "600":
                    Console.WriteLine("Mid range bike");
                    break;
                case "1000":
                    Console.WriteLine("High end bike");
                    break;
                default:
                    Console.WriteLine("PLEASE BURN YOU BIKE");
                    break;
            }
        }
    }

    class ErrorHandling
    {
        static void Main(String[] args)
        {
            int choice = 0;
            int[] numbers = { 10, 11, 12, 13, 14, 15 };
            Console.Write("Please enter the index of array:");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("numbers[{0}] = {1}", choice, numbers[choice]);
            }
            catch(IndexOutOfRangeException) 
            {
                Console.WriteLine("Error: Index should be from 0 to 5");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Enter an integer");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
