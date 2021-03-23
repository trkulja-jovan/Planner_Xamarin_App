using Xamarin.Forms;

namespace PlannerMob
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "Brush_Experimental" });
            MainPage = new AppShell();
        }
        protected override void OnStart()
        {
            Shell.Current.GoToAsync("//registrationPage");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
