using QLTV_Nhom13.ViewModels.Windows;
using System.ComponentModel;
using System.Windows.Input;
using Wpf.Ui;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Windows
{
    /// <summary>
    /// Login page
    /// </summary>
    public partial class LoginWindow 
    {
        private readonly LoginWindowViewModel viewModel;

        public LoginWindow()
        {
            InitializeComponent();

            viewModel = new LoginWindowViewModel();

            DataContext = viewModel;
        }

    }
}
