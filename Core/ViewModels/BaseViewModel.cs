using Acr.UserDialogs;
using MvvmCross;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public abstract class BaseViewModel : MvxViewModel
    {
        protected readonly IUserDialogs _userDialogs;
        protected readonly IMvxNavigationService _navigationService;

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
        protected BaseViewModel()
        {
            if (Mvx.IoCProvider.CanResolve<IMvxNavigationService>())
            {
                _navigationService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();
                _userDialogs = Mvx.IoCProvider.Resolve<IUserDialogs>();
            }
          
        }

        /// <summary>
        /// Gets the internationalized string at the given <paramref name="index"/>, which is the key of the resource.
        /// </summary>
        /// <param name="index">Index key of the string from the resources of internationalized strings.</param>
       // public string this[string index] => Strings.ResourceManager.GetString(index);
    }

    public abstract class BaseViewModel<TParameter, TResult> : MvxViewModel<TParameter, TResult>
        where TParameter : class
        where TResult : class
    {
        protected readonly IMvxNavigationService _navigationService;
        protected readonly IUserDialogs _userDialogs;
        protected BaseViewModel()
        {
            _navigationService = Mvx.IoCProvider.Resolve<IMvxNavigationService>();
            _userDialogs = Mvx.IoCProvider.GetSingleton<IUserDialogs>();
        }

        /// <summary>
        /// Gets the internationalized string at the given <paramref name="index"/>, which is the key of the resource.
        /// </summary>
        /// <param name="index">Index key of the string from the resources of internationalized strings.</param>
       // public string this[string index] => Strings.ResourceManager.GetString(index);
    }
}
