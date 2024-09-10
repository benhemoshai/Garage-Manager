using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Engine
    {
        private float m_CurrentEnergy;
        public float MaxEnergy { get; set; }
        public float CurrentEnergy
        {
            get { return m_CurrentEnergy; }
            set
            {
                if (value <= MaxEnergy)
                {
                    m_CurrentEnergy = value;
                }
                else
                {
                    throw new ValueOutOfRangeExceptions(0, MaxEnergy);
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Current Energy: {0}\n Max Energy: {1}", CurrentEnergy, MaxEnergy);
        }
    }
}
