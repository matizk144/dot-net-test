using System;
using System.Collections.Generic;
using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.Entities
{
    public class Triangle : BaseEntity
    {
        private string _name;
        private double _base;
        private double _height;

        public string Name
        {
            get { return _name; }
            set { SetAndRaiseIfChanged(ref _name, value); }
        }

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
