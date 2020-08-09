using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Views;


namespace iFashion_3.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme.Base")]
    class ProfileView : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            //Set our view from the "main" layout resource
            SetContentView(Resource.Layout.profile);

            Button bttn1 = FindViewById<Button>(Resource.Id.button1);
            bttn1.Click += delegate
            {
                Intent i = new Intent(this, typeof(CategoryView));
                StartActivity(i);
            };

            Button bttn2 = FindViewById<Button>(Resource.Id.button2);
            bttn2.Click += delegate
            {
                Intent i = new Intent(this, typeof(HomeView));
                StartActivity(i);
            };

        }
        public void creteView(Bundle savedInstanceState)
        {
            OnCreate(savedInstanceState);
        }

        public ProfileView() { }
    }
}