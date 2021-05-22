using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerMob.Entities
{
    public class Attendee : UserEntity
    {
        public Attendee(){}

        public ActionAttendee Action { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public string ImageUrl { get; set; }
    }

    public enum ActionAttendee
    {
        Joined, 
        Joined_before,
        Left
    }
}
