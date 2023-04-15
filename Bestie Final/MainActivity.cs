using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Views;
using AndroidX.AppCompat.App;
using Android.Content.PM;
using Android.Graphics;

namespace Bestie_Final
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        Button btnoverview;
        Button btnsearch;
        Button btnabout;
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

            btnoverview = FindViewById<Button>(Resource.Id.BuildingOverviewButton);
            btnsearch = FindViewById<Button>(Resource.Id.SearchByBuildingButton);            

            btnoverview.Click += Btnoverview_Click;
            btnsearch.Click += Btnsearch_Click;
        }      

        private void Btnsearch_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(BuildingSearch));
            this.StartActivity(intent);
        }

        private void Btnoverview_Click(object sender, System.EventArgs e)
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
    }
}