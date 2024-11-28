using System;
using System.IO;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the BMI Calculator!");

            Console.WriteLine("BMI Categories:");
            Console.WriteLine("Underweight: less than 18.5");
            Console.WriteLine("Normal weight: 18.5 to 24.9");
            Console.WriteLine("Overweight: 25 to 29.9");
            Console.WriteLine("Obesity: 30 or more");
            Console.WriteLine();

            double weight = GetValidInput("Enter weight in kilogram: ");
            Console.WriteLine("Enter your height in centimeters: ");
            double heightInCm = Convert.ToDouble(Console.ReadLine());
            double height = heightInCm / 100;

            // Calculate BMI 
            double bmi = weight / (height * height);

            // BMI Category
            string category;
            if (bmi < 18.5)
            {
                category = "Underweight";
                
            }
            else if (bmi < 25)
            {
                category = "Normal weight";
            }
            else if (bmi < 30)
            {
                category = "Overweight";
            }
            else
            {
                category = "Obesity";
            }


            // Display result
            Console.WriteLine($"Your BMI is {bmi:F2}. You are classified as: {category}");


          
        }

        static double GetValidInput(string prompt)
        {
            double value;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value) && value > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
            return value;
        }

    }
}

