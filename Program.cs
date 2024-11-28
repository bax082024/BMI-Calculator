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
                category = "Obesity";
            }


            // Display result
            Console.WriteLine("Your BMI is: {bmi:F2}. You are classified as: {category} ");
            
        }

    }
}

