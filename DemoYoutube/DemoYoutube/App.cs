using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DemoYoutube.Core;
using DemoYoutube.ViewModels;
using DemoYoutube.Views;
using Xamarin.Forms;

namespace DemoYoutube
{
    public class App : Application
    {
        public App()
        {
            var x = new InfiniteListView();
            var sampleView = new HomeScreen();

            var sampleViewModel = new YoutubeViewModel();

            sampleView.BindingContext = sampleViewModel;
            // The root page of your application
            MainPage = new NavigationPage(sampleView);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
