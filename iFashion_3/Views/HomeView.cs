using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using V7Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using Android.Support.Design.Widget;
using Android;

namespace iFashion_3.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme.Base")]
    class HomeView : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.home);

            //Tombol ke kiri ning profile

            Button bttn1 = FindViewById<Button>(Resource.Id.button1);
            bttn1.Click += delegate
            {
                Intent i = new Intent(this, typeof(ProfileView));
                StartActivity(i);
            };

            //Tombol ke kanan ning category

            Button bttn2 = FindViewById<Button>(Resource.Id.button2);
            bttn2.Click += delegate
            {
                Intent i = new Intent(this, typeof(CategoryView));
                StartActivity(i);
            };
        }


        public HomeView() { }
    }
}