using System;
using System.Text;

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
        public double Pound { get; set; }
        public int Inch { get; set; }
        public double Kilogram { get; set; }
        
        public int Centimetre { get; set; }
        public int Stone { get; set; }
        public int Feet { get; set; }

        public UnitSystems UnitSystems
        {
            get => default;
        }

        private double metre;

        //BMI Index
        public double IndexBMI;

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
            Console.WriteLine(OutputHealthMessage());
            Console.WriteLine(OutputBameMessage());
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
            Metre = InputNumber("Input height in metres > ");
            Kilogram = InputNumber("Input weight in kilograms > ");
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
            Pound = InputNumber("Input weight in Pounds > ");
            Pound += stones * POUNDS_IN_STONES;

            Console.WriteLine("Input your height (feet & inches)\n");
            double feet = InputNumber("Input height in Feet > ");
            Inch = (int)InputNumber("Input height in Inches > ");
            Inch += (int)feet * INCHES_IN_FEET;
        }

        /// <summary>
        /// Calculate the BMI from Metric 
        /// Details - Weight = Kilos and 
        /// Height = Metres 
        /// </summary>
        public void CalculateMetricBMI()
        {
            IndexBMI = Kilogram / (Metre * Metre);
        }

        /// <summary>
        /// Calculate the BMI from Imperial
        /// Details - Weight = Pounds and 
        /// Height is Inches
        /// </summary>
        public void CalculateImperialBMI()
        {
            IndexBMI = Pound * 703 / (Inch * Inch);
        }

        /// <summary>
        /// Output of BAME message 
        /// for higher risk people
        /// </summary>
        public string OutputBameMessage()
        {
            StringBuilder message = new StringBuilder("\n");


            message.Append("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            message.Append("There are higher risks for ");
            message.Append("Black, Asian or other minority people");
            message.Append("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            message.Append("Write a suitable message here!!");
            message.Append("explaining increased risk for BAME");
            message.Append("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            return message.ToString();
        }
    
        public string OutputHealthMessage()
        {
            StringBuilder message = new StringBuilder("\n");

            if (IndexBMI < UNDERWEIGHT)
            {
                message.Append($"BMI is {IndexBMI:0.00}, therefore" +
                    $"you are classed as underweight.");
            }
            else if (IndexBMI <= NORMAL)
            {
                message.Append($"BMI is {IndexBMI:0.00}, therefore" +
                    $"you are classed as normal weight.");
            }
            else if (IndexBMI <= OVERWEIGHT)
            {
                message.Append($"BMI is {IndexBMI:0.00}, therefore" +
                    $"you are classed as overweight.");
            }
            else if (IndexBMI <= OBESE_CLASS_I)
            {
                message.Append($"BMI is {IndexBMI:0.00}, therefore" +
                    $"you are classed as Obese Class I.");
            }
            else if (IndexBMI <= OBESE_CLASS_II)
            {
                message.Append($"BMI is {IndexBMI:0.00}, therefore" +
                    $"you are classed as Obese Class II.");
            }
            else if (IndexBMI <= OBESE_CLASS_III)
            {
                message.Append($"BMI is {IndexBMI:0.00}, therefore" +
                    $"you are classed as Obese Class III.");
            }

            return message.ToString();
        }

    }
}
