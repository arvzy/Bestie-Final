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

            string text = Intent.GetStringExtra("text");

            bldngsrchbckbtn = FindViewById<Button>(Resource.Id.BuildingSearchBackButton);
            bldngsrchbckbtn.Click += Bldngsrchbckbtn_Click;

            var imageView = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewFirst);

            //Lobby

            if (text == "Admissions Office" || text == "admissions office" || text == "admisions office" || text == "ADMISSIONS OFFICE")
            {
                Glide.With(this)
                .Load(Resource.Drawable.AdmissionsOfficeGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Cashier" || text == "cashier" || text == "CASHIER" || text == "cahsier")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CashierGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Computer Laboratory A" || text == "computer laboratory a" || text == "complab a" || text == "comlaba" || text == "complaboratory a")
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
                .Load(Resource.Drawable.CompLabBGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Computer Laboratory C")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabCGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Computer Laboratory D")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabDGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Computer Laboratory E")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabEGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Computer Laboratory F")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabFGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Male Toilet 3rd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet3rdFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Female Toilet 3rd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToilet3rdFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            //4th Floor
            if (text == "A401")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A401GIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "A402")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A402GIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "A403")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A403GIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Physics Laboratory")
            {
                Glide.With(this)
                .Load(Resource.Drawable.PhysicsLabGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Chemistry Laboratory")
            {
                Glide.With(this)
                .Load(Resource.Drawable.ChemLabGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Electronic Laboratory")
            {
                Glide.With(this)
                .Load(Resource.Drawable.ElectronicsLabGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Female Toilet 4th Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToilet4thFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            if (text == "Male Toilet 4th Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet4thFloorGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }

            //Roofdeck
            if (text == "Roofdeck")
            {
                Glide.With(this)
                .Load(Resource.Drawable.RoofdeckGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
        }

        private void Bldngsrchbckbtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
        }
    }
}