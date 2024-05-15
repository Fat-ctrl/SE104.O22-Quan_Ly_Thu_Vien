/*using System.ComponentModel;
using System.Windows.Input;

namespace QLTV_Nhom13.ViewModels.Windows
{
    public class LoginWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        private string _errorMessage;
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                if (_errorMessage != value)
                {
                    _errorMessage = value;
                    OnPropertyChanged(nameof(ErrorMessage));
                }
            }
        }

        public ICommand LoginCommand { get; }

        public LoginWindowViewModel()
        {
            // Initialize commands
            LoginCommand = new RelayCommand(Login);
        }

        private void Login(object parameter)
        {
            // Here you can implement your login logic
            // For demonstration purposes, I'm just setting an error message if username or password is empty
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                ErrorMessage = "Username and Password are required.";
            }
            else
            {
                // Your login logic goes here
                // For example, you could authenticate the user against a database or a service
                // If authentication is successful, navigate to the main application window
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
*/