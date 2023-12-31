using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleInventory.Components
{
    public abstract class ProductComponent<T>: ICycle
    {
        public int PartCount { get; set; }
        public abstract int GetFinishedProductCount();
    }
}