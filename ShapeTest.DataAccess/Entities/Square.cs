using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.Entities
{
    public class Square : BaseShape
    {
        private double _side;

        public double Side
        {
            get { return _side; }
            set { SetAndRaiseIfChanged(ref _side, value); }
        }
    }
}