using System.Collections.ObjectModel;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.ViewModels.Windows
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _applicationTitle = "Librasoft";

        [ObservableProperty]
        private ObservableCollection<object> _menuItems = new()
        {
            new NavigationViewItem()
            {
                Content = "Độc giả",
                Icon = new SymbolIcon { Symbol = SymbolRegular.BookContacts24 },
                TargetPageType = typeof(Views.Pages.ReaderPage)
            },
            new NavigationViewItem()
            {
                Content = "Sách",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Book24 },
                TargetPageType = typeof(Views.Pages.BookPage)
            },
            new NavigationViewItem()
            {
                Content = "Phiếu mượn trả",
                Icon = new SymbolIcon { Symbol = SymbolRegular.BookClock24 },
                TargetPageType = typeof(Views.Pages.BorrowPage)
            },
            new NavigationViewItem()
            {
                Content = "Phiếu thu",
                Icon = new SymbolIcon { Symbol = SymbolRegular.ReceiptMoney24 },
                TargetPageType = typeof(Views.Pages.CollectPage)
            },
            new NavigationViewItem()
            {
                Content = "Báo cáo thống kê",
                Icon = new SymbolIcon { Symbol = SymbolRegular.DocumentData24 },
                TargetPageType = typeof(Views.Pages.ReportPage)
            },
            new NavigationViewItem()
            {
                Content = "Quản lí người dùng",
                Icon = new SymbolIcon { Symbol = SymbolRegular.PeopleLock24 },
                TargetPageType = typeof(Views.Pages.ManageUserPage)
            },
            new NavigationViewItem()
            {
                Content = "Thay đổi quy định",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Wrench24 },
                TargetPageType = typeof(Views.Pages.PropertyPage)
            },
        };

        [ObservableProperty]
        private ObservableCollection<object> _footerMenuItems = new()
        {
            new NavigationViewItem()
            {
                Content = "Tài khoản",
                Icon = new SymbolIcon { Symbol = SymbolRegular.PersonCircle24 },
                TargetPageType = typeof(Views.Pages.AccountPage)
            },
            new NavigationViewItem()
            {
                Content = "Cài đặt",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                TargetPageType = typeof(Views.Pages.SettingsPage)
            }
        };

        [ObservableProperty]
        private ObservableCollection<MenuItem> _trayMenuItems = new()
        {
            new MenuItem { Header = "Home", Tag = "tray_home" }
        };
    }
}
