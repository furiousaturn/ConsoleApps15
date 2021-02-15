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
        //Properties of class
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

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
        /// Convert a mark into a grade 
        /// using grade boundaries
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculate Mean, Minimum and Maximum 
        /// mark for all students
        /// </summary>
        public void CalculateStats()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Percentage of students obtaining each Grade
        /// </summary>
        public void CalculateGradeProfile()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Outputs Grades for each student
        /// </summary>
        public void OutputGrades()
        {
            throw new NotImplementedException();
        }
    }
}
