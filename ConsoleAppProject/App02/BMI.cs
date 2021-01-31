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
        public const int POUNDS_TO_STONES = 14;
        public const int INCHES_TO_FEET = 12;

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

        /// <summary>
        /// Main program in class
        /// </summary>
        public void CalculateBMI()
        {
            //yet to build
            Console.WriteLine("This is the BMI calculator under development");
        }

    }
}
