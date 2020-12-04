using Xamarin.Forms;

namespace PlannerMob
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void MenuItem_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.DisplayAlert("Title", "Poruka", "Ok");
        }
    }
}
