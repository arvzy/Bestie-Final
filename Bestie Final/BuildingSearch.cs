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
using Com.Bumptech.Glide;
using Com.Bumptech.Glide.Request.Target;

namespace Bestie_Final
{
    [Activity(Label = "BuildingSearch")]
    public class BuildingSearch : Activity
    {
        Button bldngsrchbckbtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngsrch);
            var handler = new Handler();            
            string text = Intent.GetStringExtra("text");

            bldngsrchbckbtn = FindViewById<Button>(Resource.Id.BuildingSearchBackButton);
            bldngsrchbckbtn.Click += Bldngsrchbckbtn_Click;

            var imageView = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewFirst);
            var imageView2 = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewSecond);
            var imageView3 = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewThird);
            var imageView4 = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewFourth);
            var imageView5 = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewFifth);
            var imageView6 = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewSixth);

            //Lobby
           
            if (text == "Admissions Office")
            {
                Glide.With(this)
                .Load(Resource.Drawable.AdmissionsOfficeGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Cashier")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CashierGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Computer Laboratory A")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabAGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Deputy School Administrator")
            {
                Glide.With(this)
                .Load(Resource.Drawable.DeputyGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Registrar")
            {
                Glide.With(this)
                .Load(Resource.Drawable.RegistrarGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Female Toilet Lobby")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToiletLobbyGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Male Toilet Lobby")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToiletLobbyGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            //Mezzanine

            if (text == "Library")
            {
                Glide.With(this)
                .Load(Resource.Drawable.LibraryGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            //changed to communication from bookstore
            if (text == "Communication")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CommunicationGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "School Administrator")
            {
                Glide.With(this)
                .Load(Resource.Drawable.SchoolAdminGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            //2nd Floor

            if (text == "A201")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A201GIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "A202")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A202GIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "A203")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A203GIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "A204")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A204GIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "A205")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A205GIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "A206")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A206GIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Female Toilet 2nd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToilet2ndFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Male Toilet 2nd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet2ndFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            //3rd Floor
            if (text == "Computer Laboratory B")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet2ndFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Computer Laboratory C")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet2ndFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Computer Laboratory D")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet2ndFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Computer Laboratory E")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet2ndFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Computer Laboratory F")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet2ndFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Male Toilet 3rd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet2ndFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Female Toilet 3rd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet2ndFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            //4th Floor
            if (text == "A401")
            {
                imageView.SetImageResource(Resource.Drawable.A401_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.A401_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.A401_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.A401_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.A401_5);
                }, 12000);
            }

            if (text == "A402")
            {
                imageView.SetImageResource(Resource.Drawable.A402_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.A402_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.A402_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.A402_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.A402_5);
                }, 12000);
            }

            if (text == "A403")
            {
                imageView.SetImageResource(Resource.Drawable.A403_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.A403_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.A403_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.A403_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.A403_5);
                }, 12000);
            }

            if (text == "Physics Laboratory")
            {
                imageView.SetImageResource(Resource.Drawable.PhysicsLab_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.PhysicsLab_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.PhysicsLab_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.PhysicsLab_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.PhysicsLab_5);
                }, 12000);
            }

            if (text == "Chemistry Laboratory")
            {
                imageView.SetImageResource(Resource.Drawable.ChemLab_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.ChemLab_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.ChemLab_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.ChemLab_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.ChemLab_5);
                }, 12000);
            }

            if (text == "Electronic Laboratory")
            {
                imageView.SetImageResource(Resource.Drawable.ElectronicLab_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.ElectronicLab_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.ElectronicLab_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.ElectronicLab_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.ElectronicLab_5);
                }, 12000);
            }

            if (text == "Female Toilet 4th Floor")
            {
                imageView.SetImageResource(Resource.Drawable.FemaleToilet4thFloor_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.FemaleToilet4thFloor_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.FemaleToilet4thFloor_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.FemaleToilet4thFloor_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.FemaleToilet4thFloor_5);
                }, 12000);
            }

            if (text == "Male Toilet 4th Floor")
            {
                imageView.SetImageResource(Resource.Drawable.MaleToilet4thFloor_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.MaleToilet4thFloor_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.MaleToilet4thFloor_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.MaleToilet4thFloor_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.MaleToilet4thFloor_5);
                }, 12000);
            }

            //Roofdeck
            if (text == "Roofdeck")
            {
                imageView.SetImageResource(Resource.Drawable.Roofdeck_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.Roofdeck_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.Roofdeck_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.Roofdeck_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.Roofdeck_5);
                }, 12000);
                handler.PostDelayed(() =>
                {
                    imageView6.SetImageResource(Resource.Drawable.Roofdeck_6);
                }, 15000);
            }
        }

        private void Bldngsrchbckbtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
        }
    }
}