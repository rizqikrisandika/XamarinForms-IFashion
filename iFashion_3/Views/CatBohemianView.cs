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
    class CatBohemianView : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            //Set our view from the "main" layout resource
            SetContentView(Resource.Layout.category_bohemian);

        }
        public void creteView(Bundle savedInstanceState)
        {
            OnCreate(savedInstanceState);
        }

        public CatBohemianView() { }
    }
}