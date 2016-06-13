using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.Entities
{
    public class Rectangle : BaseShape
    {
        private double _length;
        private double _width;

        public double Length
        {
            get { return _length; }
            set { SetAndRaiseIfChanged(ref _length, value); }
        }

        public double Width
        {
            get { return _width; }
            set { SetAndRaiseIfChanged(ref _width, value); }
        }
    }
}