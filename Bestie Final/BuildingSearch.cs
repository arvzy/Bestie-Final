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
    [Activity(Label = "BuildingSearch")]
    public class BuildingSearch : Activity
    {        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngsrch);
            var handler = new Handler();            
            string text = Intent.GetStringExtra("text");

            var imageView = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewFirst);
            var imageView2 = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewSecond);
            var imageView3 = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewThird);
            var imageView4 = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewFourth);
            var imageView5 = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewFifth);
            var imageView6 = FindViewById<ImageView>(Resource.Id.BuildingSearchImageViewSixth);

            //Lobby

            if (text == "Admissions Office")
            {
                imageView.SetImageResource(Resource.Drawable.AdmissionsOffice);
            }

            if (text == "Cashier")
            {
                imageView.SetImageResource(Resource.Drawable.Cashier);
            }

            if (text == "Computer Laboratory A")
            {
                imageView.SetImageResource(Resource.Drawable.CompLabA);
            }

            if (text == "Deputy School Administrator")
            {
                imageView.SetImageResource(Resource.Drawable.Deputy);
            }

            if (text == "Registrar")
            {
                imageView.SetImageResource(Resource.Drawable.Registrar);
            }

            if (text == "Female Toilet Lobby")
            {
                imageView.SetImageResource(Resource.Drawable.FemaleToiletLobby);
            }

            if (text == "Male Toilet Lobby")
            {
                imageView.SetImageResource(Resource.Drawable.MaleToiletLobby);
            }

            //Mezzanine

            if (text == "Library")
            {
                imageView.SetImageResource(Resource.Drawable.Library1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.Library2);
                }, 3000);               
            }

            if (text == "Bookstore")
            {
                imageView.SetImageResource(Resource.Drawable.Bookstore1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.Bookstore2);
                }, 3000);
            }

            if (text == "School Administrator")
            {
                imageView.SetImageResource(Resource.Drawable.SchoolAdmin1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.SchoolAdmin2);
                }, 3000);
            }

            //2nd Floor

            if (text == "A201")
            {
                imageView.SetImageResource(Resource.Drawable.A201_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.A201_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.A201_3);
                }, 6000);
            }

            if (text == "A202")
            {
                imageView.SetImageResource(Resource.Drawable.A202_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.A202_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.A202_3);
                }, 6000);
            }

            if (text == "A203")
            {
                imageView.SetImageResource(Resource.Drawable.A203_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.A203_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.A203_3);
                }, 6000);
            }

            if (text == "A204")
            {
                imageView.SetImageResource(Resource.Drawable.A204_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.A204_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.A204_3);
                }, 6000);
            }

            if (text == "A205")
            {
                imageView.SetImageResource(Resource.Drawable.A205_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.A205_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.A205_3);
                }, 6000);
            }

            if (text == "A205")
            {
                imageView.SetImageResource(Resource.Drawable.A206_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.A206_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.A206_3);
                }, 6000);
            }

            if (text == "Female Toilet 2nd Floor")
            {
                imageView.SetImageResource(Resource.Drawable.FemaleToilet2ndFloor_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.FemaleToilet2ndFloor_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.FemaleToilet2ndFloor_3);
                }, 6000);
            }

            if (text == "Male Toilet 2nd Floor")
            {
                imageView.SetImageResource(Resource.Drawable.MaleToilet2ndFloor_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.MaleToilet2ndFloor_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.MaleToilet2ndFloor_3);
                }, 6000);
            }

            //3rd Floor
            if (text == "Computer Laboratory B")
            {
                imageView.SetImageResource(Resource.Drawable.CompLabB_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.CompLabB_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.CompLabB_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.CompLabB_4);
                }, 9000);
            }

            if (text == "Computer Laboratory C")
            {
                imageView.SetImageResource(Resource.Drawable.CompLabC_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.CompLabC_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.CompLabC_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.CompLabC_4);
                }, 9000);
            }

            if (text == "Computer Laboratory D")
            {
                imageView.SetImageResource(Resource.Drawable.CompLabD_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.CompLabD_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.CompLabD_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.CompLabD_4);
                }, 9000);
            }

            if (text == "Computer Laboratory E")
            {
                imageView.SetImageResource(Resource.Drawable.CompLabE_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.CompLabE_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.CompLabE_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.CompLabE_4);
                }, 9000);
            }

            if (text == "Computer Laboratory F")
            {
                imageView.SetImageResource(Resource.Drawable.CompLabF_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.CompLabF_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.CompLabF_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.CompLabF_4);
                }, 9000);
            }

            if (text == "Male Toilet 3rd Floor")
            {
                imageView.SetImageResource(Resource.Drawable.MaleToilet3rdFloor_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.MaleToilet3rdFloor_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.MaleToilet3rdFloor_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.MaleToilet3rdFloor_4);
                }, 9000);
            }

            if (text == "Female Toilet 3rd Floor")
            {
                imageView.SetImageResource(Resource.Drawable.FemaleToilet3rdFloor_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.FemaleToilet3rdFloor_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.FemaleToilet3rdFloor_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.FemaleToilet3rdFloor_4);
                }, 9000);
            }

            //4th Floor
            if (text == "A401")
            {
                imageView.SetImageResource(Resource.Drawable.A401_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.A401_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.A401_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.A401_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.A401_5);
                }, 12000);
            }

            if (text == "A402")
            {
                imageView.SetImageResource(Resource.Drawable.A402_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.A402_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.A402_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.A402_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.A402_5);
                }, 12000);
            }

            if (text == "A403")
            {
                imageView.SetImageResource(Resource.Drawable.A403_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.A403_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.A403_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.A403_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.A403_5);
                }, 12000);
            }

            if (text == "Physics Laboratory")
            {
                imageView.SetImageResource(Resource.Drawable.PhysicsLab_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.PhysicsLab_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.PhysicsLab_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.PhysicsLab_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.PhysicsLab_5);
                }, 12000);
            }

            if (text == "Chemistry Laboratory")
            {
                imageView.SetImageResource(Resource.Drawable.ChemLab_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.ChemLab_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.ChemLab_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.ChemLab_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.ChemLab_5);
                }, 12000);
            }

            if (text == "Electronic Laboratory")
            {
                imageView.SetImageResource(Resource.Drawable.ElectronicLab_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.ElectronicLab_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.ElectronicLab_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.ElectronicLab_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.ElectronicLab_5);
                }, 12000);
            }

            if (text == "Female Toilet 4th Floor")
            {
                imageView.SetImageResource(Resource.Drawable.FemaleToilet4thFloor_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.FemaleToilet4thFloor_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.FemaleToilet4thFloor_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.FemaleToilet4thFloor_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.FemaleToilet4thFloor_5);
                }, 12000);
            }

            if (text == "Male Toilet 4th Floor")
            {
                imageView.SetImageResource(Resource.Drawable.MaleToilet4thFloor_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.MaleToilet4thFloor_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.MaleToilet4thFloor_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.MaleToilet4thFloor_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.MaleToilet4thFloor_5);
                }, 12000);
            }

            //Roofdeck
            if (text == "Roofdeck")
            {
                imageView.SetImageResource(Resource.Drawable.Roofdeck_1);
                handler.PostDelayed(() =>
                {
                    imageView2.SetImageResource(Resource.Drawable.Roofdeck_2);
                }, 3000);
                handler.PostDelayed(() =>
                {
                    imageView3.SetImageResource(Resource.Drawable.Roofdeck_3);
                }, 6000);
                handler.PostDelayed(() =>
                {
                    imageView4.SetImageResource(Resource.Drawable.Roofdeck_4);
                }, 9000);
                handler.PostDelayed(() =>
                {
                    imageView5.SetImageResource(Resource.Drawable.Roofdeck_5);
                }, 12000);
                handler.PostDelayed(() =>
                {
                    imageView6.SetImageResource(Resource.Drawable.Roofdeck_6);
                }, 13000);
            }
        }
    }
}