using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Square : IShape
    {
        public double Side { get; set; }

        public double Area()
        {
             return Side * Side;
        }

        public void Initialize()
        {
            Console.Write("What is the length of one side? ");
            var input = Console.ReadLine();
            Side = Double.Parse(input);
        }

        public double Perimeter()
        {
            return Side * 4; 
        }

        public override string ToString()
        {
            return $"square ({Side}x{Side})";
        }
    }
}
