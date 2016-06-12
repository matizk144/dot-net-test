using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ShapeTest.Business.Services;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Interfaces;
using ShapeTest.DataAccess.Repositories;

namespace ShapeTest.Business.UnitTests
{
    [TestClass]
    public class ComputeAreaServiceTests
    {
        private Mock<ITrianglesRepository> _triangleRepository;
        private Mock<IRectanglesRepository> _rectangleRepository;
        private Mock<ICirclesRepository> _circleRepository;
        private Mock<ISquaresRepository> _squareRepository;
        private IRepositories _repositories;
        private const double ExpectedPrecision = 0.001;
      
        [TestInitialize]
        public void Setup()
        {
            var mockRepository = new MockRepository(MockBehavior.Strict);
            _triangleRepository = mockRepository.Create<ITrianglesRepository>();
            _rectangleRepository = mockRepository.Create<IRectanglesRepository>();
            _circleRepository = mockRepository.Create<ICirclesRepository>();
            _squareRepository = mockRepository.Create<ISquaresRepository>();
            _repositories = new Repositories(_triangleRepository.Object, _squareRepository.Object, _rectangleRepository.Object, _circleRepository.Object);
        }

        [TestMethod]
        public void ShouldComputeTotalArea()
        {
            // Arrange
            const double expectedResult = 188.5398;

            List<Triangle> triangles = GetSampleTriangles();
            List<Circle> circles = GetSampleCircles();
            List<Rectangle> rectangles = GetSampleRectangles();
            List<Square> squares = GetSampleSquares();

            _triangleRepository.Setup(m => m.GetAll()).Returns(triangles);
            _rectangleRepository.Setup(m => m.GetAll()).Returns(rectangles);
            _circleRepository.Setup(m => m.GetAll()).Returns(circles);
            _squareRepository.Setup(m => m.GetAll()).Returns(squares);

            ComputeAreaService computeAreaService = new ComputeAreaService(_repositories);

            // Act
            var result = computeAreaService.ComputeTotalArea();

            // Assert
            result.Should().BeApproximately(expectedResult, ExpectedPrecision);
        }

        private static List<Square> GetSampleSquares()
        {
            return new List<Square>
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
        }

        private static List<Rectangle> GetSampleRectangles()
        {
            return new List<Rectangle>
            {
                new Rectangle()
                {
                    Length = 3,
                    Weight = 7
                },
                new Rectangle
                {
                    Length = 4,
                    Weight = 9
                }
            };
        }

        private static List<Circle> GetSampleCircles()
        {
            return new List<Circle>
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
        }

        private static List<Triangle> GetSampleTriangles()
        {
            return new List<Triangle>
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
        }
    }
}
