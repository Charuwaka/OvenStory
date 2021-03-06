﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace OvenStory.views
{
    [Activity(Label = "HomeActivity")]
    public class HomeActivity : MvxActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_home);
            // Create your application here
        }
    }
}