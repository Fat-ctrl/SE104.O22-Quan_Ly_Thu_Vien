using QLTV_Nhom13.ViewModels.Windows;
using System.Windows;
using Wpf.Ui;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Windows
{
    /// <summary>
    /// Interaction logic for ChangeReaderInfo.xaml
    /// </summary>
    public partial class ChangeBookTitleInfo
    {
        private readonly ChangeBookTitleInfoViewModel _viewModel;

        public ChangeBookTitleInfoViewModel DataContext { get; }

        public ChangeBookTitleInfo() 
        {
            InitializeComponent();

            _viewModel = new ChangeBookTitleInfoViewModel();

            DataContext = _viewModel;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
        
}
