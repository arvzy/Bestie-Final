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

namespace Bestie_Final
{
    [Activity(Label = "EmergencyExits")]
    public class EmergencyExits : Activity
    {
        Button eebckbtn, frstflrEbtn, mzznneEbtn, scndflrEbtn, thrdflrEbtn, frthflrEbtn, rfdckEbtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.emergencyexits);
            // Create your application here

            eebckbtn = FindViewById<Button>(Resource.Id.BackEmergencyExits);
            frstflrEbtn = FindViewById<Button>(Resource.Id.frstfEButton);
            mzznneEbtn = FindViewById<Button>(Resource.Id.mzznnEButton);
            scndflrEbtn = FindViewById<Button>(Resource.Id.scndfEButton); 
            thrdflrEbtn = FindViewById<Button>(Resource.Id.thrdfEButton); 
            frthflrEbtn = FindViewById<Button>(Resource.Id.frthfEButton); 
            rfdckEbtn = FindViewById<Button>(Resource.Id.rfdckEButton);

            eebckbtn.Click += Eebckbtn_Click;
        }

        private void Eebckbtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BuildingOverview));
            this.StartActivity(intent);
            Finish();
        }
    }
}