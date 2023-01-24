using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSharp.OOP.Structure
{
    internal record VehicleRecord
    {
        public string? NoPoliceReg { get; set; }
        public VehicleType VehicleType { get; set; }
        public DateTime TransactionDate { get; set; }
        public double Rent { get; set; }
        public int Order { get; set; }
        public double OrderPerKM { get; set; }
    }
}
