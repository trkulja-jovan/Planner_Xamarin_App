using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PlannerMob.Entities
{
    public class Attendee : UserEntity
    {
        public Attendee(){}

        public double TotalTime { get; set; }

        public int Percentage { get; set; }

        public static Attendee Create(string username, double totalTime, int percentage)
        {
            return new Attendee
            {
                Username = username,
                TotalTime = totalTime,
                Percentage = percentage
            };
        }
    }

    public enum ActionAttendee
    {
        Joined, 
        Joined_before,
        Left
    }
}
