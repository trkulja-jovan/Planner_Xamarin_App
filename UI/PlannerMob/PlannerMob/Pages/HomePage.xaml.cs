using PlannerMob.Entities;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlannerMob.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public IList<Course> Courses { get; set; }

        public HomePage()
        {
            InitializeComponent(); 
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.InitializePage();
        }
    }
}