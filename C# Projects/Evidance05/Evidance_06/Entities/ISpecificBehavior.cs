using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_06.Entities
{
    public interface ISpecificBehavior<T>
    {
        string GetGenericBehavior<T>(ref T Data) where T : Animal;
    }
}
