using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.Entities
{
    public class Circle : BaseShape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { SetAndRaiseIfChanged(ref _radius, value); }
        }
    }
}