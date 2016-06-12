using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.Entities
{
    public class Square : BaseEntity
    {
        private string _name;
        private double _side;

        public string Name
        {
            get { return _name; }
            set { SetAndRaiseIfChanged(ref _name, value); }
        }

        public double Side
        {
            get { return _side; }
            set { SetAndRaiseIfChanged(ref _side, value); }
        }
    }
}