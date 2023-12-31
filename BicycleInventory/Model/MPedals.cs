using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleInventory.Model
{
    public class MPedals
    {
        [Key]
        public int PedalsId { get; set; }
        public string PedalType { get; set; }
        public int quantity { get; set; }
    }
}
