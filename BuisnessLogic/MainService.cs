using CinemaProject.DataLayer.Models;
using CinemaProject.DataLayer.UOW.Interfaces;
using CinemaProject.ProjectWindows;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CinemaProject.BuisnessLogic
{
    public class MainService
    {
        private readonly IUnitOfWork _db;
        public MainService(IUnitOfWork db)
        {
            _db = db;
        }
        private async Task<IReadOnlyCollection<Film>> GetFilms()
        {
            return await _db.Films.GetAllAsync();
        }
        public async Task LoadFilms(Panel panel)
        {
            await panel.Dispatcher.InvokeAsync(async () => {
                panel.Children.Clear();
                foreach(var film in await GetFilms())
                {
                    panel.Children.Add(
                        new Button()
                        {
                            Background = new ImageBrush() { ImageSource = (ImageSource) new ImageSourceConverter().ConvertFrom(film.ImageURL)},
                            Tag = film.Name,
                            Height = 220,
                            Width = 160
                        }
                        );
                }
                foreach(var child in panel.Children)
                {
                    if(child is Button btn)
                    {
                        btn.Click += openFilm;
                    }
                }
            });
            
        }

        private async void openFilm(object sender, RoutedEventArgs e)
        {
            var film = await _db.Films.FindByConditionAsync(x => x.Name == (sender as Button).Tag.ToString());
            UserControler.Film = film.FirstOrDefault();
            var window = App.ServiceProvider.GetRequiredService<MovieWindow>();
            window.ShowDialog();
        }
    }
}
