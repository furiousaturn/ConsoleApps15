using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_16___Sample_Program_1
{
    class Circle : Shape
    {

        public Circle()
        {
            this.type = "Circle";
        }

        //Area of a circle is Pi x R squared
        public override float CalcuateArea()
        {
            return (float) Math.Pow(Math.PI * this.getRadius(),2);
        }

        //Circumference of a circle is 2 x pi x R 
        public override float CalculateCircumference()
        {
            return  2 * (float) Math.PI * this.getRadius();
        }
    }
}
