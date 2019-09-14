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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
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
    }
}