using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaProject.DataLayer.Models
{
    public class Row
    {
        public Row()
        {
            Places = new List<Place>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Number { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        public IEnumerable<Place> Places { get; set; }
    }
}
