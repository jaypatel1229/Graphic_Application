using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace Graphic_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button myVectorDemo;
        Button myDrawabledemo;
        Button myCanvasDemo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            myVectorDemo = FindViewById<Button>(Resource.Id.button1);
            myDrawabledemo = FindViewById<Button>(Resource.Id.button2);
            myCanvasDemo = FindViewById<Button>(Resource.Id.button3);


            myVectorDemo.Click += MyVectorDemo_Click;
            myDrawabledemo.Click += MyDrawabledemo_Click;
            myCanvasDemo.Click += MyCanvasDemo_Click;
        }

        private void MyCanvasDemo_Click(object sender, System.EventArgs e)
        {
            Intent k = new Intent(Application.Context, typeof(CanvasDemo));
            StartActivity(k);
        }

        private void MyDrawabledemo_Click(object sender, System.EventArgs e)
        {
            Intent j = new Intent(Application.Context, typeof(DrawableDemo));
            StartActivity(j);
        }

        private void MyVectorDemo_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(Application.Context, typeof(VectorDemo));
            StartActivity(i);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}