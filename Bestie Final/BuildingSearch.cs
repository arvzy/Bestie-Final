using Android.App;
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
    [Activity(Label = "BuildingSearch")]
    public class BuildingSearch : Activity
    {
        ImageView flr1img, mzznnimg, flr2img, flr3img, flr4img;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngsrch);

            string text = Intent.GetStringExtra("text");

            flr1img = FindViewById<ImageView>(Resource.Id.flr1Image);
            mzznnimg = FindViewById<ImageView>(Resource.Id.mzznnImage);
            flr2img = FindViewById<ImageView>(Resource.Id.flr2Image);
            flr3img = FindViewById<ImageView>(Resource.Id.flr3Image);
            flr4img = FindViewById<ImageView>(Resource.Id.flr4Image);

            if (text == "Floor 2" || text == "Floor 4")
            {
                flr2img.SetImageResource(Resource.Drawable.Floor2and4);
            }

            if (text == "Floor 1")
            {
                flr2img.SetImageResource(Resource.Drawable.Floor1);
            }

            if (text == "Floor 3")
            {
                flr2img.SetImageResource(Resource.Drawable.Floor3);
            }

            if (text == "Floor 3")
            {
                flr2img.SetImageResource(Resource.Drawable.Mezzanine);
            }
        }
    }
}