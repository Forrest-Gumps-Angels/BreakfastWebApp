using BreakfastWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastWebApp.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        public List<Occupants> Occupants { get; set; }
    }
}
