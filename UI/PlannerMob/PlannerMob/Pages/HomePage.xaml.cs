using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PlannerMob.Entities;

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
            createPicker();    
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            Recalculate();
        }
        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            Recalculate();
        }

        void Recalculate()
        {
            TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date +
                (includeSwitch.IsToggled ? TimeSpan.FromDays(1) : TimeSpan.Zero);

            resultLabel.Text = String.Format("{0} dan",
                                                timeSpan.Days, timeSpan.Days == 1 ? "" : "a");
        }


        private void LoadPicker()
        {
            Courses = new ObservableCollection<Course>();
            Courses.Add(new Course { CourseID = 1, CourseName = "Seminarski Rad C"});
            Courses.Add(new Course { CourseID = 2, CourseName = "Baze Podataka 2" });
            Courses.Add(new Course { CourseID = 3, CourseName = "Uvod u programiranje" });
            Courses.Add(new Course { CourseID = 4, CourseName = "Kombinatorika, verovatnoca i statistika" });
        } 

        private void createPicker()
        {
            LoadPicker();

            MainPicker.Title = "Izaberite predmet";
            MainPicker.ItemsSource = (System.Collections.IList)Courses;
           
        }

        


   
    }
}