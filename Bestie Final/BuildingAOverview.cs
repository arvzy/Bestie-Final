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
        ImageButton regimgbtn, cshrimgbtn, dptyimgbtn, admssnsoffcimgbtn, cmplbAimgbtn, femtoillbbyimgbtn, maltoillbbyimgbtn, guidimgbtn, stdntsrvcimgbtn;
        ImageButton lbryimgbtn, cmmnctnimgbtn, schladmnimgbtn;
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
            cshrimgbtn = FindViewById<ImageButton>(Resource.Id.CashierClick);
            dptyimgbtn = FindViewById<ImageButton>(Resource.Id.DeputyClick);
            cmplbAimgbtn = FindViewById<ImageButton>(Resource.Id.CompLabAClick);
            admssnsoffcimgbtn = FindViewById<ImageButton>(Resource.Id.AdmissionsOfficeClick);
            femtoillbbyimgbtn = FindViewById<ImageButton>(Resource.Id.FemToiletLobbyClick);
            maltoillbbyimgbtn = FindViewById<ImageButton>(Resource.Id.MaleToiletLobbyClick);
            guidimgbtn = FindViewById<ImageButton>(Resource.Id.GuidanceClick);
            stdntsrvcimgbtn = FindViewById<ImageButton>(Resource.Id.StudentServicesClick);
            
            //Mezzanine
            lbryimgbtn = FindViewById<ImageButton>(Resource.Id.LibraryClick);
            cmmnctnimgbtn = FindViewById<ImageButton>(Resource.Id.CommunicationClick);
            schladmnimgbtn = FindViewById<ImageButton>(Resource.Id.SchoolAdminClick);

            lbryimgbtn.Visibility = ViewStates.Gone;
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

            //Third Floor
            complabBimgbtn = FindViewById<ImageButton>(Resource.Id.CompLabBClick);
            complabCimgbtn = FindViewById<ImageButton>(Resource.Id.CompLabCClick);
            complabDimgbtn = FindViewById<ImageButton>(Resource.Id.CompLabDClick);
            complabEimgbtn = FindViewById<ImageButton>(Resource.Id.CompLabEClick);
            complabFimgbtn = FindViewById<ImageButton>(Resource.Id.CompLabFClick);
            femtoil3rdflrimgbtn = FindViewById<ImageButton>(Resource.Id.FemToilet3rdFloorClick);
            maltoil3rdflrimgbtn = FindViewById<ImageButton>(Resource.Id.MaleToilet3rdFloorClick);

            //Fourth Floor
            a401imgbtn = FindViewById<ImageButton>(Resource.Id.A401);
            a402imgbtn = FindViewById<ImageButton>(Resource.Id.A402);
            a403imgbtn = FindViewById<ImageButton>(Resource.Id.A403);
            a404imgbtn = FindViewById<ImageButton>(Resource.Id.A404ElecLabClick);
            a405imgbtn = FindViewById<ImageButton>(Resource.Id.A405PhysLabClick);
            a406imgbtn = FindViewById<ImageButton>(Resource.Id.A406ChemLabClick);
            femtoil4thflrimgbtn = FindViewById<ImageButton>(Resource.Id.FemToilet4thFloorClick);
            maltoil4thflrimgbtn = FindViewById<ImageButton>(Resource.Id.MaleToilet4thFloorClick);

            //Roofdeck
            rfdckimgbtn = FindViewById<ImageButton>(Resource.Id.RoofdeckClick);

            regimgbtn.Click += (sender, args) =>
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
                    Intent intent = new Intent(this, typeof(BuildingAOverview));
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);
                    StartActivityForResult(intent, 1);
                });

                AndroidX.AppCompat.App.AlertDialog dialog = builder.Create();

                // Set the container layout as the custom view of the dialog
                dialog.SetView(containerLayout, 0, 0, 0, 0);

                dialog.Window.SetBackgroundDrawableResource(Resource.Drawable.PAGE_NOT_FOUND);
                dialog.Show();

                positiveButton.Click += (sender, e) =>
                {
                    // Handle positive button click event
                    dialog.Dismiss(); // Dismiss the dialog

                    // Optionally, remove the following line to prevent the current activity from being finished
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
        }

        private void Mzznnbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.LibraryLayout);
        }

        private void Scndflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.SecondFlrLayout);
        }

        private void Thrdflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.ThirdFlrLayout);
        }

        private void Frthflrbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.FourthFlrLayout);
        }

        private void Rfdckbtn_Click(object sender, EventArgs e)
        {
            imageViewBAView.SetImageResource(Resource.Drawable.RoofDeckLayout);
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