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
    class RegistView : AppCompatActivity
    {
        EditText _username;
        EditText _password;
        EditText _gender;
        EditText _email;
        EditText _confirmPassword;

        // Reference
        private RegistModel _model;
        private RegistController _ctrl;

        Button _save;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            //Set our view from the "main" layout resource
            SetContentView(Resource.Layout.regist);

            //EditText Username
            _username = FindViewById<EditText>(Resource.Id.editTextUsername);

            // EditText Password
            _password = FindViewById<EditText>(Resource.Id.editTextPassword);

            //EditText Gender
            _gender = FindViewById<EditText>(Resource.Id.editTextGender);

            // EditText Email
            _email = FindViewById<EditText>(Resource.Id.editTextEmail);

            //EditText Confirm Password
            _confirmPassword = FindViewById<EditText>(Resource.Id.editTextConfirmPassword);

            // Button Save
            _save = FindViewById<Button>(Resource.Id.button2);
            _save.Click += delegate
            {
                _model = new RegistModel();
                _ctrl = new RegistController(_model, this);

                // Instance
                _model.username = _username.Text;
                _model.email = _email.Text;
                _model.gender = _gender.Text;
                _model.password = _password.Text;
                _model.confirmPassword = _confirmPassword.Text;
                _ctrl.isTrue();

                
                
            };
        }
        
        public void createViewHome()
        {
            Intent i = new Intent(this, typeof(HomeView));
            StartActivity(i);
        }

        public RegistView() { }
    }
}