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
            if (string.IsNullOrEmpty(searchText)) return;
            var sampleViewModel = new YoutubeViewModel(searchText);

            BindingContext = sampleViewModel;
        }

        private void LsView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = sender as InfiniteListView;
            if (item == null) return;
            var youtube = item.SelectedItem as YoutubeItem;
            var detail = new VideoDetails {BindingContext = youtube};
            Navigation.PushAsync(detail);
        }

        private void SearchChange(object sender, SelectedItemChangedEventArgs e)
        {
            var item = sender as InfiniteListView;
            if (item == null) return;
            var youtube = item.SelectedItem as YoutubeItem;
            var detail = new VideoDetails {BindingContext = youtube};
            Navigation.PushAsync(detail);
        }
    }
}
