using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;

namespace zobrazToastPoClickuNaButton
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
          
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var button =  FindViewById<Button>(Resource.Id.myButton);
            button.Click += Button_Click;


        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "Button clicked", ToastLength.Short).Show();
        }
    }
}