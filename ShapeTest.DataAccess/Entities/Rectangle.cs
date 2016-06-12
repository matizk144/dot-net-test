using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.Entities
{
    public class Rectangle : BaseEntity
    {
        private string _name;
        private double _length;
        private double _weight;

        public string Name
        {
            get { return _name; }
            set { SetAndRaiseIfChanged(ref _name, value); }
        }

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