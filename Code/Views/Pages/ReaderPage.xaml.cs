using QLTV_Nhom13.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Pages
{
    /// <summary>
    /// Interaction logic for ReaderPage.xaml
    /// </summary>
    public partial class ReaderPage : INavigableView<ReaderViewModel>
    {
        public ReaderViewModel ViewModel { get; }

        public ReaderPage(ReaderViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
        }
    }
}


