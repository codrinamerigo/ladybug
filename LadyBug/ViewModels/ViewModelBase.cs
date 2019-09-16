using LadyBug.Helpers;
using Miraculix.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LadyBug.ViewModels
{

        public abstract class ViewModelBase : NotifyBase, IAsyncInitialization
        {
            protected INotifyTaskCompletion InitializationNotifier { get; set; }
            public Task Initialization => InitializationNotifier.Task;

            private bool _isBusy;


            protected ViewModelBase()
            {
                // EXAMPLE for other class impl
                // InitializationNotifier = NotifyTaskCompletion.Create(InitializeAsync());
            }

            public virtual async Task InitializeAsync()
            {
                await Task.Run(() => { Console.WriteLine("ViewModelBase Initialized!"); });
            }

           
            public bool IsBusy
            {
                get => _isBusy;
                set => SetProperty(ref _isBusy, value);
            }

            
        }

}

