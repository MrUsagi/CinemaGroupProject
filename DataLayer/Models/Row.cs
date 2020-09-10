using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProject.DataLayer.Models
{
    public class Row
    {
        public Row()
        {
            Places = new List<Place>();
        }
        public int Id { get; set; }
        public int Number { get; set; }
        public IEnumerable<Place> Places { get; set; }
    }
}
