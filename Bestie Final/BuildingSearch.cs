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
using Com.Bumptech.Glide.Load.Resource.Gif;
using System.Threading.Tasks;
using Java.Security;

namespace Bestie_Final
{
    [Activity(Label = "BuildingSearch")]
    public class BuildingSearch : Activity
    {
        Button bldngsrchbckbtn;
        private ImageView imageView, imageViewM, imageViewS, imageViewT, imageViewF, imageViewR;
        private Button startButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngsrch);

            string text = Intent.GetStringExtra("text");

            bldngsrchbckbtn = FindViewById<Button>(Resource.Id.BuildingSearchBackButton);
            bldngsrchbckbtn.Click += (sender, args) =>
            {
                // Start a new instance of the activity to reset it
                var intent = new Intent(this, typeof(MainActivity));
                intent.SetFlags(ActivityFlags.ClearTop | ActivityFlags.ClearTask | ActivityFlags.NewTask);
                StartActivity(intent);

                // Finish the current instance of the activity
                Finish();
            };

            imageView = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewFirst);
            imageViewM = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewMezzanine);
            imageViewS = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewSecondFloor);
            imageViewT = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewThirdFloor);
            imageViewF = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewFourthFloor);
            imageViewR = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewRoofdeck);

            startButton = FindViewById<Button>(Resource.Id.StartButtonGIF);

            
            //startButton.Click += (sender, arg) =>
            //{
            //    var drawable = imageView.Drawable;
            //    if (drawable is GifDrawable gifDrawable)
            //    {
            //        gifDrawable.Start();
            //    }

            //    drawable = imageViewM.Drawable;
            //    if (drawable is GifDrawable gifDrawableM)
            //    {
            //        gifDrawableM.Start();
            //    }

            //    drawable = imageViewS.Drawable;
            //    if (drawable is GifDrawable gifDrawableS)
            //    {
            //        gifDrawableS.Start();
            //    }

            //    drawable = imageViewT.Drawable;
            //    if (drawable is GifDrawable gifDrawableT)
            //    {
            //        gifDrawableT.Start();
            //    }

            //    drawable = imageViewF.Drawable;
            //    if (drawable is GifDrawable gifDrawableF)
            //    {
            //        gifDrawableF.Start();
            //    }

            //    drawable = imageViewR.Drawable;
            //    if (drawable is GifDrawable gifDrawableR)
            //    {
            //        gifDrawableR.Start();
            //    }
            //};

            startButton.Click += StartButton_Click;

            //Lobby

            if (text == "Admissions Office" || text == "admissions office" || text == "admisions office" || text == "ADMISSIONS OFFICE")
            {
                Glide.With(this)
                .Load(Resource.Drawable.AdmissionsOfficeGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
            else
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Alert");
                builder.SetMessage("Please enter a destination");
                builder.SetPositiveButton("OK", (dialog, which) =>
                {

                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();
                dialog.Show();
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

            if (text == "Library" || text == "library")
            {
                Glide.With(this)
                .Load(Resource.Drawable.LibraryGIF)
                .Into(new DrawableImageViewTarget(imageViewM));
            }

            //changed to communication from bookstore
            if (text == "Communication")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CommunicationGIF)
                .Into(new DrawableImageViewTarget(imageViewM));
            }

            if (text == "School Administrator")
            {
                Glide.With(this)
                .Load(Resource.Drawable.SchoolAdminGIF)
                .Into(new DrawableImageViewTarget(imageViewM));
            }

            //2nd Floor

            Task.Delay(16299).ContinueWith(t =>
            {
                var drawable = imageViewS.Drawable;
                if (drawable is GifDrawable gifDrawableS)
                {
                    gifDrawableS.Stop();
                }
            });

            if (text == "A201")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A201GIF)
                .Into(new DrawableImageViewTarget(imageViewS));
            }

            if (text == "A202")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A202GIF)
                .Into(new DrawableImageViewTarget(imageViewS));
            }

            if (text == "A203")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A203GIF)
                .Into(new DrawableImageViewTarget(imageViewS));
            }

            if (text == "A204")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A204GIF)
                .Into(new DrawableImageViewTarget(imageViewS));
            }

            if (text == "A205")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A205GIF)
                .Into(new DrawableImageViewTarget(imageViewS));
            }

            if (text == "A206")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A206GIF)
                .Into(new DrawableImageViewTarget(imageViewS));
            }

            if (text == "Female Toilet 2nd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToilet2ndFloorGIF)
                .Into(new DrawableImageViewTarget(imageViewS));
            }

            if (text == "Male Toilet 2nd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet2ndFloorGIF)
                .Into(new DrawableImageViewTarget(imageViewS));
            }

            //3rd Floor

            Task.Delay(15000).ContinueWith(t =>
            {
                var drawable = imageViewT.Drawable;
                if (drawable is GifDrawable gifDrawableT)
                {
                    gifDrawableT.Stop();
                }
            });

            if (text == "Computer Laboratory B")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabBGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            }

            if (text == "Computer Laboratory C")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabCGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            }

            if (text == "Computer Laboratory D")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabDGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            }

            if (text == "Computer Laboratory E")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabEGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            }

            if (text == "Computer Laboratory F")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabFGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            }

            if (text == "Male Toilet 3rd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet3rdFloorGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            }

            if (text == "Female Toilet 3rd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToilet3rdFloorGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            }

            //4th Floor

            Task.Delay(20000).ContinueWith(t =>
            {
                var drawable = imageViewF.Drawable;
                if (drawable is GifDrawable gifDrawableF)
                {
                    gifDrawableF.Stop();
                }
            });

            if (text == "A401")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A401GIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            }

            if (text == "A402")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A402GIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            }

            if (text == "A403")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A403GIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            }

            if (text == "Physics Laboratory")
            {
                Glide.With(this)
                .Load(Resource.Drawable.PhysicsLabGIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            }

            if (text == "Chemistry Laboratory")
            {
                Glide.With(this)
                .Load(Resource.Drawable.ChemLabGIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            }

            if (text == "Electronic Laboratory")
            {
                Glide.With(this)
                .Load(Resource.Drawable.ElectronicsLabGIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            }

            if (text == "Female Toilet 4th Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToilet4thFloorGIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            }

            if (text == "Male Toilet 4th Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet4thFloorGIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            }

            //Roofdeck

            //Task.Delay(250000).ContinueWith(t =>
            //{
            //    var drawable = imageViewR.Drawable;
            //    if (drawable is GifDrawable gifDrawableR)
            //    {
            //        gifDrawableR.Stop();
            //    }
            //});

            if (text == "Roofdeck")
            {
                Glide.With(this)
                .Load(Resource.Drawable.RoofdeckGIF)
                .Into(new DrawableImageViewTarget(imageViewR));
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            var drawable = imageView.Drawable as GifDrawable;
            var drawableM = imageViewM.Drawable as GifDrawable;
            var drawableS = imageViewS.Drawable as GifDrawable;
            var drawableT = imageViewT.Drawable as GifDrawable;
            var drawableF = imageViewF.Drawable as GifDrawable;
            var drawableR = imageViewR.Drawable as GifDrawable;
            drawable?.Start();
            drawableM?.Start();
            drawableS?.Start();
            drawableT?.Start();
            drawableF?.Start();
            drawableR?.Start();


        }

        public override void OnBackPressed()
        {
            bldngsrchbckbtn = FindViewById<Button>(Resource.Id.BuildingSearchBackButton);
            bldngsrchbckbtn.PerformClick();
        }

    }
}