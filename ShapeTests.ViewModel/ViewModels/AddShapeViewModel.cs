using MvvmCross.Core.ViewModels;
using ShapeTest.Business.Enums;
using ShapeTest.Business.Services;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Interfaces;

namespace ShapeTests.ViewModel.ViewModels
{
    public class AddShapeViewModel : ViewModel, IPopupViewModel
    {
        private readonly IRepositories _repositories;
        private readonly IShapesCreator _shapesCreator;
        private int _OwnerId;
        private ShapeType _shapeType;

        private MvxCommand _addShapeCommand;
        private MvxCommand _cancelCommand;

        public bool IsModal => true;

        public bool TopMost => true;

        public int OwnerId
        {
            get { return _OwnerId;} 
            set { SetAndRaisePropertyChanged(ref _OwnerId, value); }
        }

        public ShapeType ShapeType
        {
            get { return _shapeType; }
            set { SetAndRaisePropertyChanged(ref _shapeType, value); }
        }

        public MvxCommand AddShapeCommand
        {
            get { return _addShapeCommand; }
            set { SetAndRaisePropertyChanged(ref _addShapeCommand, value);}
        }

        public MvxCommand CancelCommand
        {
            get { return _cancelCommand; }
            set { SetAndRaisePropertyChanged(ref _cancelCommand, value);}
        }


        public AddShapeViewModel(IRepositories repositories, IShapesCreator shapesCreator)
        {
            _repositories = repositories;
            _shapesCreator = shapesCreator;
            AddShapeCommand = new MvxCommand(AddShape);
            CancelCommand = new MvxCommand(Cancel);
        }

        public void AddShape()
        {
            _shapesCreator.AddShape(ShapeType);
            Close(this);
        }

        public void Cancel()
        {
            Close(this);
        }
    }
}
