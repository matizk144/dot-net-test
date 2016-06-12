using System.Linq;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Interfaces;

namespace ShapeTest.Business.Calculators
{
    public class TriangleCalculator
    {
        private readonly ITrianglesRepository _repository;

        public TriangleCalculator(ITrianglesRepository repository)
        {
            _repository = repository;
        }

        public double GetSumCalculatedAreas()
        {
            return _repository.GetAll().Sum(triangle => GetTriangleArea(triangle));
        }

        private double GetTriangleArea(Triangle triangle)
        {
            return 0.5*triangle.Base*triangle.Height;
        }
    }
}