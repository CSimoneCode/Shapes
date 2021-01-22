using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class ConsoleProcessor
    {
        public void ProcessInput(string[] args)
        {
            var shapes = new IShape[args.Length];
            var i = 0; 
            foreach(var shapeName in args)
            {
                switch (shapeName)
                {
                    case "square" : shapes[i] = new Square();
                        break;
                    default : PrintHelp();
                        break; 
                }
                i++; 
            }
            foreach(var shape in shapes)
            {
                ProcessShape(shape);
            }
        }

        private void PrintHelp()
        {
            Console.WriteLine("Ya done fucked up");
        }

        private void ProcessShape(IShape shape)
        {
            shape.Initialize();
            Console.WriteLine($"Area of {shape} is {shape.Area()}");
            Console.WriteLine($"Perimeter of {shape} is {shape.Perimeter()}");
        }
    }
}
