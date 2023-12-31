using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleInventory.Model
{
    public class MWheels
    {
        public int WheelsId { get; set; }
        public int quantity { get; set; }

        [ForeignKey("TyreId")]
        public MTyre Tyre { get; set; }

        [ForeignKey("WheelFrameId")]
        public MWheelFrame WheelFrame { get; set; }
    }
}
