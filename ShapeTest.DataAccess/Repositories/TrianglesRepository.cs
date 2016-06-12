using System.Collections.Generic;
using ShapeTest.DataAccess.Entities;

namespace ShapeTest.DataAccess.Repositories
{
    public class TrianglesRepository : ITrianglesRepository
    {
        private List<Triangle> _triangles; 

        public TrianglesRepository()
        {
            InitRepository();
        }

        private void InitRepository()
        {
            _triangles = new List<Triangle>
            {
                new Triangle
                {
                    Name = "Triangle 1",
                    Base = 12.5,
                    Height = 13
                },
                new Triangle
                {
                    Name = "Triangle 2",
                    Base = 23.4,
                    Height = 14
                },
                new Triangle
                {
                    Name = "Triangle 3",
                    Base = 42,
                    Height = 22
                }
            };
        }

        public event TriangleAddedEventHandler TriangleAdded;

        public List<Triangle> GetTriangles()
        {
            return _triangles;
        }

        public void AddTriangle(Triangle triangle)
        {
            _triangles.Add(triangle);
            OnTriangleAdded(triangle);
        }

        public bool RemoveTriangle(Triangle triangle)
        {
            return _triangles.Remove(triangle);
        }

        protected void OnTriangleAdded(Triangle triangle)
        {
            TriangleAddedEventHandler handler = TriangleAdded;
            handler?.Invoke(this, new TriangleEventArgs(triangle));
        }
    }
}
