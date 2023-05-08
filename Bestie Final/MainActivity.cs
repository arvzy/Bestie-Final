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
using Android.Media.TV;


namespace Bestie_Final
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        string[] suggestions;
                        
        Button btnoverview, btnautocompletesearch;
        AutoCompleteTextView searchBar;
        
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

            searchBar = FindViewById<AutoCompleteTextView>(Resource.Id.searchBar);

            string[] suggestions = Resources.GetStringArray(Resource.Array.searchRec);
            var adapter = new ReverseArrayAdapter<string>(this, Android.Resource.Layout.SimpleDropDownItem1Line, suggestions);
            searchBar.Adapter = adapter;

            searchBar.DropDownAnchor = searchBar.Id;
            searchBar.DropDownVerticalOffset = -200;

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
            btnautocompletesearch = FindViewById<Button>(Resource.Id.AutoCompleteSearch);

            btnoverview.Click += Btnoverview_Click;            
            btnautocompletesearch.Click += Btnautocompletesearch_Click;

            searchBar.EditorAction += (sender, args) =>
            {
                if (args.ActionId == ImeAction.Done)
                {
                    string text = searchBar.Text;
                    if (string.IsNullOrEmpty(text))
                    {
                        AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                        builder.SetTitle("Alert");
                        builder.SetMessage("Please enter a destination");
                        builder.SetPositiveButton("OK", (dialog, which) =>
                                {

                                });

                        AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();
                        dialog.Show();
                    }
                    else
                    {
                        var intent = new Intent(this, typeof(BuildingSearch));
                        intent.PutExtra("text", text);
                        intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.ClearTask | ActivityFlags.NewTask | ActivityFlags.TaskOnHome);
                        StartActivity(intent);

                        // Finish the current instance of the activity
                        FinishAffinity();
                    }
                }
            };


        }

        public class ReverseArrayAdapter<T> : ArrayAdapter<T>
        {
            public ReverseArrayAdapter(Context context, int resource, T[] objects) : base(context, resource, objects)
            {
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                View view = base.GetView(Count - position - 1, convertView, parent);
                return view;
            }
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
        
        private void Btnautocompletesearch_Click(object sender, EventArgs e)
        {
            string text = searchBar.Text;
            if (string.IsNullOrEmpty(text))
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Alert");
                builder.SetMessage("Please enter a destination");
                builder.SetPositiveButton("OK", (dialog, which) =>
                {

                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();
                dialog.Show();
            }   
            else
            {
                var intent = new Intent(this, typeof(BuildingSearch));
                intent.PutExtra("text", text);
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.ClearTask | ActivityFlags.NewTask | ActivityFlags.TaskOnHome);
                StartActivity(intent);

                // Finish the current instance of the activity
                FinishAffinity();
            }
        }
    }
}