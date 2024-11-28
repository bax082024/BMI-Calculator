using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the BMI Calculator!");

            // Get weight
            Console.WriteLine("Enter weight in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Get height
            Console.WriteLine("Enter Height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());
        }

    }
}

