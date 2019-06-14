using System;
using System.Collections.Generic;
using System.Collections;

namespace AbstractClass
{
    public abstract class figure
    {
        public double width, height, raduis;
        public const float pi = 3.14f;
        public abstract double GetArea();

    }

    public class Rectangle : figure
    {
        Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

        }

        public override double GetArea()
        {
            return (width * height);
        }


    }

    public class Circle : figure
    {
        Circle(double radius)
        {
            this.raduis = raduis;

        }
        public override double GetArea()
        {
            return (raduis * raduis * pi);
        }

    }
}
