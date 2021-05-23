using PlannerMob.Pages;
using Xamarin.Forms;

namespace PlannerMob
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute($"{nameof(AttendeeView)}", typeof(AttendeeView));
        }

        private async void MenuItem_Clicked(object sender, System.EventArgs e) => await Shell.Current.GoToAsync($"//{nameof(RegistrationPage)}");
        
    }
}
