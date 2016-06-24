using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoYoutube.Common;
using DemoYoutube.Models;
using Xamarin.Forms;
using DemoYoutube.ViewModels;

namespace DemoYoutube.Views
{
    public partial class HomeScreen : ContentPage
    {
        public HomeScreen()
        {
            InitializeComponent();
            lsView.ItemSelected += LsView_ItemSelected;
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var searchText = searchBar.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                var sampleViewModel = new YoutubeViewModel(searchText);

                BindingContext = sampleViewModel;
            }
        }

        private void LsView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            InfiniteListView item = sender as InfiniteListView;
            YoutubeItem youtube = item.SelectedItem as YoutubeItem;
            VideoDetails detail = new VideoDetails();
            detail.BindingContext = youtube;
            Navigation.PushAsync(detail);
        }

        private void SearchChange(object sender, SelectedItemChangedEventArgs e)
        {
            InfiniteListView item = sender as InfiniteListView;
            YoutubeItem youtube = item.SelectedItem as YoutubeItem;
            VideoDetails detail = new VideoDetails();
            detail.BindingContext = youtube;
            Navigation.PushAsync(detail);
        }

    }
}
