using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;
using System;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        [TestMethod]
        ///<summary>
        ///Testing if Grade F boundary at 0
        /// </summary>
        public void TestConvert0ToGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;

            //Act
            Grades actualGrade = converter.ConvertToGrade(0);

            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }


    }
}
