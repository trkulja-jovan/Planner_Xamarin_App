using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlannerMob.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.IsRegistrationMode = false;
            viewModel.BckSignInColor = Color.Blue;
            viewModel.BckSignUpColor = Color.Transparent;
            viewModel.RegTextColor = Color.Black;
        }
    }
}