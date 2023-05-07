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
using Com.Bumptech.Glide.Request;
using Com.Bumptech.Glide.Load.Engine;
using Com.Bumptech.Glide.Load;

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
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.ClearTask | ActivityFlags.NewTask | ActivityFlags.TaskOnHome);
                StartActivity(intent);

                // Finish the current instance of the activity
                FinishAffinity();            
            };

            imageView = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewFirst);
            imageViewM = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewMezzanine);
            imageViewS = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewSecondFloor);
            imageViewT = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewThirdFloor);
            imageViewF = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewFourthFloor);
            imageViewR = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewRoofdeck);

            startButton = FindViewById<Button>(Resource.Id.StartButtonGIF);

            if (text == "Admissions Office" || text == "admissions office" || text == "admisions office" || text == "ADMISSIONS OFFICE")
            {
                //Lobby
                Glide.With(this)
                .Load(Resource.Drawable.AdmissionsOfficeGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
            else if (text == "Cashier" || text == "cashier" || text == "CASHIER" || text == "cahsier")
            {
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.CashierGIF)
                    .Into(new DrawableImageViewTarget(imageView));
                }
            }
            else if (text == "Computer Laboratory A" || text == "computer laboratory a" || text == "complab a" || text == "comlaba" || text == "complaboratory a")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabAGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
            else if (text == "Computer Laboratory A" || text == "computer laboratory a" || text == "complab a" || text == "comlaba" || text == "complaboratory a")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabAGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
            else if (text == "Deputy School Administrator")
            {
                Glide.With(this)
                .Load(Resource.Drawable.DeputyGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
            else if (text == "Registrar")
            {
                Glide.With(this)
                .Load(Resource.Drawable.RegistrarGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
            else if (text == "Female Toilet Lobby")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToiletLobbyGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
            else if (text == "Male Toilet Lobby")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToiletLobbyGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
            else if (text == "Library" || text == "library")
            {
                //Mezzanine               
                Glide.With(this)
                .Load(Resource.Drawable.LibraryGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewM));                
            }
            else if (text == "Communication")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CommunicationGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewM));
            }
            else if (text == "School Administrator")
            {
                Glide.With(this)
                .Load(Resource.Drawable.SchoolAdminGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewM));
            }
            else if (text == "A201")
            {
                //2nd Floor
                Glide.With(this)
                .Load(Resource.Drawable.A201GIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewS));
            }
            else if (text == "A202")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A202GIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewS));
            }
            else if (text == "A203")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A203GIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewS));
            }
            else if (text == "A204")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A204GIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewS));
            }
            else if (text == "A205")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A205GIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewS));
            }
            else if (text == "A206")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A206GIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewS));
            }
            else if (text == "Female Toilet 2nd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToilet2ndFloorGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewS));
            }
            else if (text == "Male Toilet 2nd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet2ndFloorGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewS));
            }
            else if (text == "Computer Laboratory B")
            {
                //3rd Floor
                Glide.With(this)
                .Load(Resource.Drawable.CompLabBGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewT));
            }
            else if (text == "Computer Laboratory C")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabCGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewT));
            }
            else if (text == "Computer Laboratory D")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabDGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewT));
            }
            else if (text == "Computer Laboratory D")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabDGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewT));
            }
            else if (text == "Computer Laboratory E")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabEGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewT));
            }
            else if (text == "Computer Laboratory F")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CompLabFGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewT));
            }
            else if (text == "Male Toilet 3rd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet3rdFloorGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewT));
            }
            else if (text == "Female Toilet 3rd Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToilet3rdFloorGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewT));
            }
            else if (text == "A401")
            {
                //Fourth Floor
                Glide.With(this)
                .Load(Resource.Drawable.A401GIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewF));
            }
            else if (text == "A402")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A402GIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewF));
            }
            else if (text == "A403")
            {
                Glide.With(this)
                .Load(Resource.Drawable.A403GIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewF));
            }
            else if (text == "Physics Laboratory")
            {
                Glide.With(this)
                .Load(Resource.Drawable.PhysicsLabGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewF));
            }
            else if (text == "Chemistry Laboratory")
            {
                Glide.With(this)
                .Load(Resource.Drawable.ChemLabGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewF));
            }
            else if (text == "Electronic Laboratory")
            {
                Glide.With(this)
                .Load(Resource.Drawable.ElectronicsLabGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewF));
            }
            else if (text == "Female Toilet 4th Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemaleToilet4thFloorGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewF));
            }
            else if (text == "Male Toilet 4th Floor")
            {
                Glide.With(this)
                .Load(Resource.Drawable.MaleToilet4thFloorGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewF));
            }
            else if (text == "Roofdeck")
            {
                //Roofdeck
                Glide.With(this)
                .Load(Resource.Drawable.RoofdeckGIF)
                .Listener(new MyRequestListener())
                .Into(new DrawableImageViewTarget(imageViewR));
            }
            else
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("NOTICE:");
                builder.SetMessage("The place you searched for doesn't exist!");
                builder.SetPositiveButton("OK", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(MainActivity));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivity(intent);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();
                dialog.Show();
            }

        }
        public class MyRequestListener : Java.Lang.Object, IRequestListener
        {
            private bool mActivityPaused = false;

            public bool OnLoadFailed(GlideException p0, Java.Lang.Object p1, Com.Bumptech.Glide.Request.Target.ITarget p2, bool p3)
            {
                return true;
            }

            public bool OnResourceReady(Java.Lang.Object p0, Java.Lang.Object p1, Com.Bumptech.Glide.Request.Target.ITarget p2, DataSource p3, bool p4)
            {
                if (p0 is GifDrawable)
                {
                    GifDrawable gifDrawable = (GifDrawable)p0;

                    if (!mActivityPaused)
                    {
                        gifDrawable.SetLoopCount(1);
                    }
                    else
                    {
                        gifDrawable.Start();
                    }
                }

                return false;
            }

            public void OnActivityPaused(Activity activity)
            {
                mActivityPaused = true;
            }

            public void OnActivityResumed(Activity activity)
            {
                mActivityPaused = false;
            }
        }
    }
}