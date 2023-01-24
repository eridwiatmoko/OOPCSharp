using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSharp.OOP
{
    internal abstract class VehicleBase
    {
        protected VehicleBase(string? noPoliceReg, VehicleType vehicleType, DateTime transactionDate, double rent)
        {
            NoPoliceReg = noPoliceReg;
            VehicleType = vehicleType;
            TransactionDate = transactionDate;
            Rent = rent;
        }

        public string? NoPoliceReg { get; set; }
        public VehicleType VehicleType { get; set; }
        public string? Year { get; set; }
        public double? Price { get; set; }
        public float? Tax { get; set; }
        public int? Seat { get; set; }
        public DateTime TransactionDate { get; set; }
        public double? Rent { get; set; }
        public decimal? TotalIncome { get; set; }

        public override string? ToString()
        {
            return $"NoPoliceReg : {NoPoliceReg}, Type : {VehicleType}, TransactionDate : {TransactionDate}, Rent : {Rent}";
        }
    }
}
