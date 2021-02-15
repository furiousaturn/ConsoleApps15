using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// This class calculates grades and stats information 
    /// based on student marks for 10 students.
    /// </summary>
    public class StudentGrades
    {
        //constants
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        //Properties 
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int MinMark { get; set; }
        public int MaxMark { get; set; }


        //Associations in class diagram
        public Grades Grades
        {get => default;set{}}
        
        /// <summary>
        /// Constructor
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
                "Paul","John", "Ringo",
                "George", "Fred", "Bill",
                "Anna", "Millie", "Jane",
                "Karen"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// Display menu of options
        /// </summary>
        public void OutputMenu()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prompt the user to enter a single mark between 
        /// 0 and 100 for each of the students
        /// </summary>
        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List all the students and display 
        /// their name and current mark
        /// </summary>
        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// List all the students and display 
        /// their name and current Grade
        /// </summary>
        public void OutputGrades()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Output Stats - Mean. Max, Min
        /// </summary>
        public void OutputStats()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Outputs Grades for each student
        /// </summary>
        public void OutputGradeProfile()
        {
            Grades grade = Grades.F;
            Console.WriteLine();

            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade}  {percentage}% Count {count}");
                grade++;
            }
            Console.WriteLine();
        }

        

        /// <summary>
        /// Convert a mark into a grade 
        /// using grade boundaries
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >=LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >=LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else
            {
                return Grades.A;
            }
            return Grades.F;
        }

        /// <summary>
        /// Calculate Mean, Minimum and Maximum 
        /// mark for all students
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;
            MinMark = HighestMark;
            MaxMark = LowestMark;

            foreach(int mark in Marks)
            {
                total += mark;
                if (mark > MaxMark) MaxMark = mark;
                if (mark < MinMark) MinMark = mark;
            }

            Mean = total / Marks.Length;
        }

        /// <summary>
        /// Percentage of students obtaining each Grade
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
            OutputGradeProfile();
        }

       
    }
}
