using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Views;
using AndroidX.AppCompat.App;
using Android.Content.PM;
using Android.Graphics;
using Javax.Security.Auth;
using Android.Media.Metrics;
using System;
using Android.Animation;

namespace Bestie_Final
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        Button btnoverview, btnsearch;
        SearchView searchBar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            RequestedOrientation = ScreenOrientation.Landscape;

            Typeface bestieFont = Typeface.CreateFromAsset(this.Assets, "Fonts/fatherless.ttf");

            ViewGroup rootLayout = FindViewById<ViewGroup>(Android.Resource.Id.Content);
            SetTypefaceForView(rootLayout, bestieFont);

            searchBar = FindViewById<SearchView>(Resource.Id.searchBar);

            btnoverview = FindViewById<Button>(Resource.Id.BuildingOverviewButton);
            btnsearch = FindViewById<Button>(Resource.Id.searchBtn);

            btnoverview.Click += Btnoverview_Click;
            btnsearch.Click += searchOnClick;
        }

        private void Btnoverview_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BuildingOverview));
            this.StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void SetTypefaceForView(View view, Typeface typeface)
        {
            if (view is TextView)
            {
                ((TextView)view).Typeface = typeface;
                ((TextView)view).SetShadowLayer(20, 0, 0, Color.Black);
            }

            else if (view is ViewGroup)
            {
                ViewGroup viewGroup = (ViewGroup)view;
                for (int i = 0; i < viewGroup.ChildCount; i++)
                {
                    SetTypefaceForView(viewGroup.GetChildAt(i), typeface);
                }
            } 
        }

        private void searchOnClick(object sender, EventArgs e) 
        {
            if (searchBar.Visibility == ViewStates.Visible)
            {
                searchBar.Visibility = ViewStates.Gone;
                var anim = ObjectAnimator.OfFloat(searchBar, "alpha", 1, 0);
                anim.SetDuration(300);
                anim.Start();
            }
            else 
            {
                searchBar.Visibility = ViewStates.Visible;
                var anim = ObjectAnimator.OfFloat(searchBar, "alpha", 0, 1);
                anim.SetDuration(300);
                anim.Start();
            }

        }
    }
}