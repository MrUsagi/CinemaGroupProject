using CinemaProject.DataLayer.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaProject.DataLayer.Models
{
    public class Place
    {
        public int Id { get; set; }
        public int RowId { get; set; }
        public Row Row { get; set; }
        public int Number { get; set; }
        public Status Status { get; set; }
    }
}
