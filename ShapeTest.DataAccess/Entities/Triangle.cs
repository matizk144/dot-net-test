using System;
using System.Collections.Generic;
using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.Entities
{
    public class Triangle : BaseShape
    {
        private double _base;
        private double _height;

        public double Base
        {
            get { return _base; }
            set { SetAndRaiseIfChanged(ref _base, value); }
        }

        public double Height
        {
            get { return _height;}
            set { SetAndRaiseIfChanged(ref _height, value); }
        }
    }
}
