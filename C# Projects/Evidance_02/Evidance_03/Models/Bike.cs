using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_03.Models
{
    public class Bike:Vehicle, IExteriorFeature
    {
        public Bike() { }
        public Bike(string starttype, string model, int make, int cc, string geartype, VehicleType type):base(model, make, cc, geartype, type)
        {
            this.StartType = starttype;
        }
        public string StartType { get; set; }
        public string[] Feature { get; set; }

        public void AddFeature(string[] feature)
        {
            this.Feature = feature;
        }

        public string GetFeature()
        {
            return string.Join(",",this.Feature);
        }
        public override string ToString()
        {
            return base.ToString()
            +"\n" +
             $"Feature: {this.Feature}";
        }
    }
}
