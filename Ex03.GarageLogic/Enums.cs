﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public class Enums
    {
        public enum eVehicleStatus
        {
            InFix,
            Fixed,
            Paid
        }

        public enum eEngineType
        {
            Gas,
            Electric
        }

        public enum eVehicleType
        {
            GasCar = 1,
            ElectricCar,
            GasMotorcycle,
            ElectricMotorcycle,
            Truck
        }

        public enum eCarColors
        {
            Yellow,
            White,
            Red,
            Black
        }

        public enum eNumOfDoors
        {
            Two = 2,
            Three,
            Four,
            Five
        }

        public enum eLicenseType
        {
            A,
            A1,
            AA,
            B1
        }

        public enum eGasType
        {
            Soler,
            Octan95,
            Octan96,
            Octan98
        }
    }


}
