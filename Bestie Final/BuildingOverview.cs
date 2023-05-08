using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Bestie_Final
{
    [Activity(Label = "BuildingOverview")]
    public class BuildingOverview : Activity
    {

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngoverview);

            DisplayMetrics displayMetrics = Resources.DisplayMetrics;
            float screenWidth = displayMetrics.WidthPixels / displayMetrics.Density;
            float screenHeight = displayMetrics.HeightPixels / displayMetrics.Density;

            Button backbtnbldngoviw = FindViewById<Button>(Resource.Id.BackBuildingOview);
            ImageButton bldngA = FindViewById<ImageButton>(Resource.Id.BuildingAOverview);
            ImageButton bldngB = FindViewById<ImageButton>(Resource.Id.BuildingBOverview);
            ImageButton bldngC = FindViewById<ImageButton>(Resource.Id.BuildingCOverview);
            ImageButton bldngD = FindViewById<ImageButton>(Resource.Id.BuildingDOverview);

            backbtnbldngoviw.Click += Backbtnbldngoviw_Click;
            bldngA.Click += BldngA_Click;
            bldngB.Click += BldngB_Click;
            bldngC.Click += BldngC_Click;
            bldngD.Click += BldngD_Click;


        }

        private void Backbtnbldngoviw_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
        }

        private void BldngA_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BuildingAOverview));
            this.StartActivity(intent);
        }

        private void BldngB_Click(object sender, EventArgs e)
        {
            ShowBuildingAlertDialog(Resource.Drawable.Locked);
        }

        private void BldngC_Click(object sender, EventArgs e)
        {
            ShowBuildingAlertDialog(Resource.Drawable.Locked);
        }

        private void BldngD_Click(object sender, EventArgs e)
        {
            ShowBuildingAlertDialog(Resource.Drawable.Locked);
        }

        private void ShowBuildingAlertDialog(int imageResource)
        {
            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            builder.SetTitle("Building Overview");

            builder.SetMessage("Coming Soon");

            ImageButton dialogImageButton = new ImageButton(this);
            dialogImageButton.SetImageResource(imageResource);

            dialogImageButton.Click += DialogImageButton_Click;

            builder.SetView(dialogImageButton);

            builder.SetPositiveButton("OK", (dialog, which) =>
            {

            });

            AlertDialog dialog = builder.Create();
            dialog.Show();
        }

        private void DialogImageButton_Click(object sender, EventArgs e)
        {
        }
    }
}