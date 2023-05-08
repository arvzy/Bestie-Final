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
    [Activity(Label = "AboutC")]
    public class AboutC : Activity
    {

        Button bckaboutbtn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.aboutlayout);
            // Create your application here

            bckaboutbtn = FindViewById<Button>(Resource.Id.AboutBackButton);

            bckaboutbtn.Click += Bckaboutbtn_Click;
        }

        private void Bckaboutbtn_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
            Finish();
        }
    }
}