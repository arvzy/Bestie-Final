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
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngsrch);
            var handler = new Handler();            
            string text = Intent.GetStringExtra("text");

            var imageView = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewFirst);
            var imageView2 = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewSecond);

            //Lobby
            if (text == "Admissions Office")
            {
                imageView.SetImageResource(Resource.Drawable.AdmissionsOffice);
            }

            if (text == "Cashier")
            {
                imageView.SetImageResource(Resource.Drawable.Cashier);
            }

            if (text == "Computer Laboratory A")
            {
                imageView.SetImageResource(Resource.Drawable.CompLabA);
            }

            if (text == "Deputy School Administrator")
            {
                imageView.SetImageResource(Resource.Drawable.Deputy);
            }

            if (text == "Registrar")
            {
                imageView.SetImageResource(Resource.Drawable.Registrar);
            }

            if (text == "Female Toilet Lobby")
            {
                imageView.SetImageResource(Resource.Drawable.FemaleToiletLobby);
            }

            if (text == "Male Toilet Lobby")
            {
                imageView.SetImageResource(Resource.Drawable.MaleToiletLobby);
            }

            //Mezzanine
            if (text == "Library")
            {
                imageView.SetImageResource(Resource.Drawable.Library1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.Library2);
                }, 5000);               
            }
        }
    }
}