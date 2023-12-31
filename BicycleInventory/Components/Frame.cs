using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleInventory.Components
{
    public class Frame : ProductComponent<Frame>, ICycle

    {
        private List<ICycle> components = new List<ICycle>();

        private int cycleCount=0;
      
        public Frame(int partCount)
        {
           
         PartCount = partCount;
            
        }
        public void AddComponent(ICycle component)
        {
            components.Add(component);
        }

        public override int GetFinishedProductCount()
        {
            // Check for required components
            int requiredWheels = 2;
            int requiredSeat = 1;
            int requiredPedals = 2;
            int requiredBody = 1;

            int wheelCount = 0;
            int seatCount = 0;
            int pedalCount = 0;
            int bodyCount = 0;

            foreach (var component in components)
            {
                if (component is Wheels ) {
                   Wheels comp = (Wheels)component;
                    wheelCount += comp.GetFinishedProductCount();
                }
                seatCount += (component is Seat) ? component.PartCount : 0;
                pedalCount += (component is Pedal) ? component.PartCount : 0;
                bodyCount += (component is Frame) ? component.PartCount : 0;
                
                while(wheelCount >= requiredWheels &&
                     seatCount >= requiredSeat &&
               pedalCount >= requiredPedals &&
               bodyCount >= requiredBody)
                {
                    cycleCount += 1;
                    wheelCount-=requiredWheels;
                    seatCount-=requiredSeat;
                    pedalCount-=requiredPedals;
                    bodyCount-=requiredBody;
                }
            }

           

            return cycleCount;
        }







    }
}
