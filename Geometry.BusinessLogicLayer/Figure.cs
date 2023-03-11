using System;

namespace Geometry.BusinessLogicLayer
{
    public abstract class Figure
    {
        private Lazy<double> _square;

        /// <summary>
        /// Figure area
        /// </summary>
        public double Square
        {
            get => _square.Value;
            protected set => _square = new Lazy<double>(value);
        }

        protected Figure()
        {
            _square = new Lazy<double>(CalculateArea);
        }

        /// <summary>
        /// Calculate the area of a figure
        /// </summary>
        protected abstract double CalculateArea();
    }
}