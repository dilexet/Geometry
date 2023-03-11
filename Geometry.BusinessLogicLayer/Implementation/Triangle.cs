using System;
using Geometry.BusinessLogicLayer.CustomException;

namespace Geometry.BusinessLogicLayer.Implementation
{
    public class Triangle : Figure
    {
        private Lazy<bool> _isRightTriangle;
        private double _sideA;
        private double _sideB;
        private double _sideC;

        /// <summary>
        /// Whether the triangle is right-angled
        /// </summary>
        public bool IsRightTriangle
        {
            get => _isRightTriangle.Value;
            private set => _isRightTriangle = new Lazy<bool>(value);
        }

        /// <summary>
        /// Triangle side A
        /// </summary>
        /// <exception cref="NegativeNumberException">If the side A of the triangle is negative</exception>
        public double SideA
        {
            get => _sideA;
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Side A cannot be negative");
                }

                _sideA = value;
                ChangeProperties();
            }
        }

        /// <summary>
        /// Triangle side B
        /// </summary>
        /// <exception cref="NegativeNumberException">If the side B of the triangle is negative</exception>
        public double SideB
        {
            get => _sideB;
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Side B cannot be negative");
                }

                _sideB = value;
                ChangeProperties();
            }
        }

        /// <summary>
        /// Triangle side C
        /// </summary>
        /// <exception cref="NegativeNumberException">If the side C of the triangle is negative</exception>
        public double SideC
        {
            get => _sideC;
            set
            {
                if (value < 0)
                {
                    throw new NegativeNumberException("Side C cannot be negative");
                }

                _sideC = value;
                ChangeProperties();
            }
        }

        /// <summary>
        /// Triangle
        /// </summary>
        /// <param name="sideA">Side A</param>
        /// <param name="sideB">Side B</param>
        /// <param name="sideC">Side C</param>
        /// <exception cref="NegativeNumberException">If the side of the triangle is negative</exception>
        /// <exception cref="TriangleNotExistException">If one side of a triangle is greater than the sum of the other two sides</exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                throw new NegativeNumberException("Side cannot be negative");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;

            if (!CheckIsTriangleExist())
            {
                throw new TriangleNotExistException(
                    "One side of a triangle is greater than the sum of the other two sides. Such a triangle cannot exist.");
            }


            _isRightTriangle = new Lazy<bool>(CheckIsRightTriangle);
        }


        /// <summary>
        /// Checking if is a right triangle
        /// </summary>
        /// <returns></returns>
        private bool CheckIsRightTriangle()
        {
            double[] sides =
            {
                SideA, SideB, SideC
            };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2) == 0;
        }

        /// <summary>
        /// Calculate the area of the triangle
        /// </summary>
        protected override double CalculateArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        /// <summary>
        /// Display info about triangle
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"\nThe area of a triangle with sides {SideA}, {SideB}, {SideC} is {Square}\n");
            if (IsRightTriangle)
            {
                Console.WriteLine($"The triangle is right\n");
            }
            else
            {
                Console.WriteLine($"The triangle is not right\n");
            }
        }

        /// <summary>
        /// Checking if a triangle can exist
        /// </summary>
        /// <returns></returns>
        private bool CheckIsTriangleExist()
        {
            double[] sides =
            {
                SideA, SideB, SideC
            };
            Array.Sort(sides);
            return sides[0] + sides[1] >= sides[2];
        }

        private void ChangeProperties()
        {
            if (!CheckIsTriangleExist())
            {
                throw new TriangleNotExistException(
                    "One side of a triangle is greater than the sum of the other two sides. Such a triangle cannot exist.");
            }

            Square = CalculateArea();
            IsRightTriangle = CheckIsRightTriangle();
        }
    }
}