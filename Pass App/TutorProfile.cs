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
    public class TutorProfile : Activity
    {
        Button editProfileButton, createSessionButton, viewEditSessionButton, confirmSessionAttendanceButton, contactSLCButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.TutorProfile);

            loadAllBaseViews();
            setUpAllActions();
        }

        private void loadAllBaseViews()
        {
            editProfileButton = FindViewById<Button>(Resource.Id.editProfileButton);
            createSessionButton = FindViewById<Button>(Resource.Id.createSessionButton);
            viewEditSessionButton = FindViewById<Button>(Resource.Id.viewEditSessionButton);
            confirmSessionAttendanceButton = FindViewById<Button>(Resource.Id.confirmSessionAttendanceButton);
            contactSLCButton = FindViewById<Button>(Resource.Id.submitButton);
        }

        private void setUpAllActions()
        {
            editProfileButton.Click += EditProfileButton_Click;
            createSessionButton.Click += CreateSessionButton_Click;
            viewEditSessionButton += ViewEditSessionButton_Click;
            confirmSessionAttendanceButton.Click += ConfirmSessionAttendanceButton_Click;
            contactSLCButton.Click += ContactSLCButton_Click;
        }

        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void CreateSessionButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ViewEditSessionButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ConfirmSessionAttendanceButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ContactSLCButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}

