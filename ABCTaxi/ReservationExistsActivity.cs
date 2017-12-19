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

namespace ABCTaxi
{
    [Activity(Label = "ReservationExistsActivity")]
    public class ReservationExistsActivity : Activity
    {
        private static short timeLeft;

        public short TimeLeft
        {
            get
            {
                return timeLeft;
            }
        }

        TextView reservationTextView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.reservation_exists_layout);
            FindViews();
            SetValues();
        }

        void FindViews()
        {
            reservationTextView = (TextView)FindViewById(Resource.Id.reserve_exists_label);
        }

        void SetValues()
        {
            reservationTextView.Text = string.Format($"");
        }
    }
}