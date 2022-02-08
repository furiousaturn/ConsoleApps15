using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_16___Sample_Program_1
{
    class Square : Shape
    {
        public Square(){
            type = "Square";
        }
        public override float CalcuateArea()
        {
            return this.getHeight() * this.getWidth();
        }

        public override float CalculateCircumference()
        {
            return base.CalculateCircumference();
        }
    }
}
