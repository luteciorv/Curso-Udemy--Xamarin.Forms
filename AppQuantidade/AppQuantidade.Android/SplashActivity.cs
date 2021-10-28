using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppQuantidade.Droid
{
    [Activity(Label = "Quantidade", Icon = "@mipmap/ic_launcher", MainLauncher = true, Theme = "@style/MainTheme.Splash", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        { 
            // Esperar o processamento
            base.OnCreate(savedInstanceState);

            // Chamar o MainActivity
            StartActivity(typeof(MainActivity));
            Finish();

            // Desativar animação de slide-in da atividade
            OverridePendingTransition(0, 0);
        }
    }
}