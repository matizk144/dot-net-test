using System;
using System.ComponentModel;
using ShapeTest.DataAccess.Entities;
using ShapeTests.ViewModel.ViewModels.Shapes.Base;

namespace ShapeTests.ViewModel.ViewModels.Shapes
{

    public class TriangleViewModel : BaseShapeViewModel<Triangle>
    {
        private double _base;
        private double _height;

        public double Base
        {
            get { return _base; }
            set { SetAndRaisePropertyChanged(ref _base, value); }
        }

        public double Height
        {
            get { return _height; }
            set { SetAndRaisePropertyChanged(ref _height, value); }
        }

        public override void RaisePropertyChanged(PropertyChangedEventArgs changedArgs)
        {
            base.RaisePropertyChanged(changedArgs);
            if (changedArgs.PropertyName == nameof(Base))
            {
                Shape.Base = Base;
            }
            else if (changedArgs.PropertyName == nameof(Height))
            {
                Shape.Height = Height;
            }
        }

        protected override void UpdateViewModel()
        {
            base.UpdateViewModel();
            Base = Shape.Base;
            Height = Shape.Height;
        }
    }
}
