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
using Android.Content.PM;
using Android.Views.Animations;

namespace Bestie_Final
{
    [Activity(Label = "BuildingSearch")]
    public class BuildingSearch : Activity
    {
        Button bldngsrchbckbtn, frstflrbtn, mzznnbtn, scndflrbtn, thrdflrbtn, frthflrbtn, rfdckbtn, homebtn;
        private ImageView imageView, imageViewM, imageViewS, imageViewT, imageViewF, imageViewR;
        private DrawableImageViewTarget imageViewTarget;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngsrch);

            bool isLibraryGifPlaying = false;

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

            imageViewTarget = new DrawableImageViewTarget(imageView);



            frstflrbtn = FindViewById<Button>(Resource.Id.frstfButton);
            mzznnbtn = FindViewById<Button>(Resource.Id.mzznnButton);
            scndflrbtn = FindViewById<Button>(Resource.Id.scndfButton);
            thrdflrbtn = FindViewById<Button>(Resource.Id.thrdfButton);
            frthflrbtn = FindViewById<Button>(Resource.Id.frthfButton);
            rfdckbtn = FindViewById<Button>(Resource.Id.rfdckButton);

            if (text == "Admissions Office" || text == "admissions office" || text == "admisions office" || text == "ADMISSIONS OFFICE")
            {
                //Lobby
                Glide.With(this)
                .Load(Resource.Drawable.AdmissionsGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
            else if (text == "Cashier" || text == "cashier" || text == "CASHIER" || text == "cahsier")
            {
                Glide.With(this)
                .Load(Resource.Drawable.CashierGIF)
                .Into(new DrawableImageViewTarget(imageView));
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
            else if (text == "Deputy School Administrator" || text == "deputy school administrator" || text == "deputyschooladministrator" || text == "deputy")
            {
                Glide.With(this)
                .Load(Resource.Drawable.DeputyGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
            else if (text == "Registrar" || text == "registrar")
            {
                Glide.With(this)
                .Load(Resource.Drawable.RegGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
            else if (text == "Female Toilet Lobby" || text == "female toilet lobby" || text == "femaletoiletlobby")
            {
                Glide.With(this)
                .Load(Resource.Drawable.FemToiletLobbyGIF)
                .Into(new DrawableImageViewTarget(imageView));
            }
            else if (text == "Male Toilet Lobby" || text == "male toilet lobby" || text == "maletoiletlobby")
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

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                }
                                    
                    frstflrbtn.Click += (sender, args) =>
                    {
                         if (imageViewM.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                            {
                                Glide.With(this)
                                    .Load(Resource.Drawable.Library1GIF)
                                    .Into(new DrawableImageViewTarget(imageViewR));

                                Button button = (Button)sender;
                                Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                                button.StartAnimation(animation);
                         }                       
                    };

                    mzznnbtn.Click += (sender, args) =>
                    {

                        if (imageViewM.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                        {
                            Glide.With(this)
                                .Load(Resource.Drawable.Library2GIF)
                                .Into(new DrawableImageViewTarget(imageViewR));

                            Button button = (Button)sender;
                            Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                            button.StartAnimation(animation);
                        }
                    };
                }
                else if (text == "Communication" || text == "communication")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.CommunicationGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewM));


                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                }

                    frstflrbtn.Click += (sender, args) =>
                    {
                        if (imageViewM.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                        {
                            Glide.With(this)
                                .Load(Resource.Drawable.Communication1GIF)
                                .Into(new DrawableImageViewTarget(imageViewR));

                            Button button = (Button)sender;
                            Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                            button.StartAnimation(animation);
                        }
                    };

                    mzznnbtn.Click += (sender, args) =>
                    {

                        if (imageViewM.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                        {
                            Glide.With(this)
                                .Load(Resource.Drawable.Communication2GIF)
                                .Into(new DrawableImageViewTarget(imageViewR));

                            Button button = (Button)sender;
                            Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                            button.StartAnimation(animation);
                        }
                    };
                }
                else if (text == "School Administrator" || text == "school administrator" || text == "schooladministrator" || text == "schooladmin" || text == "admin")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.SchoolAdminGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewM));

                    if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                    {
                        frstflrbtn.Visibility = ViewStates.Visible;
                        mzznnbtn.Visibility = ViewStates.Visible;
                    }

                    frstflrbtn.Click += (sender, args) =>
                    {
                        if (imageViewM.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                        {
                            Glide.With(this)
                                .Load(Resource.Drawable.SchoolAdmin1GIF)
                                .Into(new DrawableImageViewTarget(imageViewR));

                            Button button = (Button)sender;
                            Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                            button.StartAnimation(animation);
                        }
                    };

                    mzznnbtn.Click += (sender, args) =>
                    {

                        if (imageViewM.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                        {
                            Glide.With(this)
                                .Load(Resource.Drawable.SchoolAdmin2GIF)
                                .Into(new DrawableImageViewTarget(imageViewR));

                            Button button = (Button)sender;
                            Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                            button.StartAnimation(animation);
                        }
                    };
                }
                else if (text == "201")
                {
                    //2nd Floor
                    Glide.With(this)
                    .Load(Resource.Drawable.A201FullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewS));

                    if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                    {
                        frstflrbtn.Visibility = ViewStates.Visible;
                        mzznnbtn.Visibility = ViewStates.Visible;
                        scndflrbtn.Visibility = ViewStates.Visible;
                    }

                    frstflrbtn.Click += (sender, args) =>
                    {
                        if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                        {
                            Glide.With(this)
                                .Load(Resource.Drawable.A201_1_GIF)
                                .Into(new DrawableImageViewTarget(imageViewR));

                            Button button = (Button)sender;
                            Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                            button.StartAnimation(animation);
                        }
                    };

                    mzznnbtn.Click += (sender, args) =>
                    {

                        if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                        {
                            Glide.With(this)
                                .Load(Resource.Drawable.A201_2_GIF)
                                .Into(new DrawableImageViewTarget(imageViewR));

                            Button button = (Button)sender;
                            Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                            button.StartAnimation(animation);
                        }
                    };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A201_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "202")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A202FullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewS));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A202_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A202_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A202_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "203")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A203FullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewS));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A203_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A203_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A203_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "204")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A204FullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewS));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A204_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A204_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A204_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "205")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A205FullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewS));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A205_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A205_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A205_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "206")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A206FullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewS));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A206_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A206_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A206_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "Female Toilet 2nd Floor" || text == "female toilet 2nd floor" || text == "femaletoilet2ndfloor" || text == "femaletoiletsecondfloor" || text == "female toilet second floor")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.FemToilet2ndFloorFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewS));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.FemToilet2nd_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.FemToilet2nd_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.FemToilet2nd_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "Male Toilet 2nd Floor" || text == "male toilet 2nd floor" || text == "maletoilet2ndfloor" || text == "maletoiletsecondfloor" || text == "male toilet second floor")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.MaleToilet2ndFloorFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewS));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.MaleToilet2nd_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.MaleToilet2nd_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewS.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.MaleToilet2nd_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "Computer Laboratory B" || text == "computer laboratory b" || text == "complab b" || text == "comlabb" || text == "complaboratory b")
                {
                    //3rd Floor
                    Glide.With(this)
                    .Load(Resource.Drawable.CompLabBFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewT));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabB1GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabB2GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabB3GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabB4GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "Computer Laboratory C" || text == "computer laboratory c" || text == "complab c" || text == "comlabc" || text == "complaboratory c")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.CompLabCFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewT));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabC1GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabC2GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabC3GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabC4GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
            }
                else if (text == "Computer Laboratory D" || text == "computer laboratory d" || text == "complab d" || text == "comlabd" || text == "complaboratory d")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.CompLabDFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewT));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabD1GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabD2GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabD3GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabD4GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
            }     
                else if (text == "Computer Laboratory E" || text == "computer laboratory e" || text == "complab e" || text == "comlabe" || text == "complaboratory e")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.CompLabEFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewT));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabE1GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabE2GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabE3GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabE4GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
            }
                else if (text == "Computer Laboratory F" || text == "computer laboratory f" || text == "complab f" || text == "comlabf" || text == "complaboratory f")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.CompLabFFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewT));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabF1GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabF2GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabF3GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.CompLabF4GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
            }
                else if (text == "Male Toilet 3rd Floor" || text == "male toilet 3rd floor" || text == "maletoilet3rdfloor" || text == "maletoiletthirdfloor" || text == "male toilet third floor")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.MaleToilet3rdFloorFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewT));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.MaleToilet3rd_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.MaleToilet3rd_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.MaleToilet3rd_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.MaleToilet3rd_4_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
            }
                else if (text == "Female Toilet 3rd Floor" || text == "female toilet 3rd floor" || text == "femaletoilet3rdfloor" || text == "femaletoiletthirdfloor" || text == "female toilet third floor")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.FemToilet3rdFloorFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewT));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.FemToilet3rd_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.FemToilet3rd_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.FemToilet3rd_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewT.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.FemToilet3rd_4_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }       
                else if (text == "401")
                {
                    //Fourth Floor
                    Glide.With(this)
                    .Load(Resource.Drawable.A401FullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewF));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                    frthflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A401_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A401_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A401_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A401_4_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                frthflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A401_5_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "402")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A402FullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewF));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                    frthflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A402_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A402_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A402_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A402_4_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                frthflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A402_5_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "403")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A403FullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewF));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                    frthflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A403_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A403_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A403_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A403_4_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                frthflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A403_5_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "Physics Laboratory" || text == "physicslaboratory" || text == "physics laboratory" || text == "physicslab" || text == "physics" || text == "physlab")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A405PhysLabFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewF));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                    frthflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A405PhysLab_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A405PhysLab_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A405PhysLab_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A405PhysLab_4_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                frthflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A405PhysLab_5_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "Chemistry Laboratory" || text == "chemistrylaboratory" || text == "chemistry laboratory" || text == "chemistrylab" || text == "chemistry" || text == "chemlab")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A406ChemLabFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewF));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                    frthflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A406ChemLab_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A406ChemLab_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A406ChemLab_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A406ChemLab_4_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                frthflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A406ChemLab_5_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "Electronic Laboratory" || text == "electronicslaboratory" || text == "electronics laboratory" || text == "electronicslab" || text == "electronics" || text == "eleclab")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.A404ElecLabFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewF));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                    frthflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A404ElecLab_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A404ElecLab_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A404ElecLab_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A404ElecLab_4_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                frthflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.A404ElecLab_5_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "Female Toilet 4th Floor" || text == "female toilet 4th floor" || text == "femaletoilet4thfloor" || text == "femaletoiletfourthfloor" || text == "female toilet fourth floor")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.FemToilet4thFloorFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewF));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                    frthflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.FemToilet4th_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.FemToilet4th_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.FemToilet4th_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.FemToilet4th_4_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                frthflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.FemToilet4th_5_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }        
                else if (text == "Male Toilet 4th Floor" || text == "male toilet 4th floor" || text == "maletoilet4thfloor" || text == "maletoiletfourthfloor" || text == "male toilet fourth floor")
                {
                    Glide.With(this)
                    .Load(Resource.Drawable.MaleToilet4thFloorFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewF));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                    frthflrbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.MaleToilet4th_1_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.MaleToilet4th_2_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.MaleToilet4th_3_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.MaleToilet4th_4_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                frthflrbtn.Click += (sender, args) =>
                {
                    if (imageViewF.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.MaleToilet4th_5_GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else if (text == "Roofdeck" || text == "roofdeck" || text == "roof deck" || text == "roof" || text == "rooftop" || text == "roof top" || text == "Rooftop")
                {
                    //Roofdeck
                    Glide.With(this)
                    .Load(Resource.Drawable.RoofdeckFullGIF)
                    .Listener(new MyRequestListener())
                    .Into(new DrawableImageViewTarget(imageViewR));

                if (frstflrbtn.Visibility == ViewStates.Gone && mzznnbtn.Visibility == ViewStates.Gone && scndflrbtn.Visibility == ViewStates.Gone && thrdflrbtn.Visibility == ViewStates.Gone && frthflrbtn.Visibility == ViewStates.Gone && rfdckbtn.Visibility == ViewStates.Gone)
                {
                    frstflrbtn.Visibility = ViewStates.Visible;
                    mzznnbtn.Visibility = ViewStates.Visible;
                    scndflrbtn.Visibility = ViewStates.Visible;
                    thrdflrbtn.Visibility = ViewStates.Visible;
                    frthflrbtn.Visibility = ViewStates.Visible;
                    rfdckbtn.Visibility = ViewStates.Visible;
                }

                frstflrbtn.Click += (sender, args) =>
                {
                    if (imageViewR.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.Roofdeck1GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                mzznnbtn.Click += (sender, args) =>
                {

                    if (imageViewR.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.Roofdeck2GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                scndflrbtn.Click += (sender, args) =>
                {
                    if (imageViewR.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.Roofdeck3GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                thrdflrbtn.Click += (sender, args) =>
                {
                    if (imageViewR.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.Roofdeck4GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                frthflrbtn.Click += (sender, args) =>
                {
                    if (imageViewR.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.Roofdeck5GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };

                rfdckbtn.Click += (sender, args) =>
                {
                    if (imageViewR.Drawable is GifDrawable gifDrawable && !gifDrawable.IsRunning)
                    {
                        Glide.With(this)
                            .Load(Resource.Drawable.Roofdeck6GIF)
                            .Into(new DrawableImageViewTarget(imageViewR));

                        Button button = (Button)sender;
                        Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
                        button.StartAnimation(animation);
                    }
                };
                }
                else
                {
                    AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                    builder.SetTitle("Oops!");
                    builder.SetMessage("");

                    // Create a container layout for the button
                    RelativeLayout containerLayout = new RelativeLayout(this);

                    // Create positive button programmatically
                    Button positiveButton = new Button(this);
                    positiveButton.Text = "OK";

                    // Set layout rules for the button within the container layout
                    RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                        RelativeLayout.LayoutParams.WrapContent,
                        RelativeLayout.LayoutParams.WrapContent
                    );
                    buttonParams.LeftMargin = 470;
                    buttonParams.TopMargin = 520;

                    positiveButton.LayoutParameters = buttonParams;

                    // Add the button to the container layout
                    containerLayout.AddView(positiveButton);

                    builder.SetPositiveButton("", (dialog, which) =>
                    {
                        // Handle positive button click event
                        Intent intent = new Intent(this, typeof(MainActivity));
                        intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                        StartActivity(intent);

                        Finish();
                    });

                    AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                    // Set the container layout as the custom view of the dialog
                    dialog.SetView(containerLayout, 0, 0, 0, 0);

                    dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                    dialog.Show();

                    positiveButton.Click += (sender, e) =>
                    {
                        // Handle positive button click event
                        Intent intent = new Intent(this, typeof(MainActivity));
                        intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                        StartActivity(intent);

                        Finish();
                    };
                }

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
