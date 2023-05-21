using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using Java.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bestie_Final
{
    [Activity(Label = "InstructionsC")]
    public class InstructionsC : Activity
    {
        Button bckbtninstructions;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.instructionslayout);

            // Create your application here
            bckbtninstructions = FindViewById<Button>(Resource.Id.InstructionsBackButton);

            bckbtninstructions.Click += Bckbtninstructions_Click;
        }

        private void Bckbtninstructions_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            this.StartActivity(intent);
            Finish();

            Button button = (Button)sender;
            Animation animation = AnimationUtils.LoadAnimation(this, Resource.Drawable.animationbutton);
            button.StartAnimation(animation);
        }
    }
}