using LadyBug.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LadyBug.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        readonly IAuthenticationService _authService;
        private string userName;
        private string password;

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                if (userName != value)
                {
                    userName = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }

        public LoginViewModel( IAuthenticationService authService)
        {
            _authService = authService;
        }

        private Command _loginCommand;

        public Command LoginCommand
        {
            get => _loginCommand;
            set => SetProperty(ref _loginCommand, value);
        }
        public override async Task InitializeAsync()
        {
            await Task.Run(() =>
            {
                LoginCommand = new Command(ExecuteLoginCommand,
                    CanExecuteLoginCommand);
            });
        }

        private bool CanExecuteLoginCommand(object arg)
        {
            if (UserName != null && Password != null)
                return true;
            else
                return false;
        }

        private void ExecuteLoginCommand(object obj)
        {
            //tbt in case of apis
        }
    }
}
