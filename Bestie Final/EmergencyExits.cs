using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Bumptech.Glide;
using Com.Bumptech.Glide.Request.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Bestie_Final.BuildingSearch;

namespace Bestie_Final
{
    [Activity(Label = "EmergencyExits")]
    public class EmergencyExits : Activity
    {
        Button eebckbtn, frstflrEbtn, mzznneEbtn, scndflrEbtn, thrdflrEbtn, frthflrEbtn, rfdckEbtn;
        ImageView imgviewback, imgviewfront, wrnngimgview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.emergencyexits);
            // Create your application here

            eebckbtn = FindViewById<Button>(Resource.Id.BackEmergencyExits);
            frstflrEbtn = FindViewById<Button>(Resource.Id.frstfEButton);
            mzznneEbtn = FindViewById<Button>(Resource.Id.mzznnEButton);
            scndflrEbtn = FindViewById<Button>(Resource.Id.scndfEButton); 
            thrdflrEbtn = FindViewById<Button>(Resource.Id.thrdfEButton); 
            frthflrEbtn = FindViewById<Button>(Resource.Id.frthfEButton); 
            rfdckEbtn = FindViewById<Button>(Resource.Id.rfdckEButton);

            imgviewback = FindViewById<ImageView>(Resource.Id.EEImageViewBack);
            imgviewfront = FindViewById<ImageView>(Resource.Id.EEImageViewBack);

            Glide.With(this)
                .Load(Resource.Drawable.EExitLobby)
                .Into(new DrawableImageViewTarget(imgviewback));

            eebckbtn.Click += Eebckbtn_Click;
            frstflrEbtn.Click += FrstflrEbtn_Click;
            mzznneEbtn.Click += MzznneEbtn_Click;
            scndflrEbtn.Click += ScndflrEbtn_Click;
            thrdflrEbtn.Click += ThrdflrEbtn_Click;
            frthflrEbtn.Click += FrthflrEbtn_Click;
            rfdckEbtn.Click += RfdckEbtn_Click;
        }
       
        private void FrstflrEbtn_Click(object sender, EventArgs e)
        {
            Glide.With(this)
                .Load(Resource.Drawable.EExitLobby)                
                .Into(new DrawableImageViewTarget(imgviewfront));
        }

        private void MzznneEbtn_Click(object sender, EventArgs e)
        {
            Glide.With(this)
                .Load(Resource.Drawable.EExitMezzanine)
                .Into(new DrawableImageViewTarget(imgviewfront));
        }

        private void ScndflrEbtn_Click(object sender, EventArgs e)
        {
            Glide.With(this)
                .Load(Resource.Drawable.EExit2ndFloor)
                .Into(new DrawableImageViewTarget(imgviewfront));
        }

        private void ThrdflrEbtn_Click(object sender, EventArgs e)
        {
            Glide.With(this)
                .Load(Resource.Drawable.EExit3rdFloor)
                .Into(new DrawableImageViewTarget(imgviewfront));
        }

        private void FrthflrEbtn_Click(object sender, EventArgs e)
        {
            Glide.With(this)
                .Load(Resource.Drawable.EExit4thFloor)
                .Into(new DrawableImageViewTarget(imgviewfront));
        }

        private void RfdckEbtn_Click(object sender, EventArgs e)
        {
            Glide.With(this)
                .Load(Resource.Drawable.EExitRoofdeck)
                .Into(new DrawableImageViewTarget(imgviewfront));
        }


        private void Eebckbtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
            Finish();
        }
    }
}