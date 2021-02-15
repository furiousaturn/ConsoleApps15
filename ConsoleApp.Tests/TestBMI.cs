using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;
using System;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestBMI
    {
        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Metric Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Centimetres(CM) and weight in kilograms (KG)
        /// </summary>
        public void TestMetricOverWeight()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.metre = 1.88;
            bmi.Kilogram = 101;

            //Act Stage
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 28.58;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.IndexBMI,2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Metric Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Centimetres(CM) and weight in kilograms (KG)
        ///Testing Underweight
        /// </summary>
        public void TestMetricUnderWeight()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.metre = 1.88;
            bmi.Kilogram = 50;

            //Act Stage
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 14.15;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.IndexBMI, 2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Metric Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Centimetres(CM) and weight in kilograms (KG)
        ///Testing Normal Range weight
        /// </summary>
        public void TestMetricNormal()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.metre = 1.88;
            bmi.Kilogram = 90;

            //Act Stage
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 25.46;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.IndexBMI, 2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Metric Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Centimetres(CM) and weight in kilograms (KG)
        ///Testing Obese Class 1
        /// </summary>
        public void TestMetricObeseI()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.metre = 1.88;
            bmi.Kilogram = 130;

            //Act Stage
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 36.78;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.IndexBMI, 2));
        }


        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Metric Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Centimetres(CM) and weight in kilograms (KG)
        ///Testing Obese Class 2
        /// </summary>
        public void TestMetricObeseII()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.metre = 1.88;
            bmi.Kilogram = 140;

            //Act Stage
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 39.61;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.IndexBMI, 2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Metric Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Centimetres(CM) and weight in kilograms (KG)
        ///Testing Obese Class 3
        /// </summary>
        public void TestMetricObeseIII()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.metre = 1.88;
            bmi.Kilogram = 150;

            //Act Stage
            bmi.CalculateMetricBMI();
            double expectedMetricBMI = 42.44;

            //Assert Stage
            Assert.AreEqual(expectedMetricBMI, Math.Round(bmi.IndexBMI, 2));
        }


        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Imperial Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Feet and Inches and weight in Stones and Pounds
        ///Testing Underweight
        /// </summary>
        public void TestImperialUnderweight()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inch = 2;
            bmi.Stone = 10;
            bmi.Pound = 3;


            //Act Stage
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 18.36;

            //Assert Stage
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.IndexBMI, 2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Imperial Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Feet and Inches and weight in Stones and Pounds
        ///Testing Normal Weight Range
        /// </summary>
        public void TestImperialNormal()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inch = 2;
            bmi.Stone = 11;
            bmi.Pound = 6;


            //Act Stage
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 20.54;

            //Assert Stage
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.IndexBMI, 2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Imperial Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Feet and Inches and weight in Stones and Pounds
        ///Testing Overweight
        /// </summary>
        public void TestImperialOverweight()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inch = 2;
            bmi.Stone = 14;
            bmi.Pound = 2;


            //Act Stage
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 25.42;

            //Assert Stage
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.IndexBMI, 2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Imperial Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Feet and Inches and weight in Stones and Pounds
        ///Testing Obese Class I
        /// </summary>
        public void TestImperialObeseI()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inch = 2;
            bmi.Stone = 18;
            bmi.Pound = 0;


            //Act Stage
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 32.35;

            //Assert Stage
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.IndexBMI, 2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Imperial Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Feet and Inches and weight in Stones and Pounds
        ///Testing Obese Class II
        /// </summary>
        public void TestImperialObeseII()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inch = 2;
            bmi.Stone = 20;
            bmi.Pound = 4;


            //Act Stage
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 36.46;

            //Assert Stage
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.IndexBMI, 2));
        }

        [TestMethod]

        ///<summary>
        ///Testing code for calculating on Imperial Units
        ///The Body Mas Index (BMI) taking Height in 
        ///Feet and Inches and weight in Stones and Pounds
        ///Testing Obese Class III
        /// </summary>
        public void TestImperialObeseIII()
        {
            //Arrange stage
            BMI bmi = new BMI();
            bmi.Feet = 6;
            bmi.Inch = 2;
            bmi.Stone = 22;
            bmi.Pound = 11;


            //Act Stage
            bmi.CalculateImperialBMI();
            double expectedImperialBMI = 40.95;

            //Assert Stage
            Assert.AreEqual(expectedImperialBMI, Math.Round(bmi.IndexBMI, 2));
        }

    }
}
