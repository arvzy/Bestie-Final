using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Views;
using AndroidX.AppCompat.App;

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

            btnoverview = FindViewById<Button>(Resource.Id.BuildingOverviewButton);
            btnsearch = FindViewById<Button>(Resource.Id.SearchByBuildingButton);
            btnabout = FindViewById<Button>(Resource.Id.AboutButton);

            btnoverview.Click += Btnoverview_Click;
            btnsearch.Click += Btnsearch_Click;
            btnabout.Click += Btnabout_Click;
        }

        private void Btnabout_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(About));
            this.StartActivity(intent); ;
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
    }
}