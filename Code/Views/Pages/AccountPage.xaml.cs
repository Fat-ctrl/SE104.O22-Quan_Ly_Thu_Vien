using QLTV_Nhom13.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Pages
{
    public partial class AccountPage : INavigableView<AccountViewModel>
    {
        public AccountViewModel ViewModel { get; }

        public AccountPage(AccountViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
