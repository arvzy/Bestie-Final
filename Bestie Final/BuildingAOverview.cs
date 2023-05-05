using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bestie_Final
{
    [Activity(Label = "BuildingAOverview")]
    public class BuildingAOverview : Activity
    {        
        Button backbtnbldngaoview, frstflrbtn, mzznnbtn, scndflrbtn, thrdflrbtn, frthflrbtn, rfdckbtn;
        ImageView imageViewBAView;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngAoview);

            imageViewBAView = FindViewById<ImageView>(Resource.Id.imageViewBuildingView);

            backbtnbldngaoview = FindViewById<Button>(Resource.Id.BackBuildingAOview);
            frstflrbtn = FindViewById<Button>(Resource.Id.frstfButton);
            mzznnbtn = FindViewById<Button>(Resource.Id.mzznnButton);
            scndflrbtn = FindViewById<Button>(Resource.Id.scndfButton);
            thrdflrbtn = FindViewById<Button>(Resource.Id.thrdfButton);
            frthflrbtn = FindViewById<Button>(Resource.Id.frthfButton);
            rfdckbtn = FindViewById<Button>(Resource.Id.rfdckButton);

            backbtnbldngaoview.Click += Backbtnbldngaoview_Click;
            frstflrbtn.Click += Frstflrbtn_Click;
            mzznnbtn.Click += Mzznnbtn_Click;
            scndflrbtn.Click += Scndflrbtn_Click;
            thrdflrbtn.Click += Thrdflrbtn_Click;
            frthflrbtn.Click += Frthflrbtn_Click;
            rfdckbtn.Click += Rfdckbtn_Click;
         
        }        

        private void Frstflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.Floor1);
        }

        private void Mzznnbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.Mezzanine);
        }

        private void Scndflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.Floor2);
        }

        private void Thrdflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.Floor3);
        }

        private void Frthflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.Floor4);
        }

        private void Rfdckbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.Roofdeck);
        }
        private void Backbtnbldngaoview_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BuildingOverview));
            this.StartActivity(intent);
        }
        
    }
}