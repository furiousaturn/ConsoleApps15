using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will prompt the user to input a distance
    /// measured in one uit (fromUnit) and it will calculate 
    /// and output the equivalent distance in another unit (toUnit)
    /// </summary>
    /// <author>
    /// Andrew Stephenson version 0.1 (this can be updated each time)
    /// </author>
    public class DistanceConverter
    {
        
        //Distance conversion constants

        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        //Distance Unit Names

        public const string FEET = "Feet";
        public const string MILES = "Miles";
        public const string METRES = "Metres";

        // Distance variables

        private double fromDistance;
        private double toDistance;

        //Unit variables
        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feet, and output
        /// distance in feet
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading($"Converting {fromUnit} to {toUnit}");
            fromDistance = InputDistance($"Please enter the number of {fromUnit} > ");
            //CalculateFeet();
            OutputDistance();
        }

        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }


        /// <summary>
        /// Features Stage 1
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"{fromDistance} {fromUnit} " +
                $" is {toDistance} {toUnit}!");
        }

        
        /// <summary>
        /// Features Stage 1
        /// </summary>
        private void OutputHeading(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("    DISTANCE CONVERTER");
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("  By Andrew Stephenson   ");
            Console.WriteLine("-------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine();
        }
    }
}
