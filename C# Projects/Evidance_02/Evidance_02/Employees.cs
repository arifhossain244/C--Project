using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_02
{
    public class Employees : Persons , IRoles
    {
        public Employees() { }
        public Employees(int Id, string name, DateTime birthDate, DateTime jod, Designations designation):base(name, birthDate)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
            }

            this.ID = Id; 
            this.Name = name;
            this.BirthDate = birthDate; 
            this.JoiningDate = jod;
            this.Designation = designation ;
        }
        public int ID { get; set; }
        public DateTime JoiningDate { get; set; }
        public Designations Designation { get; set; }
        public string[] Roles { get; set; }

        public override int Age()
        {
            return DateTime.Now.Year - this.BirthDate.Year;
        }
        public void AddRoles(string[] roles)
        {
            this.Roles = roles;
        }

        public string RolePlays()
        {
            return string.Join(",", this.Roles);
        }
    }
}
