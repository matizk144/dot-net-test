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
    public class TriangleCalculatorTests
    {
        private Mock<ITrianglesRepository> _triangleRepository;
        private const double ExpectedPrecision = 0.001;

        [TestInitialize]
        public void Setup()
        {
            var mockRepository = new MockRepository(MockBehavior.Strict);
            _triangleRepository = mockRepository.Create<ITrianglesRepository>();
        }

        [TestMethod]
        public void CalculateTotalTriangleAreas()
        {
            // Arrange
            const double expectedResult = 13;

            List<Triangle> triangles = new List<Triangle>
            {
                new Triangle
                    {
                        Base = 2,
                        Height = 4
                    },
                new Triangle
                    {
                        Base = 3,
                        Height = 6
                    }
            };

            _triangleRepository.Setup(m => m.GetAll()).Returns(triangles);

            TriangleCalculator calculator = new TriangleCalculator(_triangleRepository.Object);

            // Act
            var result = calculator.GetSumCalculatedAreas();

            // Assert
            result.Should().BeApproximately(expectedResult, ExpectedPrecision);
        }
    }
}