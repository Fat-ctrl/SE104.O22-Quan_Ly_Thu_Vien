using QLTV_Nhom13.ViewModels.Windows;
using System.Windows;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Windows
{
    /// <summary>
    /// Interaction logic for ChangeAuthorInfo.xaml
    /// </summary>
    public partial class ChangeAuthorInfo
    {
        private readonly ChangeAuthorInfoViewModel _viewModel;

        public ChangeAuthorInfoViewModel DataContext { get; }

        public ChangeAuthorInfo()
        {
            InitializeComponent();

            _viewModel = new ChangeAuthorInfoViewModel();

            DataContext = _viewModel;

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
