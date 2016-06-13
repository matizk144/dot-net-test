using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using ShapeTest.DataAccess.Interfaces;
using ShapeTest.DataAccess.Repositories;

namespace ShapeTests.ViewModel
{
    using ShapeTest.Business.Services;

    public class ShapeApplication : MvxApplication
    {
        public ShapeApplication()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<ShapesViewModel>());
        }

        public override void Initialize()
        {
            RepositoryInitializer.InitRepository();
            Mvx.RegisterType<IComputeAreaService, ComputeAreaService>();
            Mvx.RegisterType<IShapesCreator, ShapesCreator>();
            Mvx.RegisterType<IShapeRemover, ShapeRemover>();
            Mvx.RegisterType<ISubmissionService, SubmissionService>();
        }
    }
}
