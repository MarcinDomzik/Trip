using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Shared.Tours.Queries.AllToursQuery
{
    public class TourForListVm
    {
        public string Name { get; set; }
        public string? Desc { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
