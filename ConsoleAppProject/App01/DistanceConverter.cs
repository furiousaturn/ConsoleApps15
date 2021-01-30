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
            OutputHeading();

            fromUnit = SelectUnit(" Please select the from distance unit > ");
            toUnit = SelectUnit(" Please select the to Distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");
           
            fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit ==FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            string unit = ExecuteChoice(choice);
            
            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }
            
        private static string ExecuteChoice(string choice)
        {
            if (choice == "1")
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METRES;
            }
            else if (choice == "3")
            {
                return MILES;
            }

            return null;
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
            Console.WriteLine($"\n {fromDistance} {fromUnit} " +
                $" is {toDistance} {toUnit}!\n");
        }

        
        /// <summary>
        /// Features Stage 1
        /// </summary>
        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("    DISTANCE CONVERTER");
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("  By Andrew Stephenson   ");
            Console.WriteLine("-------------------------\n");

            
        }
    }
}
