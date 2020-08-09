using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Views;

using iFashion_3.Models;
using iFashion_3.Controllers;


namespace iFashion_3.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme.Base")]
    class LoginView : AppCompatActivity
    {
        private LoginModel _model;
        private LoginController _ctrl;



        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            //Set our view from the "main" layout resource
            SetContentView(Resource.Layout.login);

            //Refrence
            _model = new LoginModel();
            _ctrl = new LoginController(_model,this);

            // Plain text username
            EditText username = FindViewById<EditText>(Resource.Id.editTextusername);

            //plain Text Password
            EditText password = FindViewById<EditText>(Resource.Id.editTextPassword);

            //Button Login
            Button btn2 = FindViewById<Button>(Resource.Id.button2);
            btn2.Click += delegate
            {
                _model.username = username.Text;
                _model.password = password.Text;
                _ctrl.readDatabase(_model.username, _model.password);
                
            };
            

            //Event untuk Registrasi
            TextView create = FindViewById<TextView>(Resource.Id.textView2);
            create.Click += delegate
            {
                createRegistView();
            };
        }

        // Rendering

        public void showError()
        {

        }

        public void createHomeview()
        {
            Intent i = new Intent(this, typeof(HomeView));
            StartActivity(i);
        }

        public void createRegistView()
        {
            Intent i = new Intent(this, typeof(RegistView));
            StartActivity(i);
        }

        public LoginView() { }

        public void creteView(Bundle savedInstanceState)
        {
            OnCreate(savedInstanceState);
        }
    }
}