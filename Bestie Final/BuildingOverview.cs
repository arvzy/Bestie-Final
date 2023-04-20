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
    [Activity(Label = "BuildingOverview")]
    public class BuildingOverview : Activity
    {

        Button bldngA;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngoverview);

            Button backbtnbldngoviw = FindViewById<Button>(Resource.Id.BackBuildingOview);
            Button bldngA = FindViewById<Button>(Resource.Id.BuildingAOverview);

            backbtnbldngoviw.Click += Backbtnbldngoviw_Click;
            bldngA.Click += BldngA_Click;

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
    }
}