using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaProject.DataLayer.Models
{
    public class FilmStory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ShowId { get; set; }
        public Show Show { get; set; }
        public int Row { get; set; }
        public int Place { get; set; }
    }
}
