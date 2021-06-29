using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerMob.Refit.BaseService
{
    public class BaseService
    {
        protected T GetServiceFor<T>() where T : class => RestService.For<T>("https://microsoftteamsplanner.azurewebsites.net");
    }
}
