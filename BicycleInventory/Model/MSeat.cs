using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleInventory.Model
{
    public class MSeat
    {
        [Key]
        public int SeatId { get; set; }
        public string SeatType { get; set; }
        public int quantity { get; set; }
    }
}
