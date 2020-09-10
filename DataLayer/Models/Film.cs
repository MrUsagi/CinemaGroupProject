using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaProject.DataLayer.Models
{
    public class Film
    {
        public Film()
        {
            Shows = new List<Show>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public double Rating { get; set; }
        public IEnumerable<Show> Shows { get; set; }
    }
}
