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
    public class RectangleCalculatorTests
    {
        private Mock<IRectanglesRepository> _rectangleRepository;
        private const double ExpectedPrecision = 0.001;

        [TestInitialize]
        public void Setup()
        {
            var mockRepository = new MockRepository(MockBehavior.Strict);
            _rectangleRepository = mockRepository.Create<IRectanglesRepository>();
        }

        [TestMethod]
        public void CalculateTotalRectangleAreas()
        {
            // Arrange
            const double expectedResult = 57;

            List<Rectangle> rectangles = new List<Rectangle>
            {
                new Rectangle()
                    {
                        Length = 3,
                        Width = 7
                    },
                new Rectangle
                    {
                        Length = 4,
                        Width = 9
                    }
            };

            _rectangleRepository.Setup(m => m.GetAll()).Returns(rectangles);

            RectangleCalculator calculator = new RectangleCalculator(_rectangleRepository.Object);

            // Act
            var result = calculator.GetSumCalculatedAreas();

            // Assert
            result.Should().BeApproximately(expectedResult, ExpectedPrecision);
        }
    }
}