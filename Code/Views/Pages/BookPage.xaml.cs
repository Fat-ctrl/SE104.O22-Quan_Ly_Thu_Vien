using QLTV_Nhom13.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.Views.Pages
{
    public partial class BookPage : INavigableView<BookViewModel>
    {
        public BookViewModel ViewModel { get; }

        public BookPage(BookViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
