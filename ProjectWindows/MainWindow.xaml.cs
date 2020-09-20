using CinemaProject.BuisnessLogic;
using CinemaProject.ProjectWindows;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CinemaProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainService _service;
        public MainWindow(MainService service)
        {
            InitializeComponent();
            _service = service;
        }

        private void AddMovieClick(object sender, RoutedEventArgs e)
        {
            MovieWindow window = new MovieWindow();
            this.Close();
            window.Show();
        }

        private void AddHallClick(object sender, RoutedEventArgs e)
        {
            AddHallWindow window = new AddHallWindow();
            this.Close();
            window.Show();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await _service.LoadFilms(MoviesPanel);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = App.ServiceProvider.GetRequiredService<LoginWindow>();
            window.Show();
            this.Close();
        }
    }
}
