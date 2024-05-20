using QLTV_Nhom13.ViewModels.Windows;
using System.ComponentModel;
using System.Windows.Input;
using Wpf.Ui;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Windows
{
    /// <summary>
    /// Interaction logic for AddReaderWindow.xaml
    /// </summary>
    public partial class AddReaderWindow
    {
        private readonly AddReaderViewModel viewModel;

        public AddReaderWindow()
        {
            InitializeComponent();

            viewModel = new AddReaderViewModel();

            DataContext = viewModel;
        }
    }
}
