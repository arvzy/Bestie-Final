using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
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
        Button backbtnbldngaoview, frstflrbtn, mzznnbtn, scndflrbtn, thrdflrbtn, frthflrbtn, rfdckbtn, homebtn;
        ImageView imageViewBAView;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngAoview);

            imageViewBAView = FindViewById<ImageView>(Resource.Id.imageViewBuildingView);

            //Floor Buttons
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
        }

        private void Frstflrbtn_Click(object sender, EventArgs e)
        {

            imageViewBAView.SetImageResource(Resource.Drawable.Floor1);

            imageViewBAView.SetImageResource(Resource.Drawable.LobbyLayout);

            frstflrbtn.Enabled = false;
            mzznnbtn.Enabled = true;
            scndflrbtn.Enabled = true;
            thrdflrbtn.Enabled = true;
            frthflrbtn.Enabled = true;
            rfdckbtn.Enabled = true;

            regimgbtn.Visibility = ViewStates.Visible;
            regimgbtn2.Visibility = ViewStates.Visible;
            cshrimgbtn.Visibility = ViewStates.Visible;
            dptyimgbtn.Visibility = ViewStates.Visible;
            complbAimgbtn.Visibility = ViewStates.Visible;
            admssnsoffcimgbtn.Visibility = ViewStates.Visible;
            femtoillbbyimgbtn.Visibility = ViewStates.Visible;
            maltoillbbyimgbtn.Visibility = ViewStates.Visible;
            guidimgbtn.Visibility = ViewStates.Visible;
            stdntsrvcimgbtn.Visibility = ViewStates.Visible;

            lbryimgbtn.Visibility = ViewStates.Gone;
            lbryimgbtn2.Visibility = ViewStates.Gone;
            lbryimgbtn3.Visibility = ViewStates.Gone;
            lbryimgbtn4.Visibility = ViewStates.Gone;
            cmmnctnimgbtn.Visibility = ViewStates.Gone;
            schladmnimgbtn.Visibility = ViewStates.Gone;

            a201imgbtn.Visibility = ViewStates.Gone;
            a202imgbtn.Visibility = ViewStates.Gone;
            a203imgbtn.Visibility = ViewStates.Gone;
            a204imgbtn.Visibility = ViewStates.Gone;
            a205imgbtn.Visibility = ViewStates.Gone;
            a206imgbtn.Visibility = ViewStates.Gone;
            femtoil2ndflrimgbtn.Visibility = ViewStates.Gone;
            maltoil2ndflrimgbtn.Visibility = ViewStates.Gone;

            complabBimgbtn.Visibility = ViewStates.Gone;
            complabCimgbtn.Visibility = ViewStates.Gone;
            complabDimgbtn.Visibility = ViewStates.Gone;
            complabEimgbtn.Visibility = ViewStates.Gone;
            complabFimgbtn.Visibility = ViewStates.Gone;
            femtoil3rdflrimgbtn.Visibility = ViewStates.Gone;
            maltoil3rdflrimgbtn.Visibility = ViewStates.Gone;

            a401imgbtn.Visibility = ViewStates.Gone;
            a402imgbtn.Visibility = ViewStates.Gone;
            a403imgbtn.Visibility = ViewStates.Gone;
            a404imgbtn.Visibility = ViewStates.Gone;
            a405imgbtn.Visibility = ViewStates.Gone;
            a406imgbtn.Visibility = ViewStates.Gone;
            femtoil4thflrimgbtn.Visibility = ViewStates.Gone;
            maltoil4thflrimgbtn.Visibility = ViewStates.Gone;

            rfdckimgbtn.Visibility = ViewStates.Gone;
>>>>>>> Stashed changes
        }

        private void Mzznnbtn_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            imageViewBAView.SetImageResource(Resource.Drawable.Mezzanine);
