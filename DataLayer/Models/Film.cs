using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProject.DataLayer.Models
{
    public class Film
    {
        public Film()
        {
            Shows = new List<Show>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public double Rating { get; set; }
        public IEnumerable<Show> Shows { get; set; }
    }
}
