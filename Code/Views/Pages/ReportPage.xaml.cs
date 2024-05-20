using QLTV_Nhom13.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Pages
{
    /// <summary>
    /// Interaction logic for ReportPage.xaml
    /// </summary>
    public partial class ReportPage : INavigableView<ReportViewModel>
    {
        public ReportViewModel ViewModel { get; }

        public ReportPage(ReportViewModel viewModel)
        {
            ViewModel = viewModel;

            DataContext = this;
            InitializeComponent();
        }
    }
}


