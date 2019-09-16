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


        private Command<LoginModel> _loginCommand;
        public Command<LoginModel> LoginCommand
        {
            get => _loginCommand;
            set => SetProperty(ref _loginCommand, value);
        }
        public override async Task InitializeAsync()
        {
            await Task.Run(() =>
            {
                LoginCommand = new Command<LoginModel>(async model => ExecuteLoginCommand(model), CanExecuteLoginCommand);
            });
        }

        private bool CanExecuteLoginCommand(LoginModel arg)
        {
            return true;
        }

        private void ExecuteLoginCommand(LoginModel loginModel)
        {
            //tbt in case of apis
        }
    }
}
