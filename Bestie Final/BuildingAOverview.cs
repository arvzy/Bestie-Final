﻿using Android.App;
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
        ImageButton regimgbtn, regimgbtn2, cshrimgbtn, dptyimgbtn, admssnsoffcimgbtn, complbAimgbtn, femtoillbbyimgbtn, maltoillbbyimgbtn, guidimgbtn, stdntsrvcimgbtn;
        ImageButton lbryimgbtn, lbryimgbtn2, lbryimgbtn3, lbryimgbtn4, cmmnctnimgbtn, schladmnimgbtn;
        ImageButton a201imgbtn, a202imgbtn, a203imgbtn, a204imgbtn, a205imgbtn, a206imgbtn, femtoil2ndflrimgbtn, maltoil2ndflrimgbtn;
        ImageButton complabBimgbtn, complabCimgbtn, complabDimgbtn, complabEimgbtn, complabFimgbtn, femtoil3rdflrimgbtn, maltoil3rdflrimgbtn;
        ImageButton a401imgbtn, a402imgbtn, a403imgbtn, a404imgbtn, a405imgbtn, a406imgbtn, femtoil4thflrimgbtn, maltoil4thflrimgbtn;
        ImageButton rfdckimgbtn;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngAoview);

            imageViewBAView = FindViewById<ImageView>(Resource.Id.imageViewBuildingView);

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

            //Lobby
            regimgbtn = FindViewById<ImageButton>(Resource.Id.RegistrarClick);
            regimgbtn2 = FindViewById<ImageButton>(Resource.Id.RegistrartwoClick);
            cshrimgbtn = FindViewById<ImageButton>(Resource.Id.CashierClick);
            dptyimgbtn = FindViewById<ImageButton>(Resource.Id.DeputyClick);
            complbAimgbtn = FindViewById<ImageButton>(Resource.Id.CompLabAClick);
            admssnsoffcimgbtn = FindViewById<ImageButton>(Resource.Id.AdmissionsOfficeClick);
            femtoillbbyimgbtn = FindViewById<ImageButton>(Resource.Id.FemToiletLobbyClick);
            maltoillbbyimgbtn = FindViewById<ImageButton>(Resource.Id.MaleToiletLobbyClick);
            guidimgbtn = FindViewById<ImageButton>(Resource.Id.GuidanceClick);
            stdntsrvcimgbtn = FindViewById<ImageButton>(Resource.Id.StudentServicesClick);
            
            //Mezzanine
            lbryimgbtn = FindViewById<ImageButton>(Resource.Id.LibraryClick);
            lbryimgbtn2 = FindViewById<ImageButton>(Resource.Id.LibraryClick2);
            lbryimgbtn3 = FindViewById<ImageButton>(Resource.Id.LibraryClick3);
            lbryimgbtn4 = FindViewById<ImageButton>(Resource.Id.LibraryClick4);
            cmmnctnimgbtn = FindViewById<ImageButton>(Resource.Id.CommunicationClick);
            schladmnimgbtn = FindViewById<ImageButton>(Resource.Id.SchoolAdminClick);

            lbryimgbtn.Visibility = ViewStates.Gone;
            lbryimgbtn2.Visibility = ViewStates.Gone;
            lbryimgbtn3.Visibility = ViewStates.Gone;
            lbryimgbtn4.Visibility = ViewStates.Gone;
            cmmnctnimgbtn.Visibility = ViewStates.Gone;
            schladmnimgbtn.Visibility = ViewStates.Gone;

            //Second Floor
            a201imgbtn = FindViewById<ImageButton>(Resource.Id.A201Click);
            a202imgbtn = FindViewById<ImageButton>(Resource.Id.A202Click);
            a203imgbtn = FindViewById<ImageButton>(Resource.Id.A203Click);
            a204imgbtn = FindViewById<ImageButton>(Resource.Id.A204Click);
            a205imgbtn = FindViewById<ImageButton>(Resource.Id.A205Click);
            a206imgbtn = FindViewById<ImageButton>(Resource.Id.A206Click);
            femtoil2ndflrimgbtn = FindViewById<ImageButton>(Resource.Id.FemToilet2ndFloorClick);
            maltoil2ndflrimgbtn = FindViewById<ImageButton>(Resource.Id.MaleToilet2ndFloorClick);

            a201imgbtn.Visibility = ViewStates.Gone;
            a202imgbtn.Visibility = ViewStates.Gone;
            a203imgbtn.Visibility = ViewStates.Gone;
            a204imgbtn.Visibility = ViewStates.Gone;
            a205imgbtn.Visibility = ViewStates.Gone;
            a206imgbtn.Visibility = ViewStates.Gone;
            femtoil2ndflrimgbtn.Visibility = ViewStates.Gone;
            maltoil2ndflrimgbtn.Visibility = ViewStates.Gone;

            //Third Floor
            complabBimgbtn = FindViewById<ImageButton>(Resource.Id.CompLabBClick);
            complabCimgbtn = FindViewById<ImageButton>(Resource.Id.CompLabCClick);
            complabDimgbtn = FindViewById<ImageButton>(Resource.Id.CompLabDClick);
            complabEimgbtn = FindViewById<ImageButton>(Resource.Id.CompLabEClick);
            complabFimgbtn = FindViewById<ImageButton>(Resource.Id.CompLabFClick);
            femtoil3rdflrimgbtn = FindViewById<ImageButton>(Resource.Id.FemToilet3rdFloorClick);
            maltoil3rdflrimgbtn = FindViewById<ImageButton>(Resource.Id.MaleToilet3rdFloorClick);

            complabBimgbtn.Visibility = ViewStates.Gone;
            complabCimgbtn.Visibility = ViewStates.Gone;
            complabDimgbtn.Visibility = ViewStates.Gone;
            complabEimgbtn.Visibility = ViewStates.Gone;
            complabFimgbtn.Visibility = ViewStates.Gone;
            femtoil3rdflrimgbtn.Visibility = ViewStates.Gone;
            maltoil3rdflrimgbtn.Visibility = ViewStates.Gone;

            //Fourth Floor
            a401imgbtn = FindViewById<ImageButton>(Resource.Id.A401);
            a402imgbtn = FindViewById<ImageButton>(Resource.Id.A402);
            a403imgbtn = FindViewById<ImageButton>(Resource.Id.A403);
            a404imgbtn = FindViewById<ImageButton>(Resource.Id.A404ElecLabClick);
            a405imgbtn = FindViewById<ImageButton>(Resource.Id.A405PhysLabClick);
            a406imgbtn = FindViewById<ImageButton>(Resource.Id.A406ChemLabClick);
            femtoil4thflrimgbtn = FindViewById<ImageButton>(Resource.Id.FemToilet4thFloorClick);
            maltoil4thflrimgbtn = FindViewById<ImageButton>(Resource.Id.MaleToilet4thFloorClick);

            a401imgbtn.Visibility = ViewStates.Gone;
            a402imgbtn.Visibility = ViewStates.Gone;
            a403imgbtn.Visibility = ViewStates.Gone;
            a404imgbtn.Visibility = ViewStates.Gone;
            a405imgbtn.Visibility = ViewStates.Gone;
            a406imgbtn.Visibility = ViewStates.Gone;
            femtoil4thflrimgbtn.Visibility = ViewStates.Gone;
            maltoil4thflrimgbtn.Visibility = ViewStates.Gone;

            //Roofdeck
            rfdckimgbtn = FindViewById<ImageButton>(Resource.Id.RoofdeckClick);

            rfdckimgbtn.Visibility = ViewStates.Gone;



            regimgbtn.Click += (sender, args) =>
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

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.Registrar_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            regimgbtn2.Click += (sender, args) =>
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

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.Registrar_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            cshrimgbtn.Click += (sender, args) =>
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

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.Cashier_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            dptyimgbtn.Click += (sender, args) =>
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

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.Building_Admin_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            admssnsoffcimgbtn.Click += (sender, args) =>
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

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.Lobby_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            complbAimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "BACK";

                var roundedShape = new Android.Graphics.Drawables.GradientDrawable();
                roundedShape.SetCornerRadius(20);
                roundedShape.SetColor(Android.Graphics.Color.LightGray);
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

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.A_lab_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            femtoillbbyimgbtn.Click += (sender, args) =>
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

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.ToiletF_1f_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            maltoillbbyimgbtn.Click += (sender, args) =>
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

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.ToiletM_1f_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            stdntsrvcimgbtn.Click += (sender, args) =>
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

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.LobbyCorridor_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            guidimgbtn.Click += (sender, args) =>
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

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.LobbyCorridor_bg);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };
        }



        private void Homebtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
            Finish();
        }

        private void Frstflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.LobbyLayout);

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
        }

        private void Mzznnbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.LibraryLayout);

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
        }

        private void Scndflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.SecondFlrLayout);

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
        }

        private void Thrdflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.ThirdFlrLayout);

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
        }

        private void Frthflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.FourthFlrLayout);

            a401imgbtn.Click += (sender, args) =>
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

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            a402imgbtn.Click += (sender, args) =>
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

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            a403imgbtn.Click += (sender, args) =>
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

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            a404imgbtn.Click += (sender, args) =>
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

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            a405imgbtn.Click += (sender, args) =>
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

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            a406imgbtn.Click += (sender, args) =>
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

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                };
            };

            maltoil4thflrimgbtn.Click += (sender, args) =>
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

            femtoil4thflrimgbtn.Click += (sender, args) =>
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

        private void Rfdckbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.RoofDeckLayout);

            // Detach the event handler if it was previously attached
            rfdckimgbtn.Click -= Rfdckimgbtn_Click;

            // Attach the event handler to the button click event
            rfdckimgbtn.Click += Rfdckimgbtn_Click;

            // Move the visibility changes outside the event handler
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
        }
        private void Backbtnbldngaoview_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BuildingOverview));
            this.StartActivity(intent);
            Finish();
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (requestCode == 1 && resultCode == Result.Ok)
            {
            Finish();
            }
        }
    }
}