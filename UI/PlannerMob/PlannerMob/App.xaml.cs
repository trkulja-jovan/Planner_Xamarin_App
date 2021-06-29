using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PlannerMob.Entities.Mettings;
using PlannerMob.Pages;
using PlannerMob.Refit.DTO.Meeting;
using PlannerMob.Refit.Interfaces;
using PlannerMob.Refit.ServiceImplementation;
using System;
using Xamarin.Forms;

namespace PlannerMob
{
    public partial class App : Application
    {
        public static IMapper Mapper = CreateMapper();
        protected static IServiceProvider ServiceProvider { get; set; }
        public App()
        {
            InitializeComponent();
            SetupService();

            MainPage = new AppShell();
        }
        protected async override void OnStart()
        {
            await Shell.Current.GoToAsync($"//{nameof(RegistrationPage)}");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<MeetingDto, Meeting>();
            });

            return config.CreateMapper();
        }

        private void SetupService()
        {
            var services = new ServiceCollection();

            // Add core services
            services.AddSingleton<IMeetingService, MeetingServiceImplementation>();

            ServiceProvider = services.BuildServiceProvider();
        }

        public static T GetService<T>() where T : class => ServiceProvider.GetService<T>();
    }
}
