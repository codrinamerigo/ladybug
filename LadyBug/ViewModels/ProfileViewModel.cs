using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace LadyBug.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public ProfileViewModel()
        {
            Title = "Profile";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://github.com/codrinamerigo")));
        }

        public ICommand OpenWebCommand { get; }
    }
}