using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
using System;

namespace ConsoleApp.Tests
{
    /// <summary>
    /// Boundary testing for Student Grades
    /// </summary>
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();
        private int[] testMarks;

        public TestStudentGrades()
        {
            testMarks = new int[]
            {
                10,20,30,40,50,60,70,80,90,100
            };
        }

        [TestMethod]
        ///<summary>
        ///Testing if Grade F boundary at 0
        /// </summary>
        public void TestLowestGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(0);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        ///<summary>
        ///Testing if Grade F at upper boundary
        /// </summary>
        public void TestHighestGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(39);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        ///<summary>
        ///Testing if Grade D at lower boundary
        /// </summary>
        public void TestLowestGradeD()
        {
            //Arrange
            Grades expectedGrade = Grades.D;

            //Act
            Grades actualGrade = converter.ConvertToGrade(40);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        ///<summary>
        ///Testing if Grade D at higest boundary
        /// </summary>
        public void TestHighestGradeD()
        {
            //Arrange
            Grades expectedGrade = Grades.D;

            //Act
            Grades actualGrade = converter.ConvertToGrade(49);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        ///<summary>
        ///Testing if Grade C at lowest boundary
        /// </summary>
        public void TestLowestGradeC()
        {
            //Arrange
            Grades expectedGrade = Grades.C;

            //Act
            Grades actualGrade = converter.ConvertToGrade(50);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        ///<summary>
        ///Testing if Grade C at Highest boundary
        /// </summary>
        public void TestHighestGradeC()
        {
            //Arrange
            Grades expectedGrade = Grades.C;

            //Act
            Grades actualGrade = converter.ConvertToGrade(59);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        ///<summary>
        ///Testing if Grade B at Lowest boundary
        /// </summary>
        public void TestLowestGradeB()
        {
            //Arrange
            Grades expectedGrade = Grades.B;

            //Act
            Grades actualGrade = converter.ConvertToGrade(60);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        ///<summary>
        ///Testing if Grade B at Highest boundary
        /// </summary>
        public void TestHighestGradeB()
        {
            //Arrange
            Grades expectedGrade = Grades.B;

            //Act
            Grades actualGrade = converter.ConvertToGrade(69);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        ///<summary>
        ///Testing if Grade A at Lowest boundary
        /// </summary>
        public void TestLowestGradeA()
        {
            //Arrange
            Grades expectedGrade = Grades.A;

            //Act
            Grades actualGrade = converter.ConvertToGrade(70);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        ///<summary>
        ///Testing if Grade A at Highest boundary
        /// </summary>
        public void TestHighestGradeA()
        {
            //Arrange
            Grades expectedGrade = Grades.A;

            //Act
            Grades actualGrade = converter.ConvertToGrade(100);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        ///<summary>
        ///Testing the Mean calculation from a mark
        /// </summary>
        public void TestCalculateMean()
        {
            //Arrange
            converter.Marks = testMarks;
            double expectMean = 55.0;

            //Act
            converter.CalculateStats();

            //Assert
            Assert.AreEqual(expectMean, converter.Mean);
        }

        [TestMethod]
        ///<summary>
        ///Testing the Minimum mark
        /// </summary>
        public void TestCalculateMin()
        {
            //Arrange
            converter.Marks = testMarks;
            double expectMin = 10.0;

            //Act
            converter.CalculateStats();

            //Assert
            Assert.AreEqual(expectMin, converter.MinMark);
        }

        [TestMethod]
        ///<summary>
        ///Testing the Maximum mark
        /// </summary>
        public void TestCalculateMax()
        {
            //Arrange
            converter.Marks = testMarks;
            double expectMin = 100.0;

            //Act
            converter.CalculateStats();

            //Assert
            Assert.AreEqual(expectMin, converter.MaxMark);
        }

        [TestMethod]
        ///<summary>
        ///Testing the grade profiles
        /// </summary>
        public void TestGradeProfile()
        {
            //Arrange
            converter.Marks = testMarks;

            //Act
            converter.CalculateGradeProfile();
            bool expectedProfile;
            expectedProfile = ((converter.GradeProfile[0] == 3) &&
                               (converter.GradeProfile[1] == 1) &&
                               (converter.GradeProfile[2] == 1) &&
                               (converter.GradeProfile[3] == 1) &&
                               (converter.GradeProfile[4] == 4));
            
            //Assert
            Assert.IsTrue(expectedProfile);
        }
    }
}
