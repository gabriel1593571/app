using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace mais_de_uma_activity
{
    [Activity(Label = "mais_de_uma_activity", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            Button btnFone = FindViewById<Button>(Resource.Id.btnFone);
            Button btnWeb = FindViewById<Button>(Resource.Id.btnWeb);
            Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);

            btnFone.Click += BtnFone_Click;
            btnWeb.Click += BtnWeb_Click;
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            var loginAtividade = new Intent(this, typeof(LoginActivity));
            loginAtividade.PutExtra("Nome", "Gabriel");
            loginAtividade.PutExtra("Senha", "159357");
            StartActivity(loginAtividade);
        }

        private void BtnWeb_Click(object sender, System.EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("https://www.youtube.com/watch?v=fe4fyhzS3UM");
            var intentWeb = new Intent(Intent.ActionView, uri);
            StartActivity(intentWeb);
        }



        private void BtnFone_Click(object sender, System.EventArgs e)
        {
            var uri = Android.Net.Uri.Parse("tel:111222333");
            var intentFone = new Intent(Intent.ActionDial, uri);
            StartActivity(intentFone);
        }
    }
}

