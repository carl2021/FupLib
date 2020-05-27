using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTfup.Model
{
    public class TransportTab
    {
        public int Id { get; set; }
        public string Lastbil { get; set; }
        public string Chauffer { get; set; }
        public DateTime Dato { get; set; }
        public int AntalKm { get; set; }
        public double Average { get; set; }

    }
}
