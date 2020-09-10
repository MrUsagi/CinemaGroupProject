using CinemaProject.DataLayer.Context;
using CinemaProject.DataLayer.Repository;
using CinemaProject.DataLayer.UOW;
using CinemaProject.DataLayer.UOW.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CinemaProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        public IConfiguration Configuration { get; private set; }
        private void ConfigurationService(IServiceCollection services)
        {
            services.AddSingleton<CinemaContext>();
            services.AddSingleton<FilmRepository>();
            services.AddSingleton<FilmStoryRepository>();
            services.AddSingleton<HallRepository>();
            services.AddSingleton<PlaceRepository>();
            services.AddSingleton<RowRepository>();
            services.AddSingleton<ShowRepository>();
            services.AddSingleton<UserRepository>();
            services.AddSingleton(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddTransient(typeof(MainWindow));

            services.AddDbContext<CinemaContext>(option => option.UseSqlServer(Configuration.GetConnectionString("SqlConnection")));

        }
        protected async override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                    .AddJsonFile("appsettings.json", false, reloadOnChange: true);

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigurationService(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();

        }
    }
}
