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
    class Innovation
    {
        public Innovation()
        {

        }

        public string Title { get; set; }
        public string Discrption { get; set; }
        public string Picture { get; set; }
        public int NumberOfLikes { get; set; }
        public List<string> Comments { get; set; }
    }
}