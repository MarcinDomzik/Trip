using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Domain.Entities
{
    public class Route
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public int? ParkTime { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get; set; }

    }
}
