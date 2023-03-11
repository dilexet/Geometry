using System;
using Geometry.BusinessLogicLayer;
using Geometry.BusinessLogicLayer.Implementation;

namespace Geometry.PresentationLayer
{
    class Program
    {
        static void Main()
        {
            var type = Console.ReadLine();
            Figure figure = null;
            if (type != null)
            {
                switch (type.ToLower())
                {
                    case "circle":
                        Console.WriteLine("Enter radius:");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            figure = new Circle(radius);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "triangle":
                        Console.WriteLine("Enter sides a, b, c:");
                        double sideA = Convert.ToDouble(Console.ReadLine());
                        double sideB = Convert.ToDouble(Console.ReadLine());
                        double sideC = Convert.ToDouble(Console.ReadLine());
                        try
                        {
                            figure = new Triangle(sideA, sideB, sideC);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    default:
                        Console.WriteLine("Figure is not exist");
                        break;
                }
            }

            figure?.DisplayInfo();
        }
    }
}