using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.Entities
{
    public class Rectangle : BaseShape
    {
        private double _length;
        private double _weight;

        public double Length
        {
            get { return _length; }
            set { SetAndRaiseIfChanged(ref _length, value); }
        }

        public double Weight
        {
            get { return _weight; }
            set { SetAndRaiseIfChanged(ref _weight, value); }
        }
    }
}