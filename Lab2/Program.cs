using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus's Room Detail Generator!");
            do
            {
                Console.Write("\nPlease enter the length: ");
                float l = GetFloat();
                Console.Write("Please enter the width: ");
                float w = GetFloat();
                Console.Write("Please enter the height: ");
                float h = GetFloat();

                Console.WriteLine($"\nThe area is: {GetArea(l, w)}");
                Console.WriteLine($"The perimeter is: {GetPerimeter(l, w)}");
                Console.WriteLine($"The volume is: {GetVolume(l, w, h)}");

            } while (KeepGoing());

            Console.WriteLine("\n\n--------------------------------------------");
            Console.WriteLine("End of Demonstration. Press any key to exit.");
            Console.ReadKey();
        }

        private static float GetFloat()
        {
            while (true)
            {
                if (float.TryParse(Console.ReadLine(), out float value)) return value;
                Console.WriteLine("Invalid Entry. Please enter a number.");
            }
        }
        private static float GetPerimeter(float l, float w)
        {
            return 2 * l + 2 * w;
        }
        private static float GetArea(float l, float w)
        {
            return l * w;
        }
        private static float GetVolume(float l, float w, float h)
        {
            return GetArea(l, w) * h;
        }
        private static bool KeepGoing()
        {
            Console.Write("\nWould you like to keep measuring rooms? (y/n): ");
            while (true)
            {
                string choice = Console.ReadLine();
                if (choice.ToLower() == "y") return true;
                if (choice.ToLower() == "n") return false;
                Console.WriteLine("Please enter either y or n");
            }
        }
    }
}
