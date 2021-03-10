using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerMob.Entities
{
    class Attendee : UserEntity
    {
        public Attendee(){}

        //public string Name { get; set; }
        //public string Surname { get; set; }
        public ActionA Action { get; set; }

        public DateTimeOffset TimeStamp { get; set; }
    }

    public enum ActionA
    {
        Joined, 
        Joined_before,
        Left
    }
}
