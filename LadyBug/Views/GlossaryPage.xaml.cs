using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LadyBug.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LadyBug.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlossaryPage : PageBase
    {
        public GlossaryPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}