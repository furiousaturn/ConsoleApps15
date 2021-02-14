using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using System;
using ConsoleHelpers;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Andrew Stephenson 22/01/2021
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();
        private static BMI calculator = new BMI();


        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Beep();

            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2020 - 2021!");

            //provide choices for APP01 and App02 here - temporary and will change and expand.
            string[] choices = { "Distance Converter", "BMI Calculator" };
            int option = ConsoleHelper.SelectChoice(choices);
            
            if (option == 1)
            {
                converter.ConvertDistance();
            }
            else if (option == 2)
            {
                calculator.CalculateIndex();
            }  
        }
    }
}
