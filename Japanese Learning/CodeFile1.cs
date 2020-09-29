using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Xamarin.Essentials;
using Android.Net;
using System;
using Java.Net;
namespace Japanese_Learning
{
    //[Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = false)]
    public class CodeFile1 : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Lesson1);

            Button BackButton = FindViewById<Button>(Resource.Id.BackBtn);

            Button ContinueButton = FindViewById<Button>(Resource.Id.ContinueBtn);

            BackButton.Click += (sender, e) =>
            {
                SetContentView(Resource.Layout.activity_main);
            };
            ContinueButton.Click += (sender, e) =>
            {

                
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}