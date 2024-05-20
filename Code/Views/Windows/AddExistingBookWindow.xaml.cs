using QLTV_Nhom13.ViewModels.Windows;
using System.ComponentModel;
using System.Windows;
using Wpf.Ui;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Windows
{
    /// <summary>
    /// Interaction logic for AddExistingBookWindow.xaml
    /// </summary>
    public partial class AddExistingBookWindow
    {
        private readonly AddExistingBookViewModel _viewModel;

        public AddExistingBookWindow()
        {
            InitializeComponent();

            _viewModel = new AddExistingBookViewModel();

            DataContext = _viewModel;
        }

    }
}
