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
using static Android.Renderscripts.ScriptGroup;
using System.ComponentModel.Design;
using Java.Lang.Annotation;

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

            //Mezzanine


            Task.Delay(11300).ContinueWith(t =>
            {
                var drawable = imageViewM.Drawable;
                if (drawable is GifDrawable gifDrawableM)
                {
                    gifDrawableM.Stop();
                }
            });

            //2nd Floor

            Task.Delay(16299).ContinueWith(t =>
            {
                var drawable = imageViewS.Drawable;
                if (drawable is GifDrawable gifDrawableS)
                {
                    gifDrawableS.Stop();
                }
            });

            //3rd Floor

            Task.Delay(15000).ContinueWith(t =>
            {
                var drawable = imageViewT.Drawable;
                if (drawable is GifDrawable gifDrawableT)
                {
                    gifDrawableT.Stop();
                }
            });

            Task.Delay(20000).ContinueWith(t =>
            {
                var drawable = imageViewF.Drawable;
                if (drawable is GifDrawable gifDrawableF)
                {
                    gifDrawableF.Stop();
                }
            });

            if (text == "Admissions Office" || text == "admissions office" || text == "admisions office" || text == "ADMISSIONS OFFICE")
            {
                //Lobby
                Glide.With(this)
                .Load(Resource.Drawable.AdmissionsOfficeGIF)
                .Into(new DrawableImageViewTarget(imageView));
            } else if (text == "Cashier" || text == "cashier" || text == "CASHIER" || text == "cahsier")
            {
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.CashierGIF)
                    .Into(new DrawableImageViewTarget(imageView));
                }
            } else if (text == "Computer Laboratory A" || text == "computer laboratory a" || text == "complab a" || text == "comlaba" || text == "complaboratory a")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabAGIF)
                .Into(new DrawableImageViewTarget(imageView));
            } else if (text == "Computer Laboratory A" || text == "computer laboratory a" || text == "complab a" || text == "comlaba" || text == "complaboratory a")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabAGIF)
                .Into(new DrawableImageViewTarget(imageView));
            } else if (text == "Deputy School Administrator")
            {
                Glide.With(this)
                .Load(Resource.Drawable.DeputyGIF)
                .Into(new DrawableImageViewTarget(imageView));
            } else if (text == "Registrar")
            {
                Glide.With(this)
                .Load(Resource.Drawable.RegistrarGIF)
                .Into(new DrawableImageViewTarget(imageView));
            } else if (text == "Female Toilet Lobby")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToiletLobbyGIF)
                .Into(new DrawableImageViewTarget(imageView));
            } else if (text == "Male Toilet Lobby")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToiletLobbyGIF)
                .Into(new DrawableImageViewTarget(imageView));
            } else if (text == "Library" || text == "library")
            {
                //Mezzanine               
                Glide.With(this)
                .Load(Resource.Drawable.LibraryGIF)
                .Into(new DrawableImageViewTarget(imageViewM));
            } else if (text == "Communication")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CommunicationGIF)
                .Into(new DrawableImageViewTarget(imageViewM));
            } else if (text == "School Administrator")
            {
                Glide.With(this)
                .Load(Resource.Drawable.SchoolAdminGIF)
                .Into(new DrawableImageViewTarget(imageViewM));
            } else if (text == "A201")
            {
                //2nd Floor
                Glide.With(this)
                .Load(Resource.Drawable.A201GIF)
                .Into(new DrawableImageViewTarget(imageViewS));
            } else if (text == "A202")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A202GIF)
                    .Into(new DrawableImageViewTarget(imageViewS));
                } else if (text == "A203")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A203GIF)
                .Into(new DrawableImageViewTarget(imageViewS));
            } else if (text == "A204")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A204GIF)
                    .Into(new DrawableImageViewTarget(imageViewS));
                } else if (text == "A205")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A205GIF)
                    .Into(new DrawableImageViewTarget(imageViewS));
                } else if (text == "A206")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A206GIF)
                .Into(new DrawableImageViewTarget(imageViewS));
            } else if (text == "Female Toilet 2nd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToilet2ndFloorGIF)
                .Into(new DrawableImageViewTarget(imageViewS));
            } else if (text == "Male Toilet 2nd Floor")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.MaleToilet2ndFloorGIF)
                    .Into(new DrawableImageViewTarget(imageViewS));
                } else if (text == "Computer Laboratory B")
                {
                //3rd Floor
                    Glide.With(this)
                    .Load(Resource.Drawable.CompLabBGIF)
                    .Into(new DrawableImageViewTarget(imageViewT));
                } else if (text == "Computer Laboratory C")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabCGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            } else if (text == "Computer Laboratory D")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabDGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            } else if (text == "Computer Laboratory D")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabDGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            } else if (text == "Computer Laboratory E")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.CompLabEGIF)
                    .Into(new DrawableImageViewTarget(imageViewT));
                } else if (text == "Computer Laboratory F")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabFGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            } else if (text == "Male Toilet 3rd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet3rdFloorGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            } else if (text == "Female Toilet 3rd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToilet3rdFloorGIF)
                .Into(new DrawableImageViewTarget(imageViewT));
            } else if (text == "A401")
            {
                //Fourth Floor
                Glide.With(this)
                .Load(Resource.Drawable.A401GIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            } else if (text == "A402")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A402GIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            } else if (text == "A403")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A403GIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            } else if (text == "Physics Laboratory")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.PhysicsLabGIF)
                    .Into(new DrawableImageViewTarget(imageViewF));
                } else if (text == "Chemistry Laboratory")
            {
                Glide.With(this)
                .Load(Resource.Drawable.ChemLabGIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            } else if (text == "Electronic Laboratory")
            {
                Glide.With(this)
                .Load(Resource.Drawable.ElectronicsLabGIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            } else if (text == "Female Toilet 4th Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToilet4thFloorGIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            } else if (text == "Male Toilet 4th Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet4thFloorGIF)
                .Into(new DrawableImageViewTarget(imageViewF));
            } else if (text == "Roofdeck")
            {
                //Roofdeck
                Glide.With(this)
                .Load(Resource.Drawable.RoofdeckGIF)
                .Into(new DrawableImageViewTarget(imageViewR));
            } else
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("NOTICE:");
                builder.SetMessage("The place you searched for doesn't exist!");
                builder.SetPositiveButton("OK", (dialog, which) =>
                {
                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();
                dialog.Show();
            }

        }        
        
        //private void StartButton_Click(object sender, EventArgs e)
        //{

        //    var drawable = imageView.Drawable as GifDrawable;
        //    var drawableM = imageViewM.Drawable as GifDrawable;
        //    var drawableS = imageViewS.Drawable as GifDrawable;
        //    var drawableT = imageViewT.Drawable as GifDrawable;
        //    var drawableF = imageViewF.Drawable as GifDrawable;
        //    var drawableR = imageViewR.Drawable as GifDrawable;
        //    drawable?.Start();
        //    drawableM?.Start();
        //    drawableS?.Start();
        //    drawableT?.Start();
        //    drawableF?.Start();
        //    drawableR?.Start();


        //}


        public override void OnBackPressed()
        {
            bldngsrchbckbtn = FindViewById<Button>(Resource.Id.BuildingSearchBackButton);
            bldngsrchbckbtn.PerformClick();
        }

    }
}