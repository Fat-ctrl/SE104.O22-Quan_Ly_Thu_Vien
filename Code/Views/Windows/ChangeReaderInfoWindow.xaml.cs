using QLTV_Nhom13.ViewModels.Windows;
using System.ComponentModel;
using System.Windows.Input;
using Wpf.Ui;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Windows
{
    /// <summary>
    /// Interaction logic for ChangeReaderInfo.xaml
    /// </summary>
    public partial class ChangeReaderInfoWindow
    {
        private readonly ChangeAuthorInfoViewModel viewModel;

        public ChangeReaderInfoWindow()
        {
            InitializeComponent();

            viewModel = new ChangeAuthorInfoViewModel();

            DataContext = viewModel;
        }
    }
}
