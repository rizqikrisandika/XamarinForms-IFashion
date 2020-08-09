using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Views;


namespace iFashion_3.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme.Base", MainLauncher = true)]
    class regist_loginView : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            //Set our view from the "main" layout resource
            SetContentView(Resource.Layout.regist_login);


            Button login = FindViewById<Button>(Resource.Id.btn_login);
            login.Click += delegate
            {
                Intent i = new Intent(this, typeof(LoginView));
                StartActivity(i);
            };


            Button regist = FindViewById<Button>(Resource.Id.btn_regist);
            regist.Click += delegate
            {
                Intent i = new Intent(this, typeof(RegistView));
                StartActivity(i);
            };

        }
        public void creteView(Bundle savedInstanceState)
        {
            OnCreate(savedInstanceState);
        }

        public regist_loginView() { }
    }
}