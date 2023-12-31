using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleInventory.Model
{
    public class MBicycle
    {
        [Key]
        public int BicycleId { get; set; }
        public string Model { get; set; }

        public int quantity { get; set; }   

        [ForeignKey("FrameId")]
        public MFrame Frame { get; set; }

        [ForeignKey("WheelsId")]
        public MWheels Wheels { get; set; }

        [ForeignKey("PedalsId")]
        public MPedals Pedals { get; set; }

        [ForeignKey("SeatId")]
        public MSeat Seat { get; set; }
    }
}
