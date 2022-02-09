using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graphic_App
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    class CanvasDemo : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            View v = new CanDemoView(this);
            SetContentView(v);
        }

    }

    public class CanDemoView : View
    {
        public CanDemoView(Context context) : base(context)
        {

        }

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);

            var paintBV = new Paint();
            paintBV.Color = Color.BlueViolet;
            paintBV.SetStyle(Paint.Style.FillAndStroke);

            var paintY = new Paint();
            paintY.Color = Color.Yellow;
            paintY.SetStyle(Paint.Style.FillAndStroke);

            float middle = canvas.Width * 0.50f;

            canvas.DrawPaint(paintBV);

            canvas.DrawRect(0, 0, middle, 500, paintY);




        }
    }
}