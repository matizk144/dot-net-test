﻿using MvvmCross.Core.ViewModels;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Interfaces;
using ShapeTest.DataAccess.Repositories;

namespace ShapeTests.ViewModel.ViewModels
{
    public class AddTriangleViewModel : ViewModel, IPopupViewModel
    {
        private readonly ITrianglesRepository _TriangleRepo;

        private int _OwnerId;

        private MvxCommand _AddTriangleCommand;
        private MvxCommand _CancelCommand;

        public bool IsModal => true;

        public bool TopMost => true;

        public int OwnerId
        {
            get { return _OwnerId;} 
            set { SetAndRaisePropertyChanged(ref _OwnerId, value); }
        }

        public MvxCommand AddTriangleCommand
        {
            get { return _AddTriangleCommand; }
            set { SetAndRaisePropertyChanged(ref _AddTriangleCommand, value);}
        }

        public MvxCommand CancelCommand
        {
            get { return _CancelCommand; }
            set { SetAndRaisePropertyChanged(ref _CancelCommand, value);}
        }


        public AddTriangleViewModel(ITrianglesRepository triangleRepo)
        {
            _TriangleRepo = triangleRepo;
            AddTriangleCommand = new MvxCommand(AddTriangle);
            CancelCommand = new MvxCommand(Cancel);
        }

        public void AddTriangle()
        {
            Triangle triangle = new Triangle
            {
                Name = "New Triangle"                            
            };

            _TriangleRepo.AddTriangle(triangle);
            Close(this);
        }

        public void Cancel()
        {
            Close(this);
        }
    }
}
