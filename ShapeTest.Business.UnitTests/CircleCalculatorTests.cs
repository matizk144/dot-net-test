using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ShapeTest.Business.Calculators;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Interfaces;

namespace ShapeTest.Business.UnitTests
{
    [TestClass]
    public class CircleCalculatorTests
    {
        private Mock<ICirclesRepository> _circleRepository;
        private const double ExpectedPrecision = 0.001;

        [TestInitialize]
        public void Setup()
        {
            var mockRepository = new MockRepository(MockBehavior.Strict);
            _circleRepository = mockRepository.Create<ICirclesRepository>();
        }

        [TestMethod]
        public void CalculateTotalCircleAreas()
        {
            // Arrange
            const double expectedResult = 78.539;

            List<Circle> circles = new List<Circle>
            {
                new Circle()
                    {
                        Radius = 3
                    },
                new Circle
                    {
                        Radius = 4
                    }
            };

            _circleRepository.Setup(m => m.GetAll()).Returns(circles);

            CircleCalculator calculator = new CircleCalculator(_circleRepository.Object);

            // Act
            var result = calculator.GetSumCalculatedAreas();

            // Assert
            result.Should().BeApproximately(expectedResult, ExpectedPrecision);
        }
    }
}