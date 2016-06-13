using System;
using System.Collections.Generic;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.EventArgs;
using ShapeTest.DataAccess.Interfaces;
using ShapeTest.DataAccess.Repositories.BaseRepository;

namespace ShapeTest.DataAccess.Repositories
{
    public class TrianglesRepository : BaseRepository<Triangle>, ITrianglesRepository
    {

        public TrianglesRepository()
        {
            InitRepository();
        }

        private void InitRepository()
        {
            Entities = new List<Triangle>
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

        public event EventHandler<TriangleEventArgs> TriangleAdded;
        public event EventHandler<TriangleEventArgs> TriangleRemoved;

        protected override void OnEntityRemoved(Triangle entity)
        {
            TriangleRemoved?.Invoke(this, new TriangleEventArgs(entity));
        }

        protected override void OnEntityAdded(Triangle entity)
        {
            TriangleAdded?.Invoke(this, new TriangleEventArgs(entity));
        }
    }
}
