using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_03.Models
{
    public interface IInteriorFeature
    {
        void AddFeature(string[] feature);
        string GetFeature();
    }
}
