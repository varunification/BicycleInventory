﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleInventory.Components
{
    public class Tube : ProductComponent<Tube>, IWheelComponent
    {
        public Tube(int partCount)
        {
            PartCount = partCount;
        }

        public override int GetFinishedProductCount()
        {
            return PartCount; 
        }
    }
}
