using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Views.Animations;
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
        Button backbtnbldngaoview, frstflrbtn, mzznnbtn, scndflrbtn, thrdflrbtn, frthflrbtn, rfdckbtn, homebtn;
        ImageView imageViewBAView;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngAoview);

            imageViewBAView = FindViewById<ImageView>(Resource.Id.imageViewBuildingView);

            backbtnbldngaoview = FindViewById<Button>(Resource.Id.BackBuildingAOview);
            homebtn = FindViewById<Button>(Resource.Id.home);
            frstflrbtn = FindViewById<Button>(Resource.Id.frstfButton);
            mzznnbtn = FindViewById<Button>(Resource.Id.mzznnButton);
            scndflrbtn = FindViewById<Button>(Resource.Id.scndfButton);
            thrdflrbtn = FindViewById<Button>(Resource.Id.thrdfButton);
            frthflrbtn = FindViewById<Button>(Resource.Id.frthfButton);
            rfdckbtn = FindViewById<Button>(Resource.Id.rfdckButton);

            backbtnbldngaoview.Click += Backbtnbldngaoview_Click;
            homebtn.Click += Homebtn_Click;
            frstflrbtn.Click += Frstflrbtn_Click;
            mzznnbtn.Click += Mzznnbtn_Click;
            scndflrbtn.Click += Scndflrbtn_Click;
            thrdflrbtn.Click += Thrdflrbtn_Click;
            frthflrbtn.Click += Frthflrbtn_Click;
            rfdckbtn.Click += Rfdckbtn_Click;
         
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
            Finish();

            Button button = (Button)sender;
            Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
            button.StartAnimation(animation);
        }

        private void Frstflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.LobbyLayout);
        }

        private void Mzznnbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.LibraryLayout);
        }

        private void Scndflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.SecondFlrLayout);
        }

        private void Thrdflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.ThirdFlrLayout);
        }

        private void Frthflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.FourthFlrLayout);
        }

        private void Rfdckbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.RoofDeckLayout);
        }
        private void Backbtnbldngaoview_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BuildingOverview));
            this.StartActivity(intent);
            Finish();

            Button button = (Button)sender;
            Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
            button.StartAnimation(animation);
        }
        
    }
}