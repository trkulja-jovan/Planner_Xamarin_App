using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PlannerMob.Entities
{
    public class Attendee : UserEntity
    {
        public Attendee(){}

        public ActionAttendee Action { get; set; }

        public DateTime TimeStamp { get; set; }

        public string ImageUrl { get; set; }
    }

    public enum ActionAttendee
    {
        Joined, 
        Joined_before,
        Left
    }
}
