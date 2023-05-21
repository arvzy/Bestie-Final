using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
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
        Button eebckbtn, frstflrEbtn, mzznneEbtn, scndflrEbtn, thrdflrEbtn, frthflrEbtn, rfdckEbtn, hmeEbtn;
        ImageView imgviewback, imgviewfront, wrnngimgview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.emergencyexits);
            // Create your application here

            eebckbtn = FindViewById<Button>(Resource.Id.BackEmergencyExits);
            hmeEbtn = FindViewById<Button>(Resource.Id.homeE);
            frstflrEbtn = FindViewById<Button>(Resource.Id.frstfEButton);
            mzznneEbtn = FindViewById<Button>(Resource.Id.mzznnEButton);
            scndflrEbtn = FindViewById<Button>(Resource.Id.scndfEButton); 
            thrdflrEbtn = FindViewById<Button>(Resource.Id.thrdfEButton); 
            frthflrEbtn = FindViewById<Button>(Resource.Id.frthfEButton); 
            rfdckEbtn = FindViewById<Button>(Resource.Id.rfdckEButton);

            imgviewback = FindViewById<ImageView>(Resource.Id.EEImageViewBack);
            imgviewfront = FindViewById<ImageView>(Resource.Id.EEImageViewBack);
            wrnngimgview = FindViewById<ImageView>(Resource.Id.warningImageView);

            Glide.With(this)
                .Load(Resource.Drawable.FireExitLobby)
                .Into(new DrawableImageViewTarget(imgviewback));

            Glide.With(this)
                .Load(Resource.Drawable.Warning)
                .Into(new DrawableImageViewTarget(wrnngimgview));

            eebckbtn.Click += Eebckbtn_Click;
            hmeEbtn.Click += HmeEbtn_Click;
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
                .Load(Resource.Drawable.FireExitLobby)                
                .Into(new DrawableImageViewTarget(imgviewfront));
        }

        private void MzznneEbtn_Click(object sender, EventArgs e)
        {
            Glide.With(this)
                .Load(Resource.Drawable.FireExitMezzanine)
                .Into(new DrawableImageViewTarget(imgviewfront));
        }

        private void ScndflrEbtn_Click(object sender, EventArgs e)
        {
            Glide.With(this)
                .Load(Resource.Drawable.FireExit2ndfloor)
                .Into(new DrawableImageViewTarget(imgviewfront));
        }

        private void ThrdflrEbtn_Click(object sender, EventArgs e)
        {
            Glide.With(this)
                .Load(Resource.Drawable.FireExit3rdfloor)
                .Into(new DrawableImageViewTarget(imgviewfront));
        }

        private void FrthflrEbtn_Click(object sender, EventArgs e)
        {
            Glide.With(this)
                .Load(Resource.Drawable.FireExit4thfloor)
                .Into(new DrawableImageViewTarget(imgviewfront));
        }

        private void RfdckEbtn_Click(object sender, EventArgs e)
        {
            Glide.With(this)
                .Load(Resource.Drawable.FireExitRoofDeck)
                .Into(new DrawableImageViewTarget(imgviewfront));
        }


        private void HmeEbtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
            Finish();

            Button button = (Button)sender;
            Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
            button.StartAnimation(animation);
        }

        private void Eebckbtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
            Finish();

            Button button = (Button)sender;
            Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
            button.StartAnimation(animation);
        }
    }
}