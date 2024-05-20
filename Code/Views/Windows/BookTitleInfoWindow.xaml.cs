using QLTV_Nhom13.ViewModels.Windows;
using System.ComponentModel;
using System.Windows.Input;
using Wpf.Ui;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;
namespace QLTV_Nhom13.Views.Windows
{
    /// <summary>
    /// Interaction logic for BookTitleInfoWindow.xaml
    /// </summary>
    public partial class BookTitleInfoWindow
    {
        private readonly BookImportInfoViewModel viewModel;

        public BookTitleInfoWindow()
        {
            InitializeComponent();

            viewModel = new BookImportInfoViewModel();

            DataContext = viewModel;  
        }
    }
}
