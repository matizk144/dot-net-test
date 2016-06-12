using ShapeTest.DataAccess.Interfaces;
using ShapeTest.DataAccess.Repositories;

namespace ShapeTest.Business.Services
{
    using System.Linq;

    public class ComputeAreaService : IComputeAreaService
    {
        private readonly ITrianglesRepository _TrianglesRepo;

        public ComputeAreaService(ITrianglesRepository trianglesRepo)
        {
            _TrianglesRepo = trianglesRepo;
        }

        public double ComputeTotalArea()
        {
            var triangles = _TrianglesRepo.GetAll();

            return triangles.Sum(triangle => 0.5 * triangle.Base * triangle.Height);
        }
    }
}