=======
            imageViewBAView.SetImageResource(Resource.Drawable.LibraryLayout);

            frstflrbtn.Enabled = true;
            mzznnbtn.Enabled = false;
            scndflrbtn.Enabled = true;
            thrdflrbtn.Enabled = true;
            frthflrbtn.Enabled = true;
            rfdckbtn.Enabled = true;

            lbryimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.Library_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            lbryimgbtn2.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.Library_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            lbryimgbtn3.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.Library_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            lbryimgbtn4.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.Library_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            schladmnimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.DeputySchoolAdministrator_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            cmmnctnimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.Communication_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            regimgbtn.Visibility = ViewStates.Gone;
            regimgbtn2.Visibility = ViewStates.Gone;
            cshrimgbtn.Visibility = ViewStates.Gone;
            dptyimgbtn.Visibility = ViewStates.Gone;
            complbAimgbtn.Visibility = ViewStates.Gone;
            admssnsoffcimgbtn.Visibility = ViewStates.Gone;
            femtoillbbyimgbtn.Visibility = ViewStates.Gone;
            maltoillbbyimgbtn.Visibility = ViewStates.Gone;
            guidimgbtn.Visibility = ViewStates.Gone;
            stdntsrvcimgbtn.Visibility = ViewStates.Gone;

            lbryimgbtn.Visibility = ViewStates.Visible;
            lbryimgbtn2.Visibility = ViewStates.Visible;
            lbryimgbtn3.Visibility = ViewStates.Visible;
            lbryimgbtn4.Visibility = ViewStates.Visible;
            cmmnctnimgbtn.Visibility = ViewStates.Visible;
            schladmnimgbtn.Visibility = ViewStates.Visible;

            a201imgbtn.Visibility = ViewStates.Gone;
            a202imgbtn.Visibility = ViewStates.Gone;
            a203imgbtn.Visibility = ViewStates.Gone;
            a204imgbtn.Visibility = ViewStates.Gone;
            a205imgbtn.Visibility = ViewStates.Gone;
            a206imgbtn.Visibility = ViewStates.Gone;
            femtoil2ndflrimgbtn.Visibility = ViewStates.Gone;
            maltoil2ndflrimgbtn.Visibility = ViewStates.Gone;

            complabBimgbtn.Visibility = ViewStates.Gone;
            complabCimgbtn.Visibility = ViewStates.Gone;
            complabDimgbtn.Visibility = ViewStates.Gone;
            complabEimgbtn.Visibility = ViewStates.Gone;
            complabFimgbtn.Visibility = ViewStates.Gone;
            femtoil3rdflrimgbtn.Visibility = ViewStates.Gone;
            maltoil3rdflrimgbtn.Visibility = ViewStates.Gone;

            a401imgbtn.Visibility = ViewStates.Gone;
            a402imgbtn.Visibility = ViewStates.Gone;
            a403imgbtn.Visibility = ViewStates.Gone;
            a404imgbtn.Visibility = ViewStates.Gone;
            a405imgbtn.Visibility = ViewStates.Gone;
            a406imgbtn.Visibility = ViewStates.Gone;
            femtoil4thflrimgbtn.Visibility = ViewStates.Gone;
            maltoil4thflrimgbtn.Visibility = ViewStates.Gone;

            rfdckimgbtn.Visibility = ViewStates.Gone;
>>>>>>> Stashed changes
        }

        private void Scndflrbtn_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            imageViewBAView.SetImageResource(Resource.Drawable.Floor2);
