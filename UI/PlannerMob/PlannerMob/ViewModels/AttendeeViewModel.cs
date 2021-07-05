using PlannerMob.Entities;
using PlannerMob.Service;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

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

        public ICommand ClickCommand { get; set; }

        public AttendeeViewModel()
        {
            _attendeeService = new AttendeeService();

            ClickCommand = new Command(async () =>
            {
                await Shell.Current.DisplayAlert("Prikaz detalja", "Prisustvuje od početka: NE \n Sastanku se priključila: 12:05 \n Sastanak napustila: 12:43", "Zatvori");
            });
        }

        internal void OnAppearing()
        {
            //_attendeeService.GetAttendeeList().ForEach(attendee => Attendees.Add(attendee));

            Attendees.Add(Attendee.Create("Đorđe Herceg", 75, 100));
            Attendees.Add(Attendee.Create("Bojan Đerčan", 11, 15));
            Attendees.Add(Attendee.Create("Marko Rodić", 5, 7));
            Attendees.Add(Attendee.Create("Slobodanka Pajević", 66, 88));
            Attendees.Add(Attendee.Create("Ljiljana Cvetković", 65, 87));
            Attendees.Add(Attendee.Create("Snežana Radenković", 63, 85));
            Attendees.Add(Attendee.Create("Mladen Horvatović", 63, 84));
            Attendees.Add(Attendee.Create("Dubravka Milić", 1, 1));
            Attendees.Add(Attendee.Create("Milka Bubalo Živković", 2, 2));

        }
    }
}
