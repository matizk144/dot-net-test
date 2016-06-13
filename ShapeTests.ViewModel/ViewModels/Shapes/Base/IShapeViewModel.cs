using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTests.ViewModel.ViewModels.Shapes.Base
{
    public interface IShapeViewModel
    {
        string Name { get; }
        void UpdateViewModel();
        BaseShape BaseShape { get; }
    }
}