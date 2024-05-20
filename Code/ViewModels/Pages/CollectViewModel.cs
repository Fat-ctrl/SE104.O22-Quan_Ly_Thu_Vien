using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace QLTV_Nhom13.ViewModels.Pages
{
    public partial class CollectViewModel : ObservableObject, INavigationAware
    {
        public CollectViewModel() {}

        private bool _isInitialized = false;

        public void OnNavigatedFrom()
        {
            
        }

        public void OnNavigatedTo()
        {
            if (!_isInitialized)
                InitializeViewModel();
        }

        private void InitializeViewModel()
        {
            _isInitialized = true;
        }
    }
}
