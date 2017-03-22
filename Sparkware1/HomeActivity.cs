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

namespace Sparkware1
{
    [Activity(Theme="@style/CustomActionBarTheme")]
    public class HomeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ActionBar.SetCustomView(Resource.Layout.home);
            ActionBar.SetDisplayShowCustomEnabled(true);
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            //var tab = this.ActionBar.NewTab();
            //tab.SetText("TEST");
            //tab.SetIcon(Resource.Drawable.world);

            //tab.TabSelected += delegate (object sender, ActionBar.TabEventArgs e) {
            //    e.FragmentTransaction.Add(Resource.Id.fragmentContainer,
            //        new SampleTabFragment());
            //};

            SetContentView(Resource.Layout.userpage);

            LinearLayout linLayoutDiscover = (LinearLayout)ActionBar.CustomView.FindViewById<LinearLayout>(Resource.Id.linLayoutDiscover);
            LinearLayout linLayoutHome = (LinearLayout)ActionBar.CustomView.FindViewById<LinearLayout>(Resource.Id.linLayoutHome);
            LinearLayout linLayoutSubmitIdea = (LinearLayout)ActionBar.CustomView.FindViewById<LinearLayout>(Resource.Id.linLayoutSubmitIdea);
            LinearLayout linLayoutMyAccount = (LinearLayout)ActionBar.CustomView.FindViewById<LinearLayout>(Resource.Id.linLayoutMyAccount);

            //linLayoutHome.Touch += LinLayoutHome_Touch;
            //linLayoutDiscover.Touch += LinLayoutDiscover_Touch;
            //linLayoutDiscover.Touch += LinLayoutSubmitIdea_Touch;
            //linLayoutMyAccount.Touch += LinLayoutMyAccount_Touch;

            linLayoutHome.Click += LinLayoutHome_Click;
            linLayoutDiscover.Click += LinLayoutDiscover_Click;
            linLayoutSubmitIdea.Click += LinLayoutSubmitIdea_Click;
            linLayoutMyAccount.Click += LinLayoutMyAccount_Click;

        }

        private void FindViews()
        {

        }

        private void HandleEvents()
        {

        }

        private void LinLayoutMyAccount_Click(object sender, EventArgs e)
        {
           // Intent intent = new Intent(this, typeof(LoginActivity));
            StartActivity(typeof(DiscoverActivity));
            //this.Finish();
            //SetContentView(Resource.Layout.my_account);
        }

        private void LinLayoutSubmitIdea_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.submit_idea);
        }

        private void LinLayoutDiscover_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.discover);
        }

        private void LinLayoutHome_Click(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.userpage);
        }

        /*private void LinLayoutDiscover_Touch(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.discover);
        }

        private void LinLayoutHome_Touch(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.userpage);
        }
        
        private void LinLayoutSubmitIdea_Touch(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.submit_idea);
        }
        
        private void LinLayoutMyAccount_Touch(object sender, EventArgs e)
        {
            SetContentView(Resource.Layout.my_account);
        }*/
    }
}