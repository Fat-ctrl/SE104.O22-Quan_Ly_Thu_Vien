using QLTV_Nhom13.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Pages
{
    /// <summary>
    /// Interaction logic for PropertyPage.xaml
    /// </summary>
    public partial class PropertyPage : INavigableView<PropertyViewModel>
    {
        public PropertyViewModel ViewModel { get; }

        public PropertyPage(PropertyViewModel viewModel)
        {
            ViewModel = viewModel;

            /*InitializeComponent();*/
        }
    }
}


