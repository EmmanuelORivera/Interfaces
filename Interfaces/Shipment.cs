using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public class Shipment
	{
        public int Id { get; set; }
        public DateTime ShippingDate { get; set; }
        public string Destination { get; set; }
        public float Cost { get; set; }
    }
}
