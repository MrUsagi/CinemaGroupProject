using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaProject.DataLayer.Models
{
    public class Hall
    {
        public Hall()
        {
            Rows = new List<Row>();
            Shows = new List<Show>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public IEnumerable<Row> Rows { get; set; } 
        public IEnumerable<Show> Shows { get; set; }
        public string Name { get; set; }
    }
}
