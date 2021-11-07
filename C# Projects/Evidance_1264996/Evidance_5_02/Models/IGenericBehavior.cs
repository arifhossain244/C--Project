using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_5_02.Models
{
    public interface IGenericBehavior<T>
    {
        string GetGenericBehavior<T>(T obj);
    }
}
