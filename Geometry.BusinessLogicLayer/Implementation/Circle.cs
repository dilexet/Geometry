using System;
using Geometry.BusinessLogicLayer.CustomException;

namespace Geometry.BusinessLogicLayer.Implementation
{
    public class Circle : Figure
    {
        private double _radius;

        /// <summary>
        /// Circle radius
        /// </summary>
        /// <exception cref="NegativeNumberException">If the radius of the circle is negative</exception>
        public double Radius
        {
            get => _radius;
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Radius cannot be negative");
                }

                _radius = value;
                Square = CalculateArea();
            }
        }

        /// <summary>
        /// Circle
        /// </summary>
        /// <param name="radius">Circle radius</param>
        /// <exception cref="NegativeNumberException">If the radius of the circle is negative</exception>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new NegativeNumberException("Radius cannot be negative");
            }

            _radius = radius;
        }

        /// <summary>
        /// Calculate the area of the circle
        /// </summary>
        protected override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }


        /// <summary>
        /// Display info about circle
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"\nThe area of a circle with a radius of {Radius} is {Square}\n");
        }
    }
}