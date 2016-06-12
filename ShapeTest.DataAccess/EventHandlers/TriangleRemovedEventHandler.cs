using ShapeTest.DataAccess.EventArgs;
using ShapeTest.DataAccess.Repositories;

namespace ShapeTest.DataAccess.EventHandlers
{
    public delegate void TriangleRemovedEventHandler(object sender, TriangleEventArgs args);
}