=======
            imageViewBAView.SetImageResource(Resource.Drawable.SecondFlrLayout);

            frstflrbtn.Enabled = true;
            mzznnbtn.Enabled = true;
            scndflrbtn.Enabled = false;
            thrdflrbtn.Enabled = true;
            frthflrbtn.Enabled = true;
            rfdckbtn.Enabled = true;

            a201imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A201_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            a202imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A202_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            a203imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A203_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            a204imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A204_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            a205imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A205_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            a206imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A206_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            maltoil2ndflrimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.ToiletM_2f_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            femtoil2ndflrimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.ToiletF_2f_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            regimgbtn.Visibility = ViewStates.Gone;
            regimgbtn2.Visibility = ViewStates.Gone;
            cshrimgbtn.Visibility = ViewStates.Gone;
            dptyimgbtn.Visibility = ViewStates.Gone;
            complbAimgbtn.Visibility = ViewStates.Gone;
            admssnsoffcimgbtn.Visibility = ViewStates.Gone;
            femtoillbbyimgbtn.Visibility = ViewStates.Gone;
            maltoillbbyimgbtn.Visibility = ViewStates.Gone;
            guidimgbtn.Visibility = ViewStates.Gone;
            stdntsrvcimgbtn.Visibility = ViewStates.Gone;

            lbryimgbtn.Visibility = ViewStates.Gone;
            lbryimgbtn2.Visibility = ViewStates.Gone;
            lbryimgbtn3.Visibility = ViewStates.Gone;
            lbryimgbtn4.Visibility = ViewStates.Gone;
            cmmnctnimgbtn.Visibility = ViewStates.Gone;
            schladmnimgbtn.Visibility = ViewStates.Gone;

            a201imgbtn.Visibility = ViewStates.Visible;
            a202imgbtn.Visibility = ViewStates.Visible;
            a203imgbtn.Visibility = ViewStates.Visible;
            a204imgbtn.Visibility = ViewStates.Visible;
            a205imgbtn.Visibility = ViewStates.Visible;
            a206imgbtn.Visibility = ViewStates.Visible;
            femtoil2ndflrimgbtn.Visibility = ViewStates.Visible;
            maltoil2ndflrimgbtn.Visibility = ViewStates.Visible;

            complabBimgbtn.Visibility = ViewStates.Gone;
            complabCimgbtn.Visibility = ViewStates.Gone;
            complabDimgbtn.Visibility = ViewStates.Gone;
            complabEimgbtn.Visibility = ViewStates.Gone;
            complabFimgbtn.Visibility = ViewStates.Gone;
            femtoil3rdflrimgbtn.Visibility = ViewStates.Gone;
            maltoil3rdflrimgbtn.Visibility = ViewStates.Gone;

            a401imgbtn.Visibility = ViewStates.Gone;
            a402imgbtn.Visibility = ViewStates.Gone;
            a403imgbtn.Visibility = ViewStates.Gone;
            a404imgbtn.Visibility = ViewStates.Gone;
            a405imgbtn.Visibility = ViewStates.Gone;
            a406imgbtn.Visibility = ViewStates.Gone;
            femtoil4thflrimgbtn.Visibility = ViewStates.Gone;
            maltoil4thflrimgbtn.Visibility = ViewStates.Gone;

            rfdckimgbtn.Visibility = ViewStates.Gone;
>>>>>>> Stashed changes
        }

        private void Thrdflrbtn_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            imageViewBAView.SetImageResource(Resource.Drawable.Floor3);
