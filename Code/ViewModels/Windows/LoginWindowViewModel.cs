/*using System;
using System.Windows.Input;
using Wpf.Ui.Controls; // Assuming this namespace contains relevant controls

namespace QLTV_Nhom13.ViewModels.Windows
{
    class LoginWindowViewModel : ObservableObject
    {
        // Properties for data binding
        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        // Command for login button
        private ICommand _loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                {
                    _loginCommand = new RelayCommand(Login, CanLogin);
                }
                return _loginCommand;
            }
        }

        // Execute when login button is clicked
        private void Login(object parameter)
        {
            // Validate username and password
            if (IsValidLogin(Username, Password))
            {
                // Successful login logic
                // Navigate to the next view (OverviewScreenView)
                // You can use a navigation service or change the current view here
            }
            else
            {
                // Show an error message or handle invalid login
            }
        }

        // Check if login is allowed
        private bool CanLogin(object parameter)
        {
            // Implement your logic here (e.g., check if fields are not empty)
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

        // Placeholder method for login validation (replace with your actual logic)
        private bool IsValidLogin(string username, string password)
        {
            // Replace with your authentication logic (e.g., check against a database)
            // For demonstration purposes, allow any non-empty username and password
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
        }
    }
}
*/