using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MvvmCross.Core.ViewModels;
using ShapeTest.Business.Services;
using ShapeTest.DataAccess.Entities;
using ShapeTest.DataAccess.Entities.Base;
using ShapeTest.DataAccess.EventArgs.Base;
using ShapeTest.DataAccess.Interfaces;
using ShapeTests.ViewModel.ViewModels;
using ShapeTests.ViewModel.ViewModels.Shapes.Base;

namespace ShapeTests.ViewModel
{
    public class ShapesViewModel : ViewModels.ViewModel
    {
        private readonly IComputeAreaService _computeAreaService;
        private readonly ISubmissionService _submissionService;
        private readonly IShapeRemover _shapeRemover;

        private ObservableCollection<IShapeViewModel> _shapeViewModels;
    
        private IShapeViewModel _selectedShapeViewModel;

        private double _totalArea;

        private MvxCommand _addShapeCommand;
        private MvxCommand _removeShapeCommand;
        private MvxCommand _computeAreaCommand;
        private MvxCommand _submitAreaCommand;
        private readonly IRepositories _repositories;

        public ShapesViewModel(IRepositories repositories, 
                               IComputeAreaService computeAreaService,
                               ISubmissionService submissionService,
                               IShapeRemover shapeRemover)
        {
            _repositories = repositories;
            _computeAreaService = computeAreaService;
            _submissionService = submissionService;
            _shapeRemover = shapeRemover;

            _shapeViewModels = new ObservableCollection<IShapeViewModel>();

            AddShapeCommand = new MvxCommand(AddShape);
            RemoveShapeCommand = new MvxCommand(RemoveSelectedShape);
            ComputeAreaCommand = new MvxCommand(ComputeTotalArea);
            SubmitAreaCommand = new MvxCommand(SubmitArea);
        }

        public ObservableCollection<IShapeViewModel> ShapeViewModels
        {
            get { return _shapeViewModels; }
            set { SetAndRaisePropertyChanged(ref _shapeViewModels, value); }
        }

        public IShapeViewModel SelectedShapeViewModel
        {
            get { return _selectedShapeViewModel; }
            set { SetAndRaisePropertyChanged(ref _selectedShapeViewModel, value); }
        }

        public double TotalArea
        {
            get { return _totalArea; }
            set { SetAndRaisePropertyChanged(ref _totalArea, value); }
        }

        public MvxCommand AddShapeCommand
        {
            get { return _addShapeCommand; }
            set { SetAndRaisePropertyChanged(ref _addShapeCommand, value);}
        }

        public MvxCommand RemoveShapeCommand
        {
            get { return _removeShapeCommand; }
            set { SetAndRaisePropertyChanged(ref _removeShapeCommand, value); }
        }

        public MvxCommand ComputeAreaCommand
        {
            get { return _computeAreaCommand; }
            set { SetAndRaisePropertyChanged(ref _computeAreaCommand, value); }
        }

        public MvxCommand SubmitAreaCommand
        {
            get { return _submitAreaCommand; }
            set { SetAndRaisePropertyChanged(ref _submitAreaCommand, value); }
        }

        public override void Start()
        {
            List<Triangle> triangles = _repositories.Triangles.GetAll();
            foreach (Triangle triangle in triangles)
            {
                AddShape(triangle);
            }

            SelectedShapeViewModel = ShapeViewModels.FirstOrDefault();

            _repositories.ShapeAdded += OnShapeAdded;
        }

        private void AddShape()
        {
            ShowViewModel<AddShapeViewModel>();
        }

        public void OnShapeAdded(object sender, BaseShapeEventArgs args)
        {
            AddShape(args.Entity);
        }

        private void AddShape(BaseShape shape)
        {
            var shapeViewModel = ShapesViewModelCreator.CreateViewModel(shape);
            ShapeViewModels.Add(shapeViewModel);
        }

        private void RemoveSelectedShape()
        {
            if (SelectedShapeViewModel != null)
            {
                var viewModelToDelete = SelectedShapeViewModel;
                SelectedShapeViewModel = null;

                _shapeRemover.RemoveShape(viewModelToDelete.BaseShape);
                ShapeViewModels.Remove(viewModelToDelete);
            }
        }

        public void ComputeTotalArea()
        {
            TotalArea = _computeAreaService.ComputeTotalArea();
        }

        public void SubmitArea()
        {
            _submissionService.SubmitTotalArea(TotalArea);
        }

        private ObservableCollection<TriangleListItemViewModel> CreateListViewModelsFromTriangeList(List<Triangle> triangles)
        {
            ObservableCollection<TriangleListItemViewModel> viewModels = new ObservableCollection<TriangleListItemViewModel>();
            foreach (var triangle in triangles)
            {
                TriangleListItemViewModel viewModel = new TriangleListItemViewModel { Triangle = triangle };
                viewModels.Add(viewModel);
            }
            return viewModels;
        }
    }
}
