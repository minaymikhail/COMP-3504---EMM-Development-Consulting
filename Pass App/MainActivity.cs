using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Pass_App
{
    [Activity(Label = "Pass_App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button loginButton, signupButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            loadAllBaseViews();
            setUpAllActions();
        }

        private void loadAllBaseViews()
        {
            loginButton = FindViewById<Button>(Resource.Id.loginButton);
            signupButton = FindViewById<Button>(Resource.Id.signupButton);
        }

        private void setUpAllActions()
        {
            loginButton.Click += LoginButton_Click;
            signupButton.Click += SignupButton_Click;
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

