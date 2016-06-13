using System.Linq;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Interfaces;

namespace ShapeTest.Business.Calculators
{
    public class RectangleCalculator
    {
        private readonly IRectanglesRepository _repository;

        public RectangleCalculator(IRectanglesRepository repository)
        {
            _repository = repository;
        }

        public double GetSumCalculatedAreas()
        {
            return _repository.GetAll().Sum(rectangle => GetRectangleArea(rectangle));
        }

        private double GetRectangleArea(Rectangle rectangle)
        {
            return rectangle.Length * rectangle.Width;
        }
    }
}