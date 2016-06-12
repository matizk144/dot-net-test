using ShapeTest.Business.Calculators;
using ShapeTest.DataAccess.Interfaces;

namespace ShapeTest.Business.Services
{
    public class ComputeAreaService : IComputeAreaService
    {
        private readonly IRepositories _repositories;


        public ComputeAreaService(IRepositories repositories)
        {
            _repositories = repositories;
        }

        public double ComputeTotalArea()
        {
            double totalComputedArea = 0;
            totalComputedArea += new CircleCalculator(_repositories.Circles).GetSumCalculatedAreas();
            totalComputedArea += new RectangleCalculator(_repositories.Rectangles).GetSumCalculatedAreas();
            totalComputedArea += new SquareCalculator(_repositories.Squares).GetSumCalculatedAreas();
            totalComputedArea += new TriangleCalculator(_repositories.Triangles).GetSumCalculatedAreas();

            return totalComputedArea;
        }
    }
}
