using Android.App;
using Android.OS;

namespace QLCT.Droid
{
    [Activity(Theme = "@style/Theme.Splash", //Indicates the theme to use for this activity
            MainLauncher = true, //Set it as boot activity
            NoHistory = true, Label = "Expense Manager", Icon = "@drawable/icon")]
    public class SplashScreenActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            StartActivity(typeof(MainActivity));
        }
    }
}