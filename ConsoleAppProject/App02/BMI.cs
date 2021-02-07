using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// The BMI class has methods to calculate the 
    /// Body Mass Index (BMI) using a choice of
    /// Imperial or Metric Units
    /// </summary>
    /// <author>
    ///  Andrew Stephenson version 0.1
    /// </author>
    public class BMI
    {
        //Constants for how many pounds in a stone
        //and how many inches in a foot.
        public const int POUNDS_IN_STONES = 14;
        public const int INCHES_IN_FEET = 12;

        //Constants to define upper limit values
        //defined in the WHO Weight Status table
        public const double UNDERWEIGHT = 18.5;
        public const double NORMAL = 24.9;
        public const double OVERWEIGHT = 29.9;
        public const double OBESE_CLASS_I = 34.9;
        public const double OBESE_CLASS_II = 39.9;
        public const double OBESE_CLASS_III = 40.0;

        //Imperial and Metric variables
        private double pound;
        private int inch;
        private double kilogram;
        private double metre;

        //BMI Index
        public double indexBMI;

        /// <summary>
        /// Ask user to select units of measurment
        /// to work with, either Imperial or Metric.
        /// Get the height and weight of the user
        /// to calculate the BMI.  Dipaly the weight category
        /// according to set categories in the program
        /// </summary>
        public void CalculateIndex()
        {
            //Simple heading for application
            Console.WriteLine("-=-=-=-=-=-=-=-=");
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("-=-=-=-=-=-=-=-=");

            //Select units method called to make the unit choice
            UnitSystems unitSystem = SelectUnits();

            //Decision made of choice - imperial or metric
            if (unitSystem == UnitSystems.Imperial)
            {
                InputImperialDetails();
                CalculateImperialBMI();
            }
            else
            {
                InputMetricDetails();
                CalculateMetricBMI();
            }

            //Output the required messages for BMI calculations
            //and if you are BAME and therefore at higher risk
            OutputHealthMessage();
            OutputBameMessage();
        }

        /// <summary>
        /// Get the Users choice of unit, either
        /// Imperial or Metric from a basic menu.
        /// </summary>
        private UnitSystems SelectUnits()
        {
            Console.WriteLine("1. Imperial Units");
            Console.WriteLine("2. Metric Units");

            Console.Write("\n Choose your unit type > ");
            string typeChoice = Console.ReadLine();

            if (typeChoice == "1") return UnitSystems.Imperial;
            else return UnitSystems.Metric;
        }

        /// <summary>
        /// Method prompts user and
        /// allows input of a number
        /// converted to a double
        /// </summary>
        public double InputNumber(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            double number = Convert.ToDouble(value);

            return number;
        }

        /// <summary>
        /// Input metric values for 
        /// height in metres and 
        /// weight in kilograms.
        /// </summary>
        private void InputMetricDetails()
        {
            metre = InputNumber("Input height in metres > ");
            kilogram = InputNumber("Input weight in kilograms > ");
        }

        /// <summary>
        /// Input imperial details and convert 
        /// height into inches  and weight
        /// into pounds. 
        /// </summary>
        private void InputImperialDetails()
        {
            Console.Write("Input your weight (stones & pounds)\n");
            double stones = InputNumber("Input weight in Stones > ");
            pound = InputNumber("Input weight in Pounds > ");
            pound += stones * POUNDS_IN_STONES;

            Console.WriteLine("Input your height (feet & inches)\n");
            double feet = InputNumber("Input height in Feet > ");
            inch = (int)InputNumber("Input height in Inches > ");
            inch += (int)feet * INCHES_IN_FEET;
        }

        /// <summary>
        /// Calculate the BMI from Metric 
        /// Details - Weight = Kilos and 
        /// Height = Metres 
        /// </summary>
        public void CalculateMetricBMI()
        {
            indexBMI = kilogram / (metre * metre);
        }

        /// <summary>
        /// Calculate the BMI from Imperial
        /// Details - Weight = Pounds and 
        /// Height is Inches
        /// </summary>
        public void CalculateImperialBMI()
        {
            indexBMI = pound * 703 / (inch * inch);
        }

        /// <summary>
        /// Output of BAME message 
        /// for higher risk people
        /// </summary>
        public void OutputBameMessage()
        {
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("There are higher risks for ");
            Console.WriteLine("Black, Asian or other minority people");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("Write a suitable message here!!");
            Console.WriteLine("explaining increased risk for BAME");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }
    
        public void OutputHealthMessage()
        {
            if (indexBMI < UNDERWEIGHT)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore" +
                    $"you are classed as underweight.");
            }
            else if (indexBMI <= NORMAL)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore" +
                    $"you are classed as normal weight.");
            }
            else if (indexBMI <= OVERWEIGHT)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore" +
                    $"you are classed as overweight.");
            }
            else if (indexBMI <= OBESE_CLASS_I)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore" +
                    $"you are classed as Obese Class I.");
            }
            else if (indexBMI <= OBESE_CLASS_II)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore" +
                    $"you are classed as Obese Class II.");
            }
            else if (indexBMI <= OBESE_CLASS_III)
            {
                Console.WriteLine($"BMI is {indexBMI:0.00}, therefore" +
                    $"you are classed as Obese Class III.");
            }
        }

    }
}
