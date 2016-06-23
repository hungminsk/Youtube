﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoYoutube.Core;
using DemoYoutube.Models;
using Xamarin.Forms;

namespace DemoYoutube.Views
{
    public partial class HomeScreen : ContentPage
    {
        public HomeScreen()
        {
            InitializeComponent();
            lsView.ItemSelected += LsView_ItemSelected;
        }

        private void LsView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            InfiniteListView item = sender as InfiniteListView;
            YoutubeItem youtube = item.SelectedItem as YoutubeItem;

            Navigation.PushAsync(new VideoView());
        }
    }
}