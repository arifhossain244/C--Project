using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_03.Models
{
    public class Vehicle
    {
        public Vehicle() { }
        public Vehicle(string model, int make, int cc, string geartype, VehicleType type) 
        {
            this.Model = model;
            this.Make = make;
            this.CC = cc;
            this.GearType = geartype;
            this.Type = type;
        }
        public string Model { get; set; }
        public int Make { get; set; }
        public int CC { get; set; }
        public string GearType { get; set; }
        public VehicleType Type { get; set; }
        public override string ToString()
        {
            return $"Model: {this.Model}\nMake: {this.Make}\nCC: {this.CC}\nGearType: {this.GearType}\nType: {this.Type}";
        }
    }
}
