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
    public class SquareCalculatorTests
    {
        private Mock<ISquaresRepository> _squareRepository;
        private const double ExpectedPrecision = 0.001;

        [TestInitialize]
        public void Setup()
        {
            var mockRepository = new MockRepository(MockBehavior.Strict);
            _squareRepository = mockRepository.Create<ISquaresRepository>();
        }

        [TestMethod]
        public void CalculateTotalSquareAreas()
        {
            // Arrange
            const double expectedResult = 40;

            List<Square> squares = new List<Square>
            {
                new Square()
                    {
                        Side = 2
                    },
                new Square
                    {
                        Side = 6
                    }
            };

            _squareRepository.Setup(m => m.GetAll()).Returns(squares);

            SquareCalculator calculator = new SquareCalculator(_squareRepository.Object);

            // Act
            var result = calculator.GetSumCalculatedAreas();

            // Assert
            result.Should().BeApproximately(expectedResult, ExpectedPrecision);
        }
    }
}