﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ex03.GarageLogic.GarageManager;

namespace Ex03.GarageLogic
{
    public class Truck : Vehicle
    {
        public bool IsCarryingDangerousMaterials { get; set; }
        public float CargoVolume { get; set; }

        public const int k_NumOfWheels = 12;
        public const int k_MaxAirPressure = 28;


        public Truck() : base(k_NumOfWheels, k_MaxAirPressure)
        {
            GasEngine engine = new GasEngine();
            engine.MaxEnergy = 120;
            VehicleType = Enums.eVehicleType.Truck;
            engine.GasType = Enums.eGasType.Soler;
            VehicleEngine = engine;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine(string.Format("Is carrying dangerous materials: {0}\nCargo volume: {1}", IsCarryingDangerousMaterials, CargoVolume));
            stringBuilder.AppendLine(VehicleEngine.ToString());
            return stringBuilder.ToString();
        }
    }
}