=======
            imageViewBAView.SetImageResource(Resource.Drawable.ThirdFlrLayout);

            frstflrbtn.Enabled = true;
            mzznnbtn.Enabled = true;
            scndflrbtn.Enabled = true;
            thrdflrbtn.Enabled = false;
            frthflrbtn.Enabled = true;
            rfdckbtn.Enabled = true;

            complabBimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A301_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            complabCimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A302_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            complabDimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A303_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            complabEimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A304_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            complabFimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A305_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            maltoil3rdflrimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.ToiletM_2f_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            femtoil3rdflrimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.White);
                positiveButton.Background = roundedShape;


                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 10;
                buttonParams.TopMargin = 10;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);

                    Finish();
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.ToiletF_2f_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            regimgbtn.Visibility = ViewStates.Gone;
            regimgbtn2.Visibility = ViewStates.Gone;
            cshrimgbtn.Visibility = ViewStates.Gone;
            dptyimgbtn.Visibility = ViewStates.Gone;
            complbAimgbtn.Visibility = ViewStates.Gone;
            admssnsoffcimgbtn.Visibility = ViewStates.Gone;
            femtoillbbyimgbtn.Visibility = ViewStates.Gone;
            maltoillbbyimgbtn.Visibility = ViewStates.Gone;
            guidimgbtn.Visibility = ViewStates.Gone;
            stdntsrvcimgbtn.Visibility = ViewStates.Gone;

            lbryimgbtn.Visibility = ViewStates.Gone;
            lbryimgbtn2.Visibility = ViewStates.Gone;
            lbryimgbtn3.Visibility = ViewStates.Gone;
            lbryimgbtn4.Visibility = ViewStates.Gone;
            cmmnctnimgbtn.Visibility = ViewStates.Gone;
            schladmnimgbtn.Visibility = ViewStates.Gone;

            a201imgbtn.Visibility = ViewStates.Gone;
            a202imgbtn.Visibility = ViewStates.Gone;
            a203imgbtn.Visibility = ViewStates.Gone;
            a204imgbtn.Visibility = ViewStates.Gone;
            a205imgbtn.Visibility = ViewStates.Gone;
            a206imgbtn.Visibility = ViewStates.Gone;
            femtoil2ndflrimgbtn.Visibility = ViewStates.Gone;
            maltoil2ndflrimgbtn.Visibility = ViewStates.Gone;

            complabBimgbtn.Visibility = ViewStates.Visible;
            complabCimgbtn.Visibility = ViewStates.Visible;
            complabDimgbtn.Visibility = ViewStates.Visible;
            complabEimgbtn.Visibility = ViewStates.Visible;
            complabFimgbtn.Visibility = ViewStates.Visible;
            femtoil3rdflrimgbtn.Visibility = ViewStates.Visible;
            maltoil3rdflrimgbtn.Visibility = ViewStates.Visible;

            a401imgbtn.Visibility = ViewStates.Gone;
            a402imgbtn.Visibility = ViewStates.Gone;
            a403imgbtn.Visibility = ViewStates.Gone;
            a404imgbtn.Visibility = ViewStates.Gone;
            a405imgbtn.Visibility = ViewStates.Gone;
            a406imgbtn.Visibility = ViewStates.Gone;
            femtoil4thflrimgbtn.Visibility = ViewStates.Gone;
            maltoil4thflrimgbtn.Visibility = ViewStates.Gone;

            rfdckimgbtn.Visibility = ViewStates.Gone;
>>>>>>> Stashed changes
        }

        private void Frthflrbtn_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            imageViewBAView.SetImageResource(Resource.Drawable.Floor4);
