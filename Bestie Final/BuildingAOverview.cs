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
    [Activity(Label = "BuildingAOverview")]
    public class BuildingAOverview : Activity
    {        
        Button backbtnbldngaoview, frstflrbtn, mzznnbtn, scndflrbtn, thrdflrbtn, frthflrbtn;
        ImageView flr1img, mzznnimg, flr2img, flr3img, flr4img;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngAoview);

            backbtnbldngaoview = FindViewById<Button>(Resource.Id.BackBuildingAOview);
            frstflrbtn = FindViewById<Button>(Resource.Id.frstfButton);
            mzznnbtn = FindViewById<Button>(Resource.Id.mzznnButton);
            scndflrbtn = FindViewById<Button>(Resource.Id.scndfButton);
            thrdflrbtn = FindViewById<Button>(Resource.Id.thrdfButton);
            frthflrbtn = FindViewById<Button>(Resource.Id.frthfButton);

            backbtnbldngaoview.Click += Backbtnbldngaoview_Click;
            frstflrbtn.Click += Frstflrbtn_Click;
            mzznnbtn.Click += Mzznnbtn_Click;
            scndflrbtn.Click += Scndflrbtn_Click;
            thrdflrbtn.Click += Thrdflrbtn_Click;
            frthflrbtn.Click += Frthflrbtn_Click;

            flr1img = FindViewById<ImageView>(Resource.Id.flr1Image);
            mzznnimg = FindViewById<ImageView>(Resource.Id.mzznnImage);
            flr2img = FindViewById<ImageView>(Resource.Id.flr2Image);
            flr3img = FindViewById<ImageView>(Resource.Id.flr3Image);
            flr4img = FindViewById<ImageView>(Resource.Id.flr4Image);            
        }              
              

        private void Frstflrbtn_Click(object sender, EventArgs e)
        {
            if (flr1img.Visibility == ViewStates.Invisible)
            {
                flr1img.Visibility = ViewStates.Visible;
                mzznnimg.Visibility = ViewStates.Invisible;
                flr2img.Visibility = ViewStates.Invisible;
                flr3img.Visibility = ViewStates.Invisible;
                flr4img.Visibility = ViewStates.Invisible;

            }
            else
            {
                flr1img.Visibility = ViewStates.Visible;                
            }
        }

        private void Mzznnbtn_Click(object sender, EventArgs e)
        {
            if (mzznnimg.Visibility == ViewStates.Invisible)
            {
                mzznnimg.Visibility = ViewStates.Visible;
                flr1img.Visibility = ViewStates.Invisible;
                flr2img.Visibility = ViewStates.Invisible;
                flr3img.Visibility = ViewStates.Invisible;
                flr4img.Visibility = ViewStates.Invisible;
            }            
        }

        private void Scndflrbtn_Click(object sender, EventArgs e)
        {
            if (flr2img.Visibility == ViewStates.Invisible)
            {
                flr2img.Visibility = ViewStates.Visible;
                flr1img.Visibility = ViewStates.Invisible;
                mzznnimg.Visibility = ViewStates.Invisible;
                flr3img.Visibility = ViewStates.Invisible;
                flr4img.Visibility = ViewStates.Invisible;                
            } 
        }

        private void Thrdflrbtn_Click(object sender, EventArgs e)
        {
            if (flr3img.Visibility == ViewStates.Invisible)
            {
                flr3img.Visibility = ViewStates.Visible;
                flr1img.Visibility = ViewStates.Invisible;
                mzznnimg.Visibility = ViewStates.Invisible;
                flr2img.Visibility = ViewStates.Invisible;
                flr4img.Visibility = ViewStates.Invisible;
            }
        }

        private void Frthflrbtn_Click(object sender, EventArgs e)
        {
            if (flr4img.Visibility == ViewStates.Invisible)
            {
                flr4img.Visibility = ViewStates.Visible;
                flr1img.Visibility = ViewStates.Invisible;
                mzznnimg.Visibility = ViewStates.Invisible;
                flr2img.Visibility = ViewStates.Invisible;
                flr3img.Visibility = ViewStates.Invisible;
            }
        }

        private void Backbtnbldngaoview_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BuildingOverview));
            this.StartActivity(intent);
        }
        
    }
}