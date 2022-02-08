using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_16___Sample_Program_1
{
    class Triangle : Shape
    {
        public Triangle()
        {
            this.type = "Triangle";
        }
        public override float CalcuateArea()
        {
            float answer = this.getHeight() * this.getWidth();
            answer /= 2;
            return answer;
        }
        public override float CalculateCircumference()
        {
            return base.CalculateCircumference();
        }
    }
}
