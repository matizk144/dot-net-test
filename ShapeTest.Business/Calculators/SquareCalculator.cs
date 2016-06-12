using System.Linq;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Interfaces;

namespace ShapeTest.Business.Calculators
{
    public class SquareCalculator
    {
        private readonly ISquaresRepository _repository;

        public SquareCalculator(ISquaresRepository repository)
        {
            _repository = repository;
        }

        public double GetSumCalculatedAreas()
        {
            return _repository.GetAll().Sum(square => GetSquareArea(square));
        }

        private double GetSquareArea(Square square)
        {
            return square.Side*square.Side;
        }
    }
}