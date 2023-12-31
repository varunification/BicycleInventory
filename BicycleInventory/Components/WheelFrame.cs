using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleInventory.Components
{
    public class WheelFrame : ProductComponent<WheelFrame>, IWheelComponent, ICycle
    {
        public WheelFrame(int partCount)
        {
            PartCount = partCount;
        }

        public override int GetFinishedProductCount()
        {
            return PartCount;
        }
    }
}
