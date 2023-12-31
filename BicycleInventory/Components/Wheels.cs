using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleInventory.Components
{
    internal class Wheels : ProductComponent<Wheels>, ICycle
    {
        private List<IWheelComponent> components = new List<IWheelComponent>();
        public void AddComponent(IWheelComponent component)
        {
            components.Add(component);
        }
        public override int GetFinishedProductCount()
        {
            int frameCount = 0;
            int tubeCount = 0;

            foreach (var component in components)
            {
                frameCount += (component is WheelFrame) ? component.PartCount : 0;
                tubeCount += (component is Tube) ? component.PartCount : 0;
            }

            // Assuming a wheel is finished if it has at least one frame and one tube
            return PartCount=Math.Min(frameCount, tubeCount);
        }
    }
}
