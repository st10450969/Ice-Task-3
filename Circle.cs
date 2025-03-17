using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    public class Circle: IShape, ICalculateArea
    {
        public double Radius { get; set; }
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
        public double calculateeArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Radius: " + Radius);
            Console.WriteLine("Area: " + calculateeArea());
        }
    }
    
    }

