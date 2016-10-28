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
    public class EditStudentProfile : Activity
    {
        Button submitButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.EditStudentProfile);

            loadAllBaseViews();
            setUpAllActions();
        }

        private void loadAllBaseViews()
        {
            submitButton = FindViewById<Button>(Resource.Id.submitButton);
        }

        private void setUpAllActions()
        {
            submitButton.Click += SubmitButton_Click;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

