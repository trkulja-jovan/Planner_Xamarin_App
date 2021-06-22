using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerMob.Entities.Mettings
{
    public class Meeting : BaseModel
    {
        private string _name;
        private int _attendeeCount;

        public Guid Id { get; set; }
        public string Name 
        { 
            get => _name; 
            set => SetProperty(ref _name, value); 
        }
        public string Organizer { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int AtendeeCount 
        { 
            get => _attendeeCount; 
            set => SetProperty(ref _attendeeCount, value); 
        }
    }
}
