using Acr.UserDialogs;
using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using System;

namespace Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            CreatableTypes()
                .EndingWith("Client")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            Mvx.IoCProvider.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);

            // register the appstart object
            RegisterCustomAppStart<AppStart>();

            //https://github.com/MvvmCross/MvvmCross-Samples/blob/master/StarWarsSample/StarWarsSample.Core/ViewModels/PlanetViewModel.cs
        }
    }
}
