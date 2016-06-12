﻿using ShapeTest.DataAccess.Entities.Base;

namespace ShapeTest.DataAccess.Entities
{
    public class Circle : BaseEntity
    {
        private string _name;
        private double _radius;

        public string Name
        {
            get { return _name; }
            set { SetAndRaiseIfChanged(ref _name, value); }
        }

        public double Radius
        {
            get { return _radius; }
            set { SetAndRaiseIfChanged(ref _radius, value); }
        }
    }
}