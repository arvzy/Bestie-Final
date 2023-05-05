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
using AndroidX.AppCompat.Widget;
using Android.Views.InputMethods;
using Microsoft.Win32;
using Android.Content.Res;
using Android.Util;
using System.Threading.Tasks;

namespace Bestie_Final
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        string[] suggestions;
                        
        Button btnoverview, btnsearch, btnautocompletesearch;
        AutoCompleteTextView searchBar;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            DisplayMetrics displayMetrics = Resources.DisplayMetrics;

            // Calculate the screen width and height in DP
            float screenWidthDp = displayMetrics.WidthPixels / displayMetrics.Density;
            float screenHeightDp = displayMetrics.HeightPixels / displayMetrics.Density;

            RequestedOrientation = ScreenOrientation.Landscape;

            Typeface bestieFont = Typeface.CreateFromAsset(this.Assets, "Fonts/fatherless.ttf");

            ViewGroup rootLayout = FindViewById<ViewGroup>(Android.Resource.Id.Content);
            SetTypefaceForView(rootLayout, bestieFont);

            suggestions = Resources.GetStringArray(Resource.Array.searchRec);

            searchBar = FindViewById<AutoCompleteTextView>(Resource.Id.searchBar);

            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleDropDownItem1Line, suggestions);

            searchBar.Adapter = adapter;

            searchBar.EditorAction += (sender, args) =>
            {
                if (args.ActionId == ImeAction.Search)
                {
                    var searchText = searchBar.Text;
                    
                }

                if (args.ActionId == ImeAction.Done)
                {

                }
            };

            btnoverview = FindViewById<Button>(Resource.Id.BuildingOverviewButton);
            //btnsearch = FindViewById<Button>(Resource.Id.searchBtn);
            btnautocompletesearch = FindViewById<Button>(Resource.Id.AutoCompleteSearch);

            btnoverview.Click += Btnoverview_Click;
            /*btnsearch.Click += searchOnClick*/;
            btnautocompletesearch.Click += Btnautocompletesearch_Click;

            searchBar.EditorAction += (sender, args) =>
            {
                if (args.ActionId == ImeAction.Done)
                {
                    string text = searchBar.Text;
                    if (string.IsNullOrEmpty(text))
                    {
                        Toast toast = Toast.MakeText(this, "Please enter a destination", ToastLength.Long);
                        toast.SetGravity(GravityFlags.Center | GravityFlags.CenterHorizontal | GravityFlags.CenterVertical, 0, 0);
                        toast.Show();
                        return;
                    }
                    var intent = new Intent(this, typeof(BuildingSearch));
                    intent.PutExtra("text", text);
                    this.StartActivity(intent);
                }
            };
        }
        

        private void Btnoverview_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BuildingOverview));
            this.StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
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

        //private void searchOnClick(object sender, EventArgs e) 
        //{
        //    if (searchBar.Visibility == ViewStates.Visible)
        //    {
        //        searchBar.Visibility = ViewStates.Gone;
        //        var anim = ObjectAnimator.OfFloat(searchBar, "alpha", 1, 0);
        //        anim.SetDuration(300);
        //        anim.Start();
        //    }
        //    else 
        //    {
        //        searchBar.Visibility = ViewStates.Visible;
        //        var anim = ObjectAnimator.OfFloat(searchBar, "alpha", 0, 1);
        //        anim.SetDuration(300);
        //        anim.Start();
        //    }

        //    if (btnautocompletesearch.Visibility == ViewStates.Visible)
        //    {
        //        btnautocompletesearch.Visibility = ViewStates.Gone;
        //    }
        //    else
        //    {
        //        btnautocompletesearch.Visibility= ViewStates.Visible;
        //    }
        //}
        
        private void Btnautocompletesearch_Click(object sender, EventArgs e)
        {
            string text = searchBar.Text;
            if (string.IsNullOrEmpty(text))
            {               
                Toast toast = Toast.MakeText(this, "Please enter a destination", ToastLength.Long);
                toast.SetGravity(GravityFlags.Center | GravityFlags.CenterHorizontal | GravityFlags.CenterVertical, 0, 0);
                toast.Show();
                return;
            }
            var intent = new Intent(this, typeof(BuildingSearch));
            intent.PutExtra("text", text);
            this.StartActivity(intent);
            
            
        }
    }
}