using System;
using System.Collections.Generic;
using System.Text;
using PlannerMob.Entities;
using PlannerMob.Service;

namespace PlannerMob.ViewModels
{
    class AttendeeViewModel
    {
        public List<Attendee> Attendees { get; set; }

        public AttendeeViewModel()
        {
            Attendees = new AttendeeService().GetAttendeeList();
        }
    }
}
