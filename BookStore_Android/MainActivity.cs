using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace BookStore_Android
{
    [Activity(Label = "BookStore_Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }
    }
}

