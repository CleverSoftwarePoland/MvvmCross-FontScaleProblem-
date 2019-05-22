using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Core;
using MvvmCross.Forms.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Binding.Views;
using MyMvvmCrossApp1.Core.ViewModels.Main;

namespace MyMvvmCrossApp1.Droid
{
    [Activity(Theme = "@style/AppTheme")]
    public class MainActivity : MvxFormsAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            //var contextWrapper = Application.Resources.Configuration;

        }

        protected override void AttachBaseContext(Context @base)
        {
            Configuration overrideConfiguration = new Configuration();
            overrideConfiguration = @base.Resources.Configuration;
            overrideConfiguration.SetToDefaults();
            overrideConfiguration.FontScale = 0.85f;
            Context context = @base.CreateConfigurationContext(overrideConfiguration);

            base.AttachBaseContext(context);

        }
    }
}
