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
using static Android.Support.V4.Widget.DrawerLayout;

namespace Sparkware1
{
    [Activity(Label = "DiscoverActivity")]
    public class DiscoverActivity : Activity
    {
        List<Innovation> innovations = new List<Innovation>();
        Innovation innovation1 = new Innovation();
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.discover);

            innovation1.Title = "Innovation1 Title";
            innovation1.Discription = "Innovation1 Description";
            innovation1.NumberOfLikes = 2000;

            innovations.Add(innovation1);

            LinearLayout ll = new LinearLayout(this);
            LinearLayout.LayoutParams param = new LinearLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);
            ll.LayoutParameters = param;
            LinearLayout parent = FindViewById<LinearLayout>(Resource.Id.discoverParent);

            ll.Orientation = Orientation.Horizontal;
            ll.SetBackgroundResource(Resource.Drawable.customshape);



            parent.AddView(ll);


            // Create your application here test test
        }
    }
}