﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DemoYoutube.Views
{
    public partial class VideoDetails : ContentPage
    {
        public VideoDetails()
        {
            InitializeComponent();
            //Creating TapGestureRecognizers  
            var tapImage = new TapGestureRecognizer();
            //Binding events  
            tapImage.Tapped += tapImage_Tapped;
            //Associating tap events to the image buttons  
            btnPlay.GestureRecognizers.Add(tapImage);
        }

        void tapImage_Tapped(object sender, EventArgs e)
        {
            // handle the tap  
            DisplayAlert("Alert", "This is an image button", "OK");
        }
    }
}
