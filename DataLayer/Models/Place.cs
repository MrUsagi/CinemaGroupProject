using CinemaProject.DataLayer.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaProject.DataLayer.Models
{
    public class Place
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int RowId { get; set; }
        public Row Row { get; set; }
        public int Number { get; set; }
        public Status Status { get; set; }
    }
}
