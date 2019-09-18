using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LadyBug
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Shell.SetNavBarIsVisible(this, false);
        }
    }
}
