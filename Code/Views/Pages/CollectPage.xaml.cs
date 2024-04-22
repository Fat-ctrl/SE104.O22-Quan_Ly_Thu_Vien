using QLTV_Nhom13.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Pages
{
    /// <summary>
    /// Interaction logic for ReaderPage.xaml
    /// </summary>
    public partial class CollectPage : INavigableView<CollectViewModel>
    {
        public CollectViewModel ViewModel { get; }

        public CollectPage(CollectViewModel viewModel)
        {
            ViewModel = viewModel;

            /*InitializeComponent();*/
        }
    }
}


