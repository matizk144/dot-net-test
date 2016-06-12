using MvvmCross.Platform;
using ShapeTest.DataAccess.Interfaces;

namespace ShapeTest.DataAccess.Repositories
{
    public class RepositoryInitializer
    {
        public static void InitRepository()
        {
            Mvx.LazyConstructAndRegisterSingleton<ITrianglesRepository>(() => new TrianglesRepository());
            Mvx.LazyConstructAndRegisterSingleton<ISquaresRepository>(() => new SquaresRepository());
            Mvx.LazyConstructAndRegisterSingleton<IRectanglesRepository>(() => new RectanglesRepository());
            Mvx.LazyConstructAndRegisterSingleton<ICirclesRepository>(() => new CirclesRepository());

            Mvx.LazyConstructAndRegisterSingleton<IRepositories, Repositories>();
        }
    }
}