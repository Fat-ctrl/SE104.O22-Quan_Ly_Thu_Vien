using QLTV_Nhom13.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Pages
{
    /// <summary>
    /// Interaction logic for BorrowPage.xaml
    /// </summary>
    public partial class BorrowPage : INavigableView<BorrowViewModel>
    {
        public BorrowViewModel ViewModel { get; }

        public BorrowPage(BorrowViewModel viewModel)
        {
            ViewModel = viewModel;

            /*InitializeComponent();*/
        }
    }
}


