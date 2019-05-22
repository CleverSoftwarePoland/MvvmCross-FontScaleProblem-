using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using MyMvvmCrossApp1.Core.ViewModels.Home;
using Xam.Plugin.TabView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMvvmCrossApp1.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true)]
    public partial class HomePage : MvxContentPage<HomeViewModel>
    {

        TabViewControl _tabView;
        SampleView _sampleView;

        public HomePage()
        {
            InitializeComponent();
            ctlCarouselView.ItemsSource = new List<object> { new object { } };

            _sampleView = new SampleView();

            _tabView = new TabViewControl(new List<TabItem>()
            {
                new TabItem("DASHBOARD", _sampleView),
            });

            gdTabView.Children.Add(_tabView);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current.MainPage is NavigationPage navigationPage)
            {
                navigationPage.BarTextColor = Color.White;
                navigationPage.BarBackgroundColor = (Color)Application.Current.Resources["PrimaryColor"];
            }
        }
    }
}
