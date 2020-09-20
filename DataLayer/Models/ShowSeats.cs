using CinemaProject.DataLayer.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaProject.DataLayer.Models
{
    public class ShowSeats
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SeatId { get; set; }
        public Place Seat { get; set; }
        public int ShowId { get; set; }
        public Show Show { get; set; }
        public Status Status { get; set; }
    }
}
