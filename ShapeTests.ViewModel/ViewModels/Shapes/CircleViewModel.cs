using System.ComponentModel;
using ShapeTest.DataAccess.Entities;
using ShapeTests.ViewModel.ViewModels.Shapes.Base;

namespace ShapeTests.ViewModel.ViewModels.Shapes
{
    public class CircleViewModel : BaseShapeViewModel<Circle>
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { SetAndRaisePropertyChanged(ref _radius, value); }
        }

        public override void RaisePropertyChanged(PropertyChangedEventArgs changedArgs)
        {
            base.RaisePropertyChanged(changedArgs);
            if (changedArgs.PropertyName == nameof(Radius))
            {
                Shape.Radius = Radius;
            }
        }

        public override void UpdateViewModel()
        {
            base.UpdateViewModel();
            Radius = Shape.Radius;
        }

        public CircleViewModel(Circle shape) : base(shape)
        {
        }
    }
}