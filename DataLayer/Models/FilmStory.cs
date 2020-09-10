using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProject.DataLayer.Models
{
    public class FilmStory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ShowId { get; set; }
        public Show Show { get; set; }
        public int Row { get; set; }
        public int Place { get; set; }
    }
}