=======

            frstflrbtn.Enabled = true;
            mzznnbtn.Enabled = true;
            scndflrbtn.Enabled = true;
            thrdflrbtn.Enabled = true;
            frthflrbtn.Enabled = false;
            rfdckbtn.Enabled = true;

            imageViewBAView.SetImageResource(Resource.Drawable.FourthFlrLayout);

            a401imgbtn.Click -= A401imgbtn_Click;
            a402imgbtn.Click -= A402imgbtn_Click;
            a403imgbtn.Click -= A403imgbtn_Click;
            a404imgbtn.Click -= A404imgbtn_Click;
            a405imgbtn.Click -= A405imgbtn_Click;
            a406imgbtn.Click -= A406imgbtn_Click;
            maltoil4thflrimgbtn.Click -= Maltoil4thflrimgbtn_Click;
            femtoil4thflrimgbtn.Click -= Femtoil4thflrimgbtn_Click;

            
            a401imgbtn.Click += A401imgbtn_Click;
            a402imgbtn.Click += A402imgbtn_Click;
            a403imgbtn.Click += A403imgbtn_Click;
            a404imgbtn.Click += A404imgbtn_Click;
            a405imgbtn.Click += A405imgbtn_Click;
            a406imgbtn.Click += A406imgbtn_Click;
            maltoil4thflrimgbtn.Click += Maltoil4thflrimgbtn_Click;
            femtoil4thflrimgbtn.Click += Femtoil4thflrimgbtn_Click;

            regimgbtn.Visibility = ViewStates.Gone;
            regimgbtn2.Visibility = ViewStates.Gone;
            cshrimgbtn.Visibility = ViewStates.Gone;
            dptyimgbtn.Visibility = ViewStates.Gone;
            complbAimgbtn.Visibility = ViewStates.Gone;
            admssnsoffcimgbtn.Visibility = ViewStates.Gone;
            femtoillbbyimgbtn.Visibility = ViewStates.Gone;
            maltoillbbyimgbtn.Visibility = ViewStates.Gone;
            guidimgbtn.Visibility = ViewStates.Gone;
            stdntsrvcimgbtn.Visibility = ViewStates.Gone;

            lbryimgbtn.Visibility = ViewStates.Gone;
            lbryimgbtn2.Visibility = ViewStates.Gone;
            lbryimgbtn3.Visibility = ViewStates.Gone;
            lbryimgbtn4.Visibility = ViewStates.Gone;
            cmmnctnimgbtn.Visibility = ViewStates.Gone;
            schladmnimgbtn.Visibility = ViewStates.Gone;

            a201imgbtn.Visibility = ViewStates.Gone;
            a202imgbtn.Visibility = ViewStates.Gone;
            a203imgbtn.Visibility = ViewStates.Gone;
            a204imgbtn.Visibility = ViewStates.Gone;
            a205imgbtn.Visibility = ViewStates.Gone;
            a206imgbtn.Visibility = ViewStates.Gone;
            femtoil2ndflrimgbtn.Visibility = ViewStates.Gone;
            maltoil2ndflrimgbtn.Visibility = ViewStates.Gone;

            complabBimgbtn.Visibility = ViewStates.Gone;
            complabCimgbtn.Visibility = ViewStates.Gone;
            complabDimgbtn.Visibility = ViewStates.Gone;
            complabEimgbtn.Visibility = ViewStates.Gone;
            complabFimgbtn.Visibility = ViewStates.Gone;
            femtoil3rdflrimgbtn.Visibility = ViewStates.Gone;
            maltoil3rdflrimgbtn.Visibility = ViewStates.Gone;

            a401imgbtn.Visibility = ViewStates.Visible;
            a402imgbtn.Visibility = ViewStates.Visible;
            a403imgbtn.Visibility = ViewStates.Visible;
            a404imgbtn.Visibility = ViewStates.Visible;
            a405imgbtn.Visibility = ViewStates.Visible;
            a406imgbtn.Visibility = ViewStates.Visible;
            femtoil4thflrimgbtn.Visibility = ViewStates.Visible;
            maltoil4thflrimgbtn.Visibility = ViewStates.Visible;

            rfdckimgbtn.Visibility = ViewStates.Gone;
        }

            private void A401imgbtn_Click(object sender, EventArgs e)
        {
            AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

            RelativeLayout containerLayout = new RelativeLayout(this);

            Button positiveButton = new Button(this);
            positiveButton.Text = "BACK";

            var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
            roundedShape.SetCornerRadius(20);
            roundedShape.SetColor(Android.Graphics.Color.White);
            positiveButton.Background = roundedShape;

            RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                RelativeLayout.LayoutParams.WrapContent,
                RelativeLayout.LayoutParams.WrapContent
            );
            buttonParams.LeftMargin = 10;
            buttonParams.TopMargin = 10;

            positiveButton.LayoutParameters = buttonParams;

            containerLayout.AddView(positiveButton);

            builder.SetPositiveButton("", (dialog, which) =>
            {
                Intent intent = new Intent(this, typeof(BuildingAOverview));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                StartActivityForResult(intent, 1);

                Finish();
            });

            AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

            dialog.SetView(containerLayout, 0, 0, 0, 0);

            dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A401_bg);
            dialog.Show();

            positiveButton.Click += (s, args) =>
            {
                dialog.Dismiss();
            };
        }

        private void A402imgbtn_Click(object sender, EventArgs e)
        {
            AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

            RelativeLayout containerLayout = new RelativeLayout(this);

            Button positiveButton = new Button(this);
            positiveButton.Text = "BACK";

            var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
            roundedShape.SetCornerRadius(20);
            roundedShape.SetColor(Android.Graphics.Color.White);
            positiveButton.Background = roundedShape;

            RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                RelativeLayout.LayoutParams.WrapContent,
                RelativeLayout.LayoutParams.WrapContent
            );
            buttonParams.LeftMargin = 10;
            buttonParams.TopMargin = 10;

            positiveButton.LayoutParameters = buttonParams;

            containerLayout.AddView(positiveButton);

            builder.SetPositiveButton("", (dialog, which) =>
            {
                Intent intent = new Intent(this, typeof(BuildingAOverview));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                StartActivityForResult(intent, 1);

                Finish();
            });

            AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

            dialog.SetView(containerLayout, 0, 0, 0, 0);

            dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A402_bg);
            dialog.Show();

            positiveButton.Click += (s, args) =>
            {
                dialog.Dismiss();
            };
        }


        private void A403imgbtn_Click(object sender, EventArgs e)
        {
            AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

            RelativeLayout containerLayout = new RelativeLayout(this);

            Button positiveButton = new Button(this);
            positiveButton.Text = "BACK";

            var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
            roundedShape.SetCornerRadius(20);
            roundedShape.SetColor(Android.Graphics.Color.White);
            positiveButton.Background = roundedShape;

            RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                RelativeLayout.LayoutParams.WrapContent,
                RelativeLayout.LayoutParams.WrapContent
            );
            buttonParams.LeftMargin = 10;
            buttonParams.TopMargin = 10;

            positiveButton.LayoutParameters = buttonParams;

            containerLayout.AddView(positiveButton);

            builder.SetPositiveButton("", (dialog, which) =>
            {
                Intent intent = new Intent(this, typeof(BuildingAOverview));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                StartActivityForResult(intent, 1);

                Finish();
            });

            AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

            dialog.SetView(containerLayout, 0, 0, 0, 0);

            dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A403_bg);
            dialog.Show();

            positiveButton.Click += (s, args) =>
            {
                dialog.Dismiss();
            };
        }
    

        private void A404imgbtn_Click(object sender, EventArgs e)
        {
            AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

            RelativeLayout containerLayout = new RelativeLayout(this);

            Button positiveButton = new Button(this);
            positiveButton.Text = "BACK";

            var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
            roundedShape.SetCornerRadius(20);
            roundedShape.SetColor(Android.Graphics.Color.White);
            positiveButton.Background = roundedShape;

            RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                RelativeLayout.LayoutParams.WrapContent,
                RelativeLayout.LayoutParams.WrapContent
            );
            buttonParams.LeftMargin = 10;
            buttonParams.TopMargin = 10;

            positiveButton.LayoutParameters = buttonParams;

            containerLayout.AddView(positiveButton);

            builder.SetPositiveButton("", (dialog, which) =>
            {
                Intent intent = new Intent(this, typeof(BuildingAOverview));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                StartActivityForResult(intent, 1);

                Finish();
            });

            AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

            dialog.SetView(containerLayout, 0, 0, 0, 0);

            dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A404_bg);
            dialog.Show();

            positiveButton.Click += (s, args) =>
            {
                dialog.Dismiss();
            };
        }
    
        private void A405imgbtn_Click(object sender, EventArgs e)
        {
            AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

            RelativeLayout containerLayout = new RelativeLayout(this);

            Button positiveButton = new Button(this);
            positiveButton.Text = "BACK";

            var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
            roundedShape.SetCornerRadius(20);
            roundedShape.SetColor(Android.Graphics.Color.White);
            positiveButton.Background = roundedShape;

            RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                RelativeLayout.LayoutParams.WrapContent,
                RelativeLayout.LayoutParams.WrapContent
            );
            buttonParams.LeftMargin = 10;
            buttonParams.TopMargin = 10;

            positiveButton.LayoutParameters = buttonParams;

            containerLayout.AddView(positiveButton);

            builder.SetPositiveButton("", (dialog, which) =>
            {
                Intent intent = new Intent(this, typeof(BuildingAOverview));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                StartActivityForResult(intent, 1);

                Finish();
            });

            AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

            dialog.SetView(containerLayout, 0, 0, 0, 0);

            dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A405Physics_bg);
            dialog.Show();

            positiveButton.Click += (s, args) =>
            {
                dialog.Dismiss();
            };
        }
    

        private void A406imgbtn_Click(object sender, EventArgs e)
        {
            AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

            RelativeLayout containerLayout = new RelativeLayout(this);

            Button positiveButton = new Button(this);
            positiveButton.Text = "BACK";

            var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
            roundedShape.SetCornerRadius(20);
            roundedShape.SetColor(Android.Graphics.Color.White);
            positiveButton.Background = roundedShape;

            RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                RelativeLayout.LayoutParams.WrapContent,
                RelativeLayout.LayoutParams.WrapContent
            );
            buttonParams.LeftMargin = 10;
            buttonParams.TopMargin = 10;

            positiveButton.LayoutParameters = buttonParams;

            containerLayout.AddView(positiveButton);

            builder.SetPositiveButton("", (dialog, which) =>
            {
                Intent intent = new Intent(this, typeof(BuildingAOverview));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                StartActivityForResult(intent, 1);

                Finish();
            });

            AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

            dialog.SetView(containerLayout, 0, 0, 0, 0);

            dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A406Physics_bg);
            dialog.Show();

            positiveButton.Click += (s, args) =>
            {
                dialog.Dismiss();
            };
        }

        private void Maltoil4thflrimgbtn_Click(object sender, EventArgs e)
        {
            AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

            RelativeLayout containerLayout = new RelativeLayout(this);

            Button positiveButton = new Button(this);
            positiveButton.Text = "BACK";

            var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
            roundedShape.SetCornerRadius(20);
            roundedShape.SetColor(Android.Graphics.Color.White);
            positiveButton.Background = roundedShape;

            RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                RelativeLayout.LayoutParams.WrapContent,
                RelativeLayout.LayoutParams.WrapContent
            );
            buttonParams.LeftMargin = 10;
            buttonParams.TopMargin = 10;

            positiveButton.LayoutParameters = buttonParams;

            containerLayout.AddView(positiveButton);

            builder.SetPositiveButton("", (dialog, which) =>
            {
                Intent intent = new Intent(this, typeof(BuildingAOverview));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                StartActivityForResult(intent, 1);

                Finish();
            });

            AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

            dialog.SetView(containerLayout, 0, 0, 0, 0);

            dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.ToiletM_2f_bg);
            dialog.Show();

            positiveButton.Click += (s, args) =>
            {
                dialog.Dismiss();
            };
        }

        private void Femtoil4thflrimgbtn_Click(object sender, EventArgs e)
        {
            AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

            RelativeLayout containerLayout = new RelativeLayout(this);

            Button positiveButton = new Button(this);
            positiveButton.Text = "BACK";

            var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
            roundedShape.SetCornerRadius(20);
            roundedShape.SetColor(Android.Graphics.Color.White);
            positiveButton.Background = roundedShape;

            RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                RelativeLayout.LayoutParams.WrapContent,
                RelativeLayout.LayoutParams.WrapContent
            );
            buttonParams.LeftMargin = 10;
            buttonParams.TopMargin = 10;

            positiveButton.LayoutParameters = buttonParams;

            containerLayout.AddView(positiveButton);

            builder.SetPositiveButton("", (dialog, which) =>
            {
                Intent intent = new Intent(this, typeof(BuildingAOverview));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                StartActivityForResult(intent, 1);

                Finish();
            });

            AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

            dialog.SetView(containerLayout, 0, 0, 0, 0);

            dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.ToiletF_2f_bg);
            dialog.Show();

            positiveButton.Click += (s, args) =>
            {
                dialog.Dismiss();
            };
