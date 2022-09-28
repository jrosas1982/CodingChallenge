using Core.Challenge.Application.Interface;
using Core.Challenge.Application.Service;
using Core.Challenge.Repository.Shapes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Challenge.Application
{
    public static class DependencyInjection
    {
        public static void AddCoreServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IReporteFigurasService, ReporteFigurasService>();
            serviceCollection.AddTransient<IShapeRepository, ShapeRepository>();
            serviceCollection.AddTransient<IReporting, Reporting>();
        }
    }
}
