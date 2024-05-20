using QLTV_Nhom13.ViewModels.Windows;
using System.ComponentModel;
using System.Windows.Input;
using Wpf.Ui;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Windows
{
    /// <summary>
    /// Interaction logic for ReaderInfoPage.xaml
    /// </summary>
    public partial class ReaderInfoWindow 
    {
        private readonly ReaderInfoViewModel _viewModel;

        public ReaderInfoWindow()
        {
            InitializeComponent();

            _viewModel = new ReaderInfoViewModel();

            DataContext = _viewModel;
        }
    }
}
