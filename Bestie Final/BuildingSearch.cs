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
using Android.Views.InputMethods;
using Java.Util;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Bestie_Final
{
    [Activity(Label = "BuildingSearch")]
    public class BuildingSearch : Activity
    {
        Button btnautocompletesearch;
        AutoCompleteTextView searchBar;
        ImageView flr1img, admsssnsoffce, regstrr, cashr, complabA, depty, maletoilet1, femaletoilet2, lbrry1, lbrry2;

        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.bldngsrch);

            string[] suggestions = { "Admissions Office", "Cashier", "Registrar", "Deputy", "Computer Laboratory A", 
            "Male Toilet Lobby", "Female Toilet Lobby", "Library"};

            btnautocompletesearch = FindViewById<Button>(Resource.Id.AutoCompleteSearch);

            searchBar = FindViewById<AutoCompleteTextView>(Resource.Id.searchBar);

            btnautocompletesearch.Click += Btnautocompletesearch_Click;

            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleDropDownItem1Line, suggestions);

            searchBar.Adapter = adapter;

            searchBar.EditorAction += (sender, args) =>
            {
                if (args.ActionId == ImeAction.Search)
                {
                    var searchText = searchBar.Text;

                }
            };
            
            flr1img = FindViewById<ImageView>(Resource.Id.flr1Image);

            //Lobby
            admsssnsoffce = FindViewById<ImageView>(Resource.Id.AdmissionsOfficeImage);
            regstrr = FindViewById<ImageView>(Resource.Id.RegistrarImage);
            cashr = FindViewById<ImageView>(Resource.Id.CashierImage);
            complabA = FindViewById<ImageView>(Resource.Id.CompLabAImage);
            depty = FindViewById<ImageView>(Resource.Id.DeputyImage);
            maletoilet1 = FindViewById<ImageView>(Resource.Id.MaleToiletImage1);
            femaletoilet2 = FindViewById<ImageView>(Resource.Id.FemaleToiletImage1);

            //Mezzaninne
            lbrry1 = FindViewById<ImageView>(Resource.Id.LibraryImage1);
            lbrry2 = FindViewById<ImageView>(Resource.Id.LibraryImage2);

        }

        
        private void Btnautocompletesearch_Click(object sender, EventArgs e)
        {
            var handler = new Handler();

            //first floor lobby
            if (searchBar.Text == "Admissions Office")
            {
                if (admsssnsoffce.Visibility == ViewStates.Invisible)
                {
                    //Lobby
                    flr1img.Visibility = ViewStates.Invisible;
                    admsssnsoffce.Visibility = ViewStates.Visible;
                    regstrr.Visibility = ViewStates.Invisible;
                    cashr.Visibility = ViewStates.Invisible;
                    complabA.Visibility = ViewStates.Invisible;
                    depty.Visibility = ViewStates.Invisible;
                    maletoilet1.Visibility = ViewStates.Invisible;
                    femaletoilet2.Visibility = ViewStates.Invisible;

                    //Mezzaninne
                    lbrry1.Visibility = ViewStates.Invisible;
                    lbrry2.Visibility = ViewStates.Invisible;
                }
                else
                {
                    admsssnsoffce.Visibility = ViewStates.Visible;
                }
            }

            if (searchBar.Text == "Registrar")
            {
                if (regstrr.Visibility == ViewStates.Invisible)
                {
                    flr1img.Visibility = ViewStates.Invisible;
                    admsssnsoffce.Visibility = ViewStates.Invisible;
                    regstrr.Visibility = ViewStates.Visible;
                    cashr.Visibility = ViewStates.Invisible;
                    complabA.Visibility = ViewStates.Invisible;
                    depty.Visibility = ViewStates.Invisible;
                    maletoilet1.Visibility = ViewStates.Invisible;
                    femaletoilet2.Visibility = ViewStates.Invisible;

                    //Mezzaninne
                    lbrry1.Visibility = ViewStates.Invisible;
                    lbrry2.Visibility = ViewStates.Invisible;
                }
                else
                {
                    regstrr.Visibility = ViewStates.Visible;
                }
            }

            if (searchBar.Text == "Cashier")
            {
                if (cashr.Visibility == ViewStates.Invisible)
                {
                    flr1img.Visibility = ViewStates.Invisible;
                    admsssnsoffce.Visibility = ViewStates.Invisible;
                    regstrr.Visibility = ViewStates.Invisible;
                    cashr.Visibility = ViewStates.Visible;
                    complabA.Visibility = ViewStates.Invisible;
                    depty.Visibility = ViewStates.Invisible;
                    maletoilet1.Visibility = ViewStates.Invisible;
                    femaletoilet2.Visibility = ViewStates.Invisible;

                    //Mezzaninne
                    lbrry1.Visibility = ViewStates.Invisible;
                    lbrry2.Visibility = ViewStates.Invisible;
                }
                else
                {
                    cashr.Visibility = ViewStates.Visible;
                }
            }

            if (searchBar.Text == "Computer Laboratory A")
            {
                if (complabA.Visibility == ViewStates.Invisible)
                {
                    flr1img.Visibility = ViewStates.Invisible;
                    admsssnsoffce.Visibility = ViewStates.Invisible;
                    regstrr.Visibility = ViewStates.Invisible;
                    cashr.Visibility = ViewStates.Invisible;
                    complabA.Visibility = ViewStates.Visible;
                    depty.Visibility = ViewStates.Invisible;
                    maletoilet1.Visibility = ViewStates.Invisible;
                    femaletoilet2.Visibility = ViewStates.Invisible;

                    //Mezzaninne
                    lbrry1.Visibility = ViewStates.Invisible;
                    lbrry2.Visibility = ViewStates.Invisible;
                }
                else
                {
                    complabA.Visibility = ViewStates.Visible;
                }
            }

            if (searchBar.Text == "Deputy")
               {
                if (depty.Visibility == ViewStates.Invisible)
                {
                    flr1img.Visibility = ViewStates.Invisible;
                    admsssnsoffce.Visibility = ViewStates.Invisible;
                    regstrr.Visibility = ViewStates.Invisible;
                    cashr.Visibility = ViewStates.Invisible;
                    complabA.Visibility = ViewStates.Invisible;
                    depty.Visibility = ViewStates.Visible;
                    maletoilet1.Visibility = ViewStates.Invisible;
                    femaletoilet2.Visibility = ViewStates.Invisible;

                    //Mezzaninne
                    lbrry1.Visibility = ViewStates.Invisible;
                    lbrry2.Visibility = ViewStates.Invisible;
                }
                else
                {
                    depty.Visibility = ViewStates.Visible;
                }
            }

            if (searchBar.Text == "Male Toilet Lobby")
                {
                if (maletoilet1.Visibility == ViewStates.Invisible)
                {
                    flr1img.Visibility = ViewStates.Invisible;
                    admsssnsoffce.Visibility = ViewStates.Invisible;
                    regstrr.Visibility = ViewStates.Invisible;
                    cashr.Visibility = ViewStates.Invisible;
                    complabA.Visibility = ViewStates.Invisible;
                    depty.Visibility = ViewStates.Invisible;
                    maletoilet1.Visibility = ViewStates.Visible;
                    femaletoilet2.Visibility = ViewStates.Invisible;

                    //Mezzaninne
                    lbrry1.Visibility = ViewStates.Invisible;
                    lbrry2.Visibility = ViewStates.Invisible;
                }
                else
                {
                    maletoilet1.Visibility = ViewStates.Visible;
                }
            }

            if (searchBar.Text == "Female Toilet Lobby")
                {
                if (femaletoilet2.Visibility == ViewStates.Invisible)
                {
                    flr1img.Visibility = ViewStates.Invisible;
                    admsssnsoffce.Visibility = ViewStates.Invisible;
                    regstrr.Visibility = ViewStates.Invisible;
                    cashr.Visibility = ViewStates.Invisible;
                    complabA.Visibility = ViewStates.Invisible;
                    depty.Visibility = ViewStates.Invisible;
                    maletoilet1.Visibility = ViewStates.Invisible;
                    femaletoilet2.Visibility = ViewStates.Visible;

                    //Mezzaninne
                    lbrry1.Visibility = ViewStates.Invisible;
                    lbrry2.Visibility = ViewStates.Invisible;
                }
                else
                {
                    femaletoilet2.Visibility = ViewStates.Visible;
                }                       
            }

            //mezzannine

            if (searchBar.Text == "Library")
            {
                if (lbrry1.Visibility == ViewStates.Invisible && lbrry2.Visibility == ViewStates.Invisible)
                {
                    flr1img.Visibility = ViewStates.Invisible;
                    admsssnsoffce.Visibility = ViewStates.Invisible;
                    regstrr.Visibility = ViewStates.Invisible;
                    cashr.Visibility = ViewStates.Invisible;
                    complabA.Visibility = ViewStates.Invisible;
                    depty.Visibility = ViewStates.Invisible;
                    maletoilet1.Visibility = ViewStates.Invisible;
                    femaletoilet2.Visibility = ViewStates.Invisible;

                    //Mezzaninne                    
                    lbrry1.Visibility = ViewStates.Visible;                    

                    handler.PostDelayed(() =>
                    {
                        lbrry2.Visibility = ViewStates.Visible;
                    }, 5000);
                }
                else
                {
                    lbrry1.Visibility = ViewStates.Visible;
                    lbrry2.Visibility = ViewStates.Visible;
                }
            }
        }
    }
}
    
