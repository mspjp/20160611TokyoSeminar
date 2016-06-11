using Android.App;
using Android.OS;
using Android.Widget;
using System;

namespace NativeSample.Droid
{
    [Activity(Label = "NativeSample.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.myButton);
            TextView text = FindViewById<TextView>(Resource.Id.myText);

            button.Click += async (sender, e) =>
            {
                text.Text = "Loading...";
                String result = await MyClass.GetSearchResult("android");
                text.Text = result;
            };
        }
    }
}