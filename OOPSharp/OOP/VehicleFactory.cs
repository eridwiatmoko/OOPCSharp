using OOPSharp.OOP.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSharp.OOP
{
    internal class VehicleFactory : IVehicleFactory
    {
        public Jet CreateJet(VehicleStruct vhStruct)
        {
            throw new NotImplementedException();
        }

        public SUV CreateSUV(VehicleStruct vStruct)
        {
            return new SUV(vStruct.NoPoliceReg, vStruct.VehicleType, vStruct.TransactionDate, vStruct.Rent, vStruct.DriverFee);
        }

        public Taxi CreateTaxi(VehicleRecord vRecord)
        {
            return new Taxi(vRecord.NoPoliceReg, vRecord.VehicleType, vRecord.TransactionDate, vRecord.Rent, vRecord.Order, vRecord.OrderPerKM);
        }

        public void DisplayVehicle<T>(List<T> listVehicle)
        {
            foreach (var item in listVehicle)
            {
                Console.WriteLine($"{item}");
            }
        }

        public decimal GetTotalIncomeVehicle(List<VehicleBase> listVehicle, VehicleType? vhType = VehicleType.ALL)
        {
            if (vhType == VehicleType.ALL)
            {
                return (decimal)listVehicle.Sum(x => x.TotalIncome);
            }
            else
            {
                return (decimal)listVehicle.Where(x => x.VehicleType == vhType).Sum(x => x.TotalIncome);
            }
        }

        public int GetTotalVehicle(List<VehicleBase> listVehicle, VehicleType? vhType = VehicleType.ALL)
        {
            if (vhType == VehicleType.ALL)
            {
                return listVehicle.Count;
            }
            else
            {
                return listVehicle.Count(n => n.VehicleType == vhType);
            }
        }
    }
}
