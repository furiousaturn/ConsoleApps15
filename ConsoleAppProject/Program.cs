using ConsoleAppProject.App01;
using ConsoleAppProject.App02;

using System;

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
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();

            //provide choices for APP01 and App02 here - temporary and wil change and expand.
            Console.WriteLine("\n Options\n");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\n 1. Distance Converter\n");
            Console.WriteLine("\n 2. BMI Calculator\n");

            Console.WriteLine("Please enter your choice > ");
            string option = Console.ReadLine();

            if (option == "1")
            {
                converter.ConvertDistance();
            }
            else if (option == "2")
            {
                calculator.CalculateBMI();
            }


            
            
        }
    }
}
