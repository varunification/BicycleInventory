using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleInventory.Components
{
    public class Seat : ProductComponent<Seat>, ICycle
    {
        public Seat(int partCount)
        {
            PartCount = partCount;
        }

        public override int GetFinishedProductCount()
        {
            return PartCount;
        }
    }
}
