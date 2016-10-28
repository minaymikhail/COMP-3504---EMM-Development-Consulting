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

namespace Pass_App
{
    [Activity(Label = "Login")]
    public class Login : Activity
    {
        Button confirmLoginButton, forgotPasswordButton;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            loadAllBaseViews();
            setUpAllActions();
        }
        private void loadAllBaseViews()
        {
            confirmLoginButton = FindViewById<Button>(Resource.Id.confirmLoginButton);
            forgotPasswordButton = FindViewById<Button>(Resource.Id.forgotPasswordButton);
        }
        private void setUpAllActions()
        {
            confirmLoginButton.Click += ConfirmLoginButton_Click;
            forgotPasswordButton.Click += forgotPasswordButton_Click;
        }
        private void ConfirmLoginButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}