using Android.App;
using Android.OS;
using Android.Widget;
using System;

namespace NavegationIntent
{
    [Activity(Label = "Activity1")]
    public class Tela2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.Tela2);
            base.OnCreate(savedInstanceState);

            Button btn2 = FindViewById<Button>(Resource.Id.button2);
            btn2.Click += Btn2_Click;
            // Create your application here
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Finish();
        }
        
    }
}