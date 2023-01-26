using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Domain.Entities
{
    public class Cost
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public decimal? PerDay { get; set; }
        public decimal? PerKm { get; set; }
        public decimal? PerTour { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get; set; }
    }
}