>>>>>>> Stashed changes
        }

        private void Rfdckbtn_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            imageViewBAView.SetImageResource(Resource.Drawable.Roofdeck);
=======
            imageViewBAView.SetImageResource(Resource.Drawable.RoofDeckLayout);

            frstflrbtn.Enabled = true;
            mzznnbtn.Enabled = true;
            scndflrbtn.Enabled = true;
            thrdflrbtn.Enabled = true;
            frthflrbtn.Enabled = true;
            rfdckbtn.Enabled = false;

            rfdckimgbtn.Click -= Rfdckimgbtn_Click;

            rfdckimgbtn.Click += Rfdckimgbtn_Click;

            

            regimgbtn.Visibility = ViewStates.Gone;
            regimgbtn2.Visibility = ViewStates.Gone;
            cshrimgbtn.Visibility = ViewStates.Gone;
            dptyimgbtn.Visibility = ViewStates.Gone;
            complbAimgbtn.Visibility = ViewStates.Gone;
            admssnsoffcimgbtn.Visibility = ViewStates.Gone;
            femtoillbbyimgbtn.Visibility = ViewStates.Gone;
            maltoillbbyimgbtn.Visibility = ViewStates.Gone;
            guidimgbtn.Visibility = ViewStates.Gone;
            stdntsrvcimgbtn.Visibility = ViewStates.Gone;

            lbryimgbtn.Visibility = ViewStates.Gone;
            lbryimgbtn2.Visibility = ViewStates.Gone;
            lbryimgbtn3.Visibility = ViewStates.Gone;
            lbryimgbtn4.Visibility = ViewStates.Gone;
            cmmnctnimgbtn.Visibility = ViewStates.Gone;
            schladmnimgbtn.Visibility = ViewStates.Gone;

            a201imgbtn.Visibility = ViewStates.Gone;
            a202imgbtn.Visibility = ViewStates.Gone;
            a203imgbtn.Visibility = ViewStates.Gone;
            a204imgbtn.Visibility = ViewStates.Gone;
            a205imgbtn.Visibility = ViewStates.Gone;
            a206imgbtn.Visibility = ViewStates.Gone;
            femtoil2ndflrimgbtn.Visibility = ViewStates.Gone;
            maltoil2ndflrimgbtn.Visibility = ViewStates.Gone;

            complabBimgbtn.Visibility = ViewStates.Gone;
            complabCimgbtn.Visibility = ViewStates.Gone;
            complabDimgbtn.Visibility = ViewStates.Gone;
            complabEimgbtn.Visibility = ViewStates.Gone;
            complabFimgbtn.Visibility = ViewStates.Gone;
            femtoil3rdflrimgbtn.Visibility = ViewStates.Gone;
            maltoil3rdflrimgbtn.Visibility = ViewStates.Gone;

            a401imgbtn.Visibility = ViewStates.Gone;
            a402imgbtn.Visibility = ViewStates.Gone;
            a403imgbtn.Visibility = ViewStates.Gone;
            a404imgbtn.Visibility = ViewStates.Gone;
            a405imgbtn.Visibility = ViewStates.Gone;
            a406imgbtn.Visibility = ViewStates.Gone;
            femtoil4thflrimgbtn.Visibility = ViewStates.Gone;
            maltoil4thflrimgbtn.Visibility = ViewStates.Gone;

            rfdckimgbtn.Visibility = ViewStates.Visible;
        }

        private void Rfdckimgbtn_Click(object sender, EventArgs e)
        {
            AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

            RelativeLayout containerLayout = new RelativeLayout(this);

            Button positiveButton = new Button(this);
            positiveButton.Text = "BACK";

            var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
            roundedShape.SetCornerRadius(20);
            roundedShape.SetColor(Android.Graphics.Color.White);
            positiveButton.Background = roundedShape;

            RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                RelativeLayout.LayoutParams.WrapContent,
                RelativeLayout.LayoutParams.WrapContent
            );
            buttonParams.LeftMargin = 10;
            buttonParams.TopMargin = 10;

            positiveButton.LayoutParameters = buttonParams;

            containerLayout.AddView(positiveButton);

            builder.SetPositiveButton("", (dialog, which) =>
            {
                Intent intent = new Intent(this, typeof(BuildingAOverview));
                intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                StartActivityForResult(intent, 1);

                Finish();
            });

            AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

            dialog.SetView(containerLayout, 0, 0, 0, 0);

            dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.Roofdeck_bg);
            dialog.Show();

            positiveButton.Click += (s, args) =>

            {
                dialog.Dismiss();
            };
>>>>>>> Stashed changes
        }
        private void Backbtnbldngaoview_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BuildingOverview));
            this.StartActivity(intent);
            Finish();
        }
        
    }
}