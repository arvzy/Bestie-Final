﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bestie_Final
{
    [Activity(Label = "About")]
    public class About : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.about);

            var scrollView = FindViewById<ScrollView>(Resource.Id.scrollView);
            var textView = FindViewById<TextView>(Resource.Id.textView1);

            textView.Text = "BESTIE";

            scrollView.SmoothScrollingEnabled = true;
            scrollView.ScrollBarStyle = ScrollbarStyles.OutsideOverlay;
            scrollView.ScrollbarFadingEnabled = false;
        }
    }
}
