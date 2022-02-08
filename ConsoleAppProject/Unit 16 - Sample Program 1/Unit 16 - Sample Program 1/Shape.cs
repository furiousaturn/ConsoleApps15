using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_16___Sample_Program_1
{
    class Shape
    {

        private float height;
        private float width;
        protected string type;

        private float radius;

        public virtual float CalcuateArea()
        {
            return 0;
        }

        public virtual float CalculateCircumference()
        {
            return 0;
        }

        public void setHeight(float newHeight)
        {
            this.height = newHeight;
        }

        public void setWidth(float newWidth)
        {
            this.width = newWidth;
        }
        public void setRadius(float radius)
        {
            this.radius = radius;
        }

        public float getHeight()
        {
            return this.height;
        }
        public float getWidth()
        {
            return this.width;
        }
        public float getRadius()
        {
            return this.radius;
        }
        public string getType()
        {
            return this.type;
        }
    }
}
