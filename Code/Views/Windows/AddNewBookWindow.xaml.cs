using QLTV_Nhom13.ViewModels.Windows;
using System.ComponentModel;
using System.Windows.Input;
using Wpf.Ui;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Windows
{
    /// <summary>
    /// Interaction logic for AddNewBookWindow.xaml
    /// </summary>
    public partial class AddNewBookWindow 
    {
        private readonly AddNewBookViewModel viewModel;

        public AddNewBookWindow()
        {
            InitializeComponent();

            viewModel = new AddNewBookViewModel();

            DataContext = viewModel;
            
        }
    }
}
