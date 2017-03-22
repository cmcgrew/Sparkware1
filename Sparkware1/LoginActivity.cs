using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Sparkware1
{
    [Activity(Label = "Sparkware1", MainLauncher = true, Icon = "@drawable/icon")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Login);

            EditText etUsername = FindViewById<EditText>(Resource.Id.etUsername);
            EditText etPassword = FindViewById<EditText>(Resource.Id.etPassword);
            Button bLogin = FindViewById<Button>(Resource.Id.bLogin);

            bLogin.Click += BLogin_Click;
        }

        private void BLogin_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(HomeActivity));
            StartActivity(intent);
            this.Finish();
        }
    }
}

