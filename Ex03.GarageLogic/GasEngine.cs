﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class GasEngine : Engine
    {
        public Enums.eGasType GasType { get; set; }
        public void Fuel(float i_GasAmountToAdd, Enums.eGasType i_GasType)
        {
            if (i_GasType == GasType)
            {
                if (i_GasAmountToAdd + CurrentEnergy <= MaxEnergy)
                {
                    CurrentEnergy += i_GasAmountToAdd;
                }
                else
                {
                    throw new ValueOutOfRangeExceptions(0, MaxEnergy - CurrentEnergy);
                }
            }
            else
            {
                throw new ArgumentException("Wrong gas type");
            }
        }

        public override string ToString()
        {
            return string.Format("Gas Type: {0}\nCurrent Gas Amount: {1}/{2} liters", GasType, CurrentEnergy, MaxEnergy);
        }
    }
}
