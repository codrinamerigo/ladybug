using LadyBug.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LadyBug.Models
{
    public class LoginModel : NotifyBase
    {
        private string _user;
        private string _password;

        public string User
        {
            get => _user;
            set
            {
                SetProperty(ref _user, value);
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                SetProperty(ref _password, value);
            }
        }
    }
}
