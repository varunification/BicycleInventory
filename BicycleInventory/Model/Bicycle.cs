using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleInventory.Model
{
    public class Bicycle
    {
        public int BicycleId { get; set; }
        public string Model { get; set; }

        // Navigation properties
        public Frame Frame { get; set; }
        public Wheels Wheels { get; set; }
        public Pedals Pedals { get; set; }
        public Seat Seat { get; set; }
    }
}
