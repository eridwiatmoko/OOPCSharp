using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSharp.OOP
{
    internal class Jet : VehicleBase
    {
        public Jet(string? noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double rent, double orderPerHours) : base(noPoliceReg, vehicleType, transactionDate, rent)
        {
            OrderPerHours = orderPerHours;
        }

        public double OrderPerHours { get; set; }
    }
}
