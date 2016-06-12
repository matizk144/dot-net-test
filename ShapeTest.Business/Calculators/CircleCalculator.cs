using System;
using System.Linq;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Interfaces;

namespace ShapeTest.Business.Calculators
{
    public class CircleCalculator
    {
        private readonly ICirclesRepository _repository;

        public CircleCalculator(ICirclesRepository repository)
        {
            _repository = repository;
        }

        public double GetSumCalculatedAreas()
        {
            return _repository.GetAll().Sum(rectangle => GetCircleAree(rectangle));
        }

        private double GetCircleAree(Circle circle)
        {
            return circle.Radius*circle.Radius*Math.PI;
        }
    }
}