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
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.ARegistrar);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss(); 

                    // Finish();
                };
            };

            regimgbtn2.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            cshrimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            dptyimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            admssnsoffcimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            complbAimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            femtoillbbyimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            maltoillbbyimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            stdntsrvcimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            guidimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
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

            regimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            regimgbtn2.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            cshrimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            dptyimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            admssnsoffcimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            complbAimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            femtoillbbyimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            maltoillbbyimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            stdntsrvcimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            guidimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

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
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            lbryimgbtn2.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            lbryimgbtn3.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            lbryimgbtn4.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            schladmnimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            cmmnctnimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
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
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            a202imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            a203imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            a204imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            a205imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            a206imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            maltoil2ndflrimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            femtoil2ndflrimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
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
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            complabCimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            complabDimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            complabEimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            complabFimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            maltoil3rdflrimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            femtoil3rdflrimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
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
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            a402imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            a403imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            a404imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            a405imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            a406imgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            maltoil4thflrimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
                };
            };

            femtoil4thflrimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
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

            rfdckimgbtn.Click += (sender, args) =>
            {
                AndroidX.AppCompat.App.AlertDialog.Builder builder = new AndroidX.AppCompat.App.AlertDialog.Builder(this);
                builder.SetTitle("Oops!");
                builder.SetMessage("");

                RelativeLayout containerLayout = new RelativeLayout(this);

                Button positiveButton = new Button(this);
                positiveButton.Text = "OK";

                RelativeLayout.LayoutParams buttonParams = new RelativeLayout.LayoutParams(
                    RelativeLayout.LayoutParams.WrapContent,
                    RelativeLayout.LayoutParams.WrapContent
                );
                buttonParams.LeftMargin = 470;
                buttonParams.TopMargin = 520;

                positiveButton.LayoutParameters = buttonParams;

                containerLayout.AddView(positiveButton);

                builder.SetPositiveButton("", (dialog, which) =>
                {
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {

                    dialog.Dismiss();

                    // Finish();
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
                // Handle the result from MainActivity
                // Optionally, finish the current activity here if needed
                // Finish();
            }
        }
    }
}