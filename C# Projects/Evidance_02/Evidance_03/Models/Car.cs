using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_03.Models
{
    public class Car:Vehicle, IInteriorFeature
    {
        public Car() { }
        public Car(int wheels, string model, int make, int cc, string geartype, VehicleType type):base(model,make,cc, geartype, type) 
        { 
            this.Wheels = wheels;
        }
        public int Wheels { get; set; }
        public string[] Feature { get; set; }

        public void AddFeature(string[] feature)
        {
            this.Feature = feature;
        }

        public string GetFeature()
        {
            return string.Join(",", this.Feature);
        }
        public override string ToString()
        {
            return base.ToString()
                + "\n" +
                $"Feature: {this.Feature}";
        }
    }
}
