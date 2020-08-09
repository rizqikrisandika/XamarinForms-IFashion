using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using iFashion_3.Models;
using iFashion_3.Views;
using iFashion_3.Controllers;
using Android.Widget;

namespace iFashion_3
{
    
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {

            // Set our view from the "main" layout resource

            //Login _model = new Login();
            //LoginView _view = new LoginView();
            //LoginController _ctrl = new LoginController(_model, _view);
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login);
            //_ctrl.createLoginView(savedInstanceState);

        }
    }
}