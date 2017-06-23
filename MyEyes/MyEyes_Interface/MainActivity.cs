using Android.App;
using Android.Widget;
using Android.OS;

namespace MyEyes
{
    [Activity(Label = "MyEyes", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            Button Confirmar = FindViewById<Button>(Resource.Id.Capturar);
            Confirmar.Click += delegate { Teste(); };

            Button Repetir = FindViewById<Button>(Resource.Id.Repetir);
            Repetir.Click += delegate { Teste(); };
        }

        public void Confirmar()
        {

        }

        public void Confirmar()
        {

        }

        public void Confirmar()
        {

        }
    }
}

