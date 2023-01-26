using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public string Transmission { get; set; }
        public string Colour { get; set; }
        public int NoOfSeats { get; set; }
        public ICollection<Tour> tours { get; set; }
    }
}
