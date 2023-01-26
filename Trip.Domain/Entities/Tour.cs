using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Domain.Entities
{
    public class Tour
    {
        public string Name { get; set; }
        public string? Desc { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int? DriverId { get; set; }
        public Driver Driver { get; set; }
        public int? CarId { get; set; }
        public Car Car { get; set; }
        public Cost Cost { get; set; }
        public ICollection<Route> routes { get; set; }
    }
}
