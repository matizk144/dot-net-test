using System.ComponentModel;
using ShapeTest.DataAccess.Entities;
using ShapeTests.ViewModel.ViewModels.Shapes.Base;

namespace ShapeTests.ViewModel.ViewModels.Shapes
{
    public class SquareViewModel : BaseShapeViewModel<Square>
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            set { SetAndRaisePropertyChanged(ref _side, value); }
        }

        public override void RaisePropertyChanged(PropertyChangedEventArgs changedArgs)
        {
            base.RaisePropertyChanged(changedArgs);
            if (changedArgs.PropertyName == nameof(Side))
            {
                Shape.Side = Side;
            }
        }

        protected override void UpdateViewModel()
        {
            base.UpdateViewModel();
            Side = Shape.Side;
        }
    }
}