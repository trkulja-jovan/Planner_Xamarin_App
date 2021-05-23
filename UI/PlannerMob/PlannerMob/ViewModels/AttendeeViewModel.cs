using PlannerMob.Entities;
using PlannerMob.Service;
using System.Collections.ObjectModel;

namespace PlannerMob.ViewModels
{
    public class AttendeeViewModel : BaseViewModel
    {
        private ObservableCollection<Attendee> _attendees = new ObservableCollection<Attendee>();
        public ObservableCollection<Attendee> Attendees 
        { 
            get => _attendees; 
            set => SetProperty(ref _attendees, value); 
        }

        private AttendeeService _attendeeService;

        public AttendeeViewModel()
        {
            _attendeeService = new AttendeeService();
        }

        internal void OnAppearing() => _attendeeService.GetAttendeeList().ForEach(attendee => Attendees.Add(attendee));
    }
}
