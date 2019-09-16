using LadyBug.ViewModels;
using Miraculix.Helpers;
using Miraculix.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LadyBug.Helpers
{
    public abstract class PageBase : ContentPage, IRefreshable
    {
        public void DisplayOnlyFrom(IEnumerable<Type> allowedViewModelTypes)
        {
            _filter = allowedViewModelTypes.ToArray();
        }
        protected PageBase()
        {
            MessagingCenter.Subscribe<ViewModelBase, MessagingCenterAlert>(this, "DisplayAlert", DisplayAlertFromMessagingCenter);

        }

        public virtual async void DisplayAlertFromMessagingCenter(ViewModelBase arg1, MessagingCenterAlert arg2)
        {
            if (_filter != null && _filter.Length > 0)
            {
                if (_filter.Any(a => arg1.GetType() == a))
                {
                    await DisplayAlert(arg2.Title, arg2.Message, arg2.Cancel);

                }
            }
            else
            {
                await DisplayAlert(arg2.Title, arg2.Message, arg2.Cancel);

            }
        }

        private ViewModelBase _viewModel;
        private Type[] _filter;

        public ViewModelBase ViewModel
        {
            get => _viewModel;
            set { _viewModel = value; OnPropertyChanged(); }
        }

        public async Task Refresh(object[] constructorParams)
        {
            await Task.Run(() =>
            {
                var o = constructorParams.FirstOrDefault();
                if (o is ViewModelBase obase)
                {
                    ViewModel = obase;
                }
            });

        }
    }
}
