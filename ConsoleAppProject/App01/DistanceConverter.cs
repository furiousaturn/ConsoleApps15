using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app will aloow the user to convert:
    /// 1. Miles to Feet 
    /// 2. Feet to Miles
    /// 3. Miles to Metres
    /// 4. Metres to Miles
    /// 5. Feet to Metres
    /// 6. Metres to Feet
    /// 
    /// The program allows the user to select FROM distance unit
    /// then TO distance unit (both choices can be Feet, Metres or Miles)
    /// and displayed the conversion information.
    /// </summary>
    /// <author>
    /// Andrew Stephenson version 1.0
    /// </author>
    public class DistanceConverter
    {
        // Distance conversion constants
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        // From and to Distance variables
        public double FromDistance { get; set; } 
        public double ToDistance { get; set; } 

        // fromUnit and toUnit set as enumeration types
        public DistanceUnits FromUnit { get; set; }
        public DistanceUnits ToUnit { get; set; }

        //code created by class designer
        public DistanceUnits DistanceUnits
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Constructor to initialise fromUnit to Miles
        /// and toUnit to Feet using enumeration
        /// </summary>
        public DistanceConverter()
        {
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;
        }

        /// <summary>
        /// This method will input the distance measured in a choice
        /// of selected units, calculate the same distance in another
        /// selected unit, and output the converted distance relevant
        /// to the choices made.
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            FromUnit = SelectUnit(" Please select the from distance unit > ");
            ToUnit = SelectUnit(" Please select the to Distance unit > ");

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");

            FromDistance = InputDistance($" Please enter the number of {FromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// Calculates the conversions depending on the distance unit
        /// selections of fromUnit and toUnit. There are 6 possible 
        /// conversion calculations that can be made (see class header)
        /// </summary>
        public void CalculateDistance()
        {
            if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Miles)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Metres)
            {
                ToDistance = FromDistance * FEET_IN_METRES;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance / FEET_IN_METRES;
            }
        }

        /// <summary>
        /// Display a menu of distance units and then prompt the
        /// user to select one and return it.
        /// </summary>
        private DistanceUnits SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            DistanceUnits unit = ExecuteChoice(choice);

            return unit;
        }

        /// <summary>
        /// Displays choices for TO and FROM unit conversions, 
        /// i.e. Feet, Metres and Miles, Displaying options from
        /// enumeration class - DistanceUnits.
        /// User can then make a choice which is returned.
        /// </summary>
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {DistanceUnits.Feet}");
            Console.WriteLine($" 2. {DistanceUnits.Metres}");
            Console.WriteLine($" 3. {DistanceUnits.Miles}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();

            return choice;
        }
        
        /// <summary>
        /// From choice being made, the unit from the enumeration
        /// is set depending on the choice (1,2 or 3).
        /// Error is displayed if outside the choices (1,2,or 3) is made,
        /// Indicated with the enumeration = noUnit.
        /// </summary>
        private DistanceUnits ExecuteChoice(string choice)
        {
            //used to store local choice of unit
            DistanceUnits unit;

            switch (choice)
            {
                case "1": unit = DistanceUnits.Feet; break;
                case "2": unit = DistanceUnits.Metres; break;
                case "3": unit = DistanceUnits.Miles; break;

                default: unit = DistanceUnits.NoUnit; break;
            }

            if (unit == DistanceUnits.NoUnit)
            {
                Console.WriteLine("Invalid Choice!");
                Console.WriteLine("Must be a digit 1 to 3");
            }

            Console.WriteLine($"\n You have chosen {unit}");
            return unit;
        }
       
        /// <summary>
        /// Prompt the user to enter the distance in chosen unit
        /// Input the chosen unit as a double number.
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// Outputs the FROM and TO distances and units
        /// converted.
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {FromDistance} {FromUnit} " +
                $" is {ToDistance} {ToUnit}!\n");
        }

        /// <summary>
        /// General Heading displayed at the start of the program
        /// running to identify the nature of the program.
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
