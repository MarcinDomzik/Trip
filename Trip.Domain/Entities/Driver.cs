using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Domain.Entities
{
    public class Driver
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? DrLincense { get; set; }
        public ICollection<Tour> tours { get; set; }
    }
}
