using LadyBug.Helpers;
using LadyBug.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LadyBug.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : PageBase
    {
        private LoginViewModel _viewModel;
        public new LoginViewModel ViewModel
        {
            get { return _viewModel; }
            set { _viewModel = value; OnPropertyChanged(); }
        }

        public LoginPage() 
        {
            InitializeComponent();

            ViewModel = new LoginViewModel();
            BindingContext = ViewModel;
        }

        private void UserNameBox_Focused(object sender, FocusEventArgs e)
        {
            this.UserNameBox.Focus();
        }

        private void PasswordBox_Focused(object sender, FocusEventArgs e)
        {
            this.PasswordBox.Focus();
        }

        private void UserRecognizer_Tapped(object sender, EventArgs e)
        {
            this.UserNameBox.Focus();
        }

        private void PasswordRecognizer_Tapped(object sender, EventArgs e)
        {
            this.PasswordBox.Focus();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {

            LoginButton.TextColor = Color.White;
            LoginButton.BackgroundColor = Color.DarkRed;
            //demo purpose only
            App.Current.MainPage = new AppShell();
        }

        private void LoginButton_Pressed(object sender, EventArgs e)
        {
            LoginButton.TextColor = Color.White;
            LoginButton.BackgroundColor = Color.DarkRed;


        }

    }
}