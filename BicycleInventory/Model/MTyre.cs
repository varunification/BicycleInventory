using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleInventory.Model
{
    public class MTyre
    {
        [Key]
        public int TyreId { get; set; }
        public string TyreType { get; set; }
        public int quantity { get; set; }
    }
}
