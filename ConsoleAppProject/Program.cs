using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.App05;
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
        private static StudentGrades grader = new StudentGrades();
        private static NetworkApp social = new NetworkApp();
        private static GameView rps = new GameView();


        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Beep();

            ConsoleHelper.OutputHeading("BNU CO453 Applications Programming 2020 - 2021!");

            //provide choices for APP01 and App02 here - temporary and will change and expand.
            string[] choices = { "Distance Converter", "BMI Calculator", 
                                  "Student Marks", "Social Network",
                                  "Rock-Paper_Scissors Game"};

            int option = ConsoleHelper.SelectChoice(choices);

            if (option == 1)
            {
                converter.ConvertDistance();
            }
            else if (option == 2)
            {
                calculator.CalculateIndex();
            }
            else if (option == 3)
            {
                grader.OutputMenu();
            }
            else if (option == 4)
            {
                social.DisplayMenu();
            }
            else if (option == 5)
            {
                rps.Play();
            }
            else Console.WriteLine("Invalid Choice !");
        }
    }
}
