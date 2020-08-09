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
    class CategoryView : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            //Set our view from the "main" layout resource
            SetContentView(Resource.Layout.category);

            Button bttn1 = FindViewById<Button>(Resource.Id.button1);
            bttn1.Click += delegate
            {
                Intent i = new Intent(this, typeof(HomeView));
                StartActivity(i);
            };

            Button bttn2 = FindViewById<Button>(Resource.Id.button2);
            bttn2.Click += delegate
            {
                Intent i = new Intent(this, typeof(ProfileView));
                StartActivity(i);
            };

            TextView category = FindViewById<TextView>(Resource.Id.vintage);
            category.Click += delegate
            {
                Intent i = new Intent(this, typeof(CatVintageView));
                StartActivity(i);
            };
            TextView category2 = FindViewById<TextView>(Resource.Id.casual);
            category2.Click += delegate
            {
                Intent i = new Intent(this, typeof(CatCasualView));
                StartActivity(i);
            };
            TextView category3 = FindViewById<TextView>(Resource.Id.monochrome);
            category3.Click += delegate
            {
                Intent i = new Intent(this, typeof(CatMonochromeView));
                StartActivity(i);
            };
            TextView category4 = FindViewById<TextView>(Resource.Id.retro);
            category4.Click += delegate
            {
                Intent i = new Intent(this, typeof(CatRetroView));
                StartActivity(i);
            };
            TextView category5 = FindViewById<TextView>(Resource.Id.classy);
            category5.Click += delegate
            {
                Intent i = new Intent(this, typeof(CatClassyView));
                StartActivity(i);
            };
            TextView category6 = FindViewById<TextView>(Resource.Id.formal);
            category6.Click += delegate
            {
                Intent i = new Intent(this, typeof(CatFormalView));
                StartActivity(i);
            };
            TextView category7 = FindViewById<TextView>(Resource.Id.edgy);
            category7.Click += delegate
            {
                Intent i = new Intent(this, typeof(CatEdgyView));
                StartActivity(i);
            };
            TextView category8 = FindViewById<TextView>(Resource.Id.oversize);
            category8.Click += delegate
            {
                Intent i = new Intent(this, typeof(CatOversizeView));
                StartActivity(i);
            };
            TextView category9 = FindViewById<TextView>(Resource.Id.bohemian);
            category9.Click += delegate
            {
                Intent i = new Intent(this, typeof(CatBohemianView));
                StartActivity(i);
            };
        }
        public void creteView(Bundle savedInstanceState)
        {
            OnCreate(savedInstanceState);
        }

        public CategoryView() { }
    }
}