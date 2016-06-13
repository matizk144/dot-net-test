using System.ComponentModel;
using ShapeTest.DataAccess.Entities;
using ShapeTests.ViewModel.ViewModels.Shapes.Base;

namespace ShapeTests.ViewModel.ViewModels.Shapes
{
    public class RectangleViewModel : BaseShapeViewModel<Rectangle>
    {
        private double _length;
        private double _width;

        public double Length
        {
            get { return _length; }
            set { SetAndRaisePropertyChanged(ref _length, value); }
        }

        public double Width
        {
            get { return _width; }
            set { SetAndRaisePropertyChanged(ref _width, value); }
        }

        public override void RaisePropertyChanged(PropertyChangedEventArgs changedArgs)
        {
            base.RaisePropertyChanged(changedArgs);
            if (changedArgs.PropertyName == nameof(Length))
            {
                Shape.Length = Length;
            }
            else if (changedArgs.PropertyName == nameof(Width))
            {
                Shape.Width = Width;
            }
        }

        protected override void UpdateViewModel()
        {
            base.UpdateViewModel();
            Length = Shape.Length;
            Width = Shape.Width;
        }
    }
}