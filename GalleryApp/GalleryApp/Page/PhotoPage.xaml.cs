﻿using GalleryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GalleryApp.Page
{
    public partial class PhotoPage : ContentPage
    {
        public PhotoPage(PictureInfo pictureInfo)
        {
            InitializeComponent();
            this.BindingContext = pictureInfo;
        }
    }
}