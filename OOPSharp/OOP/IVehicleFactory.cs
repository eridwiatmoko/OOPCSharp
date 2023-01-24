using OOPSharp.OOP.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSharp.OOP
{
    internal interface IVehicleFactory
    {
        public SUV CreateSUV(VehicleStruct vStruct);
        public Taxi CreateTaxi(VehicleRecord vRecord);
        public Jet CreateJet(VehicleStruct vhStruct);
        public void DisplayVehicle<T>(List<T> listVehicle);
        public int GetTotalVehicle(List<VehicleBase> listVehicle, VehicleType? vhType = VehicleType.ALL);
        public decimal GetTotalIncomeVehicle(List<VehicleBase> listVehicle, VehicleType? vhType = VehicleType.ALL);
    }
}
