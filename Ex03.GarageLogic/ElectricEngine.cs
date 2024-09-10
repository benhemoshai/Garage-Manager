using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class ElectricEngine : Engine
    {
        public void ChargeBattery(float i_AmountToCharge)
        {
            if (CurrentEnergy + i_AmountToCharge <= MaxEnergy)
            {
                CurrentEnergy += i_AmountToCharge;
            }
            else
            {
                throw new ValueOutOfRangeExceptions(0, MaxEnergy - CurrentEnergy);
            }
        }

        public override string ToString()
        {
            return string.Format("Current Energy: {0}/{1} hours", CurrentEnergy, MaxEnergy);
        }
    }
}
