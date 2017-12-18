using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System.Linq;

namespace ABCTaxi
{
    [Activity(MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            RegisterButtonClickEvents();
        }

        void RegisterButtonClickEvents()
        {
            FindViewById(Resource.Id.buttonCall).Click += delegate
            {
                buttonCall_Click();
            };
        }

        public void buttonCall_Click()
        {
            // kod
        }
    }
}

