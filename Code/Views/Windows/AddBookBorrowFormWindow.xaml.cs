using QLTV_Nhom13.ViewModels.Windows;
using System.Windows;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Windows
{
    public partial class AddBookBorrowFormWindow 
    {
        // Instantiate the view model
        private readonly AddBookBorrowFormViewModel _viewModel;

        public AddBookBorrowFormWindow()
        {
            InitializeComponent();

            // Initialize the view model
            _viewModel = new AddBookBorrowFormViewModel();

            // Set the DataContext to the view model
            DataContext = _viewModel;
        }
    }
}
