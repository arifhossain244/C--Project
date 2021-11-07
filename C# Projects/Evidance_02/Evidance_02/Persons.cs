using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_02
{
    public abstract class Persons
    {
        public Persons() { }
        public Persons(string name, DateTime birthDate) { this.Name = name; this.BirthDate = birthDate; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public abstract int Age();
    }
}
