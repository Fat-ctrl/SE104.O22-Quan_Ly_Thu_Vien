using QLTV_Nhom13.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Pages
{
    /// <summary>
    /// Interaction logic for ManageUserPage.xaml
    /// </summary>
    public partial class ManageUserPage : INavigableView<ManageUserViewModel>
    {
        public ManageUserViewModel ViewModel { get; }

        public ManageUserPage(ManageUserViewModel viewModel)
        {
            ViewModel = viewModel;

            /*InitializeComponent();*/
        }
    }
}


