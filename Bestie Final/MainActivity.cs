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
using Android.Graphics.Drawables;

namespace Bestie_Final
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        string[] suggestions;
                        
        Button btnoverview, btnautocompletesearch, btnabout, btninstructions, eebtn;
        AutoCompleteTextView searchBar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Window.SetSoftInputMode(SoftInput.AdjustResize);

            RequestedOrientation = ScreenOrientation.Landscape;

            Typeface bestieFont = Typeface.CreateFromAsset(this.Assets, "Fonts/bestie-font.ttf");

            ViewGroup rootLayout = FindViewById<ViewGroup>(Android.Resource.Id.Content);
            SetTypefaceForView(rootLayout, bestieFont);

            searchBar = FindViewById<AutoCompleteTextView>(Resource.Id.searchBar);

            string[] suggestions = Resources.GetStringArray(Resource.Array.searchRec);
            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleDropDownItem1Line, suggestions);
            searchBar.Adapter = adapter;

            searchBar.DropDownAnchor = searchBar.Id;

            searchBar.EditorAction += (sender, args) =>
            {
                if (args.ActionId == ImeAction.Search)
                {
                    var searchText = searchBar.Text;

                }

                if (args.ActionId == ImeAction.Done)
                {
                    searchBar.ClearFocus();
                }
            };

            searchBar.FocusChange += (sender, e) =>
            {
                if (e.HasFocus)
                {
                    searchBar.Hint = "";
                }
                else
                {
                    searchBar.ClearFocus();
                    searchBar.Hint = "Search";
                    
                }
            };

            Window.DecorView.ViewTreeObserver.AddOnGlobalLayoutListener(new KeyboardVisibilityListener(searchBar));

            btnoverview = FindViewById<Button>(Resource.Id.BuildingOverviewButton);
            btnautocompletesearch = FindViewById<Button>(Resource.Id.AutoCompleteSearch);
            btnabout = FindViewById<Button>(Resource.Id.AboutButton);
            btninstructions = FindViewById<Button>(Resource.Id.InstructionsButton);
            eebtn = FindViewById<Button>(Resource.Id.EmergencyExitButton);

            btnoverview.Click += Btnoverview_Click;
            btnautocompletesearch.Click += Btnautocompletesearch_Click;
            btnabout.Click += Btnabout_Click;
            btninstructions.Click += Btninstructions_Click;
            eebtn.Click += Eebtn_Click;

            searchBar.EditorAction += (sender, args) =>
            {
                if (args.ActionId == ImeAction.Done)
                {
                    string text = searchBar.Text;
                    if (string.IsNullOrEmpty(text))
                    {
                        AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                        builder.SetTitle("Oops!");
                        builder.SetMessage("You don't have any input yet. Can you try again?");
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

        private void Eebtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(EmergencyExits));
            this.StartActivity(intent);
            Finish();
        }

        private void Btninstructions_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(InstructionsC));
            this.StartActivity(intent);
            Finish();
        }

        private void Btnabout_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(AboutC));
            this.StartActivity(intent);
            Finish();
        }

        private void Btnoverview_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BuildingOverview));
            this.StartActivity(intent);
            Finish();
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
                builder.SetTitle("Oops!");
                builder.SetMessage("You don't have any input yet. Can you try again?");
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

        private class KeyboardVisibilityListener : Java.Lang.Object, ViewTreeObserver.IOnGlobalLayoutListener
        {
            private readonly View _view;

            public KeyboardVisibilityListener(View view)
            {
                _view = view;
            }

            public void OnGlobalLayout()
            {
                Rect r = new Rect();
                _view.GetWindowVisibleDisplayFrame(r);

                int heightDiff = _view.RootView.Height - (r.Bottom - r.Top);

                if (heightDiff > 100) // arbitrary value to differentiate between keyboard and non-keyboard height
                {
                    // Keyboard is visible
                }
                else
                {
                    // Keyboard is hidden
                    _view.ClearFocus(); // clear focus when keyboard is hidden
                }
            }
        }


    }
}