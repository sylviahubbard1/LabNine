using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNineCircle
{
    class Circle
    {

        
        private double radius = 0;
        private static int numberOfCircles;
        public static int getObjectCount()

        {
            return numberOfCircles;

        }

        public Circle(double radius)
        {
            this.radius = radius;
            numberOfCircles++;
        }
        public double getArea()
        {
            double areaOfACircle = Math.PI * radius * radius;
            return areaOfACircle;
        }
        public double getCircumference()
        {
            double circumferenceOfACircle = 2 * Math.PI * radius;
            return circumferenceOfACircle;
        }

        private String getFormatNumber(double valuetoFormat)
        {
            string formatValue = Math.Round(valuetoFormat, 2).ToString();
            return formatValue;
        }
        public string getFormattedCircumference()
        {
            double formattedCircumference = this.getCircumference();
            string valueToBeDisplayed = this.getFormatNumber(formattedCircumference);
            return valueToBeDisplayed;

        }
        public String getformattedArea()
        {
            double formattedArea = this.getArea();
            String valueToBeDisplayed = this.getFormatNumber(formattedArea);
            return valueToBeDisplayed;


        }
    }
}

