using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSharp.OOP
{

    //memungkinkan class taxi tidak bisa diwariskan
    internal sealed class Taxi : VehicleBase
    {
        public Taxi(string? noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double rent, int order, double orderPerKM) : base (noPoliceReg, vehicleType, transactionDate, rent)
        {
            Order = order;
            OrderPerKM = orderPerKM;
            TotalIncome = (decimal) (Rent + (Order * OrderPerKM));
        }

        public double Order { get; set; }
        public double OrderPerKM { get; set; }

        public override string? ToString()
        {
            return base.ToString() + $" Total Income: {TotalIncome}";
        }
    }
}
