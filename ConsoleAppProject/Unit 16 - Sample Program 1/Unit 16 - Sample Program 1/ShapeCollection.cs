using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_16___Sample_Program_1
{
    class ShapeCollection
    {

        List<Shape> shapeList = new List<Shape>();

        public void AddShape(Shape shapeToAdd)
        {
            shapeList.Add(shapeToAdd);
        }

        public float GetShapesTotalArea()
        {
            float totalArea = 0;

            for(int i = 0; i < shapeList.Count; i++)
            {
                totalArea += shapeList[i].CalcuateArea();
            }
            return totalArea;
        }

        public List<Shape> GetShapesList()
        {
            return this.shapeList;
        }
    }
}
