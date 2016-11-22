using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace mais_de_uma_activity
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Login);
            Button btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            Button btnRetornar = FindViewById<Button>(Resource.Id.btnRetornar);

            FindViewById<EditText>(Resource.Id.edtNome).Text = Intent.GetStringExtra("Nome") ?? "erro ao obter os dados";
            FindViewById<EditText>(Resource.Id.edtSenha).Text = Intent.GetStringExtra("Senha") ?? "erro ao obter os dados";


            btnLogin.Click += BtnLogin_Click;
            btnRetornar.Click += BtnRetornar_Click;
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, " <<<Login >> ", ToastLength.Short).Show();
        }
    }
}