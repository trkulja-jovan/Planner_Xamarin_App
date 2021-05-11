using PlannerMob.Entities;
using PlannerMob.Pages;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlannerMob.ViewModels
{
    public class RegistrationPageViewModel : BaseViewModel
    {
        private bool isRegMode;
        private string username;
        private string password;
        private string email;
        private string hometown;
        private string school;
        private string name;
        private string surname;
        private Color bckIn;
        private Color bckUp;
        private Color regTextCol;

        public string Username
        {
            get => username;
            set => SetProperty(ref username, value);
        }
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }
        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        public string Hometown
        {
            get => hometown;
            set => SetProperty(ref hometown, value);
        }
        public string School
        {
            get => school;
            set => SetProperty(ref school, value);
        }
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
        public string Surname
        {
            get => surname;
            set => SetProperty(ref surname, value);
        }

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

        public Color RegTextColor
        {
            get => regTextCol;
            set => SetProperty(ref regTextCol, value);
        }

        public ICommand SwitchMode { get; set; }
        public ICommand Register { get; set; }
        public ICommand SignInCommand { get; set; }

        public RegistrationPageViewModel()
        {
            SignInCommand = new Command(async () =>
            {
                try
                {
                    var usr = UserEntity?.Username;
                    var pass = UserEntity?.Password;

                    if (Username.Equals(usr) && Password.Equals(pass))
                    {
                        Username = "";
                        Password = "";

                        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
                    }
                    else
                    {
                        await Shell.Current.DisplayAlert("Greska", "Pogresni podaci", "Cancel");
                    }
                } catch(Exception e)
                {
                    System.Diagnostics.Debug.Write("Izuzetak -> " + e.StackTrace);
                }

            });

            SwitchMode = new Command<string>(parameter =>
            {
                if(parameter is "SignUp")
                    SetRegistrationForm();
                else
                    SetLoginForm();
            });

            Register = new Command(async () =>
            {
                var entity = new UserEntity
                {
                    Email = Email,
                    Hometown = Hometown,
                    Name = Name,
                    Password = Password,
                    School = School,
                    Surname = Surname,
                    Username = Username
                };

                Username = "";
                Password = "";

                UserEntity = entity;

                await Shell.Current.DisplayAlert("Uspesno", "Uspesno ste se registrovali na sistem", "Ok");
                SetLoginForm();
            });
        }

        private void SetRegistrationForm()
        {
            IsRegistrationMode = true;
            BckSignUpColor = Color.Blue;
            BckSignInColor = Color.Transparent;
            RegTextColor = Color.White;
            Username = "";
            Password = "";
        }

        private void SetLoginForm()
        {
            IsRegistrationMode = false;
            BckSignInColor = Color.Blue;
            BckSignUpColor = Color.Transparent;
            RegTextColor = Color.Black;
        }
    }
}
