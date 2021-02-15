using System;
using ConsoleHelpers;

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

        //additional code created by class designer
        //for association
        public DistanceUnits DistanceUnits
        {get => default; set{}}

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
            ConsoleHelper.OutputHeading("Distance Converter");

            FromUnit = SelectUnit(" Please select the from distance unit > ");
            ToUnit = SelectUnit(" Please select the to Distance unit > ");

            Console.WriteLine($"\n Converting {FromUnit} to {ToUnit}");

            FromDistance = ConsoleHelper.InputNumber($" Please enter the number of {FromUnit} > ");

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
            string[] choices =
            {
                DistanceUnits.Feet.ToString(),
                DistanceUnits.Metres.ToString(),
                DistanceUnits.Miles.ToString()
            };

            Console.Write("\n");
            Console.WriteLine(prompt);
            Console.Write("\n");

            int choiceNo = ConsoleHelper.SelectChoice(choices);

            //Works but might be a neater way to 
            //convert choice to enum value.
            if (choiceNo==1) 
            {
                return DistanceUnits.Feet;
            }
            else if (choiceNo==2)
            {
                return DistanceUnits.Metres;
            }
            else
            {
                return DistanceUnits.Miles;
            }
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
    }
}
