using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSharp.OOP
{
    internal class SUV : VehicleBase
    {
        public SUV(string? noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double rent, double driverFee) : base (noPoliceReg, vehicleType, transactionDate, rent)
        {   
            DriverFee = driverFee;
            TotalIncome = (decimal)(Rent + DriverFee);
        }

        public double DriverFee { get; set; }

        public override string? ToString()
        {
            return base.ToString() + $" Total Income: {TotalIncome}";
        }
    }
}
