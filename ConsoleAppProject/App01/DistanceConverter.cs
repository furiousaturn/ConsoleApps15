using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Converts Miles to Feet
    /// </summary>
    /// <author>
    /// Andrew Stephenson version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        private double miles;
        private double feet;

        /// <summary>
        /// Main Run method
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            CalculateFeet();
            OutputFeet();
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }
        
        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        /// <summary>
        /// Features Stage 2
        /// </summary>
        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }
     
        /// <summary>
        /// Features Stage 1
        /// </summary>
        private void CalculateFeet() 
        {
            feet = miles * 5280;
        }

        /// <summary>
        /// Features Stage 2
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / 5280;
        }

        /// <summary>
        /// Features Stage 1
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet");
        }

        /// <summary>
        /// Features Stage 2
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine(feet + " feet is " +  miles+ " miles");
        }


        /// <summary>
        /// Features Stage 1
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("  Convert Miles to Feet  ");
            Console.WriteLine("  Convert Feet to Miles  ");
            Console.WriteLine("  By Andrew Stephenson   ");
            Console.WriteLine("-------------------------\n");
        }
    }
}
