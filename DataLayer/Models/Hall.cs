using System;
using System.Collections.Generic;
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
        public int Id { get; set; }
        public IEnumerable<Row> Rows { get; set; } 
        public IEnumerable<Show> Shows { get; set; }
        public string Name { get; set; }
    }
}
