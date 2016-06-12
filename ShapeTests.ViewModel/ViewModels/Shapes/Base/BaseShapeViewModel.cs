using System;
using System.ComponentModel;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTests.ViewModel.ViewModels.Shapes.Base
{
    public abstract class BaseShapeViewModel<TShape> : ViewModel where TShape : BaseShape
    {
        private string _name;
        private TShape _shape;

        public string Name
        {
            get { return _name; }
            set { SetAndRaisePropertyChanged(ref _name, value); }
        }

        public TShape Shape
        {
            get
            {
                return _shape;
            }
            set
            {
                SetAndUpdateTraingleIfChanged(value);
            }
        }

        public override void RaisePropertyChanged(PropertyChangedEventArgs changedArgs)
        {
            base.RaisePropertyChanged(changedArgs);
            if (changedArgs.PropertyName == nameof(Name))
            {
                Shape.Name = Name;
            }
        }

        private void SetAndUpdateTraingleIfChanged(TShape newShape)
        {
            if (!ReferenceEquals(_shape, newShape))
            {
                if (_shape != null)
                {
                    _shape.EntityChanged -= OnTriangleChanged;
                }

                _shape = newShape;

                if (_shape != null)
                {
                    _shape.EntityChanged += OnTriangleChanged;
                }

                UpdateViewModel();
            }
        }

        private void OnTriangleChanged(object sender, EventArgs args)
        {
            UpdateViewModel();
        }

        protected abstract void UpdateViewModel();
    }
}