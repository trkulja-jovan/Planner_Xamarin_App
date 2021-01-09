using System.Windows.Input;
using Xamarin.Forms;

namespace PlannerMob.ViewModels
{
    public class RegistrationPageViewModel : BaseViewModel
    {
        private bool isRegMode;
        private Color bckIn;
        private Color bckUp;

        public bool IsRegistrationMode
        {
            get => isRegMode;
            set => SetProperty(ref isRegMode, value);
        }

        public Color BckSignInColor
        {
            get => bckIn;
            set => SetProperty(ref bckIn, value);
        }
        public Color BckSignUpColor
        {
            get => bckUp;
            set => SetProperty(ref bckUp, value);
        }

        public ICommand SwitchMode { get; set; }

        public RegistrationPageViewModel()
        {
            SwitchMode = new Command<string>(parameter =>
            {
                if(parameter is "SignUp")
                {
                    IsRegistrationMode = true;
                    BckSignUpColor = Color.Blue;
                    BckSignInColor = Color.Transparent;
                } else
                {
                    IsRegistrationMode = false;
                    BckSignInColor = Color.Blue;
                    BckSignUpColor = Color.Transparent;
                }
            });
        }
    }
}
