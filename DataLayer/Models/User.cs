using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProject.DataLayer.Models
{
    public class User
    {
        public User()
        {
            FilmHistory = new List<FilmStory>();
        }
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool isAdmin { get; set; }
        public IEnumerable<FilmStory> FilmHistory { get; set; }
    }
}
