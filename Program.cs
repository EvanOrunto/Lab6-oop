using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Lab6
{
    abstract class Shape
    {
        public double width;
        public double height;

        public abstract double CalculateSurface();
    }

    class Triangle : Shape
    {
        public Triangle(double Width, double Height)
        {
           width = Width;
           height = Height;
        }
        public override double CalculateSurface()
        {
            double area;
            area = width * height;
            return area;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(double Width, double Height)
        {
            width = Width;
            height = Height;
        }
        public override double CalculateSurface()
        {
            double area;
            area = width * height / 2;
            return area;
        }
    }

    class Circle : Shape
    {
        private const double pi = 3.147;
        public Circle(double radius)
        {
            width = radius;
            height = radius;
        }
        public override double CalculateSurface()
        {
            double area;
            area = pi * width * width;
            return area;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double result;

            Shape[] shapes = new Shape[3];
            shapes[0] = new Triangle(12.8, 10.5);
            shapes[1] = new Rectangle(2, 6);
            shapes[2] = new Circle(6.5);



            foreach(Shape s in shapes)
            {
                 result = s.CalculateSurface();
                 Console.WriteLine("The surface area is given by " +  result);
            }
            
        }
    }
}
