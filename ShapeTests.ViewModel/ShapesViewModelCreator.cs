using System;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Entities.Base;
using ShapeTests.ViewModel.ViewModels.Shapes;
using ShapeTests.ViewModel.ViewModels.Shapes.Base;

namespace ShapeTests.ViewModel
{
    public class ShapesViewModelCreator
    {
        public static IShapeViewModel CreateViewModel(BaseShape shape)
        {
            IShapeViewModel viewModel;
            if (shape is Triangle)
            {
                viewModel =  CreateTriangleViewModel(shape as Triangle);
            }
            else if (shape is Square)
            {
                viewModel = CreateSquareViewModel(shape as Square);
            }
            else if (shape is Rectangle)
            {
                viewModel = CreateRectangleViewModel(shape as Rectangle);
            }
            else if (shape is Circle)
            {
                viewModel = CreateCircleViewModel(shape as Circle);
            }
            else
            {
                throw new InvalidOperationException("Bad shape");
            }

            viewModel.UpdateViewModel();

            return viewModel;
        }

        private static IShapeViewModel CreateCircleViewModel(Circle circle)
        {
            return new CircleViewModel(circle);
        }

        private static IShapeViewModel CreateRectangleViewModel(Rectangle rectangle)
        {
            return new RectangleViewModel(rectangle);
        }

        private static IShapeViewModel CreateSquareViewModel(Square square)
        {
            return new SquareViewModel(square);
        }

        private static IShapeViewModel CreateTriangleViewModel(Triangle triangle)
        {
            return new TriangleViewModel(triangle);
        }
    }
}