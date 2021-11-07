using Evidance_01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_01
{
    public sealed class Trainee : Person, ISubjects 
    {
        public Trainee() { this.Subjects = new List<string>(); }
        public Trainee(int id, string name, string address, DateTime dob, Course course):base(name, address, dob) 
        { 
            this.Id = id; 
            this.Courese = course;
            
        }
        public int Id { get; set; }
        public Course Courese { get; set; }
        private List<string> Subjects { get; set; }
        public void AddSubjects(string[] subjects)
        {
            this.Subjects.AddRange(subjects);
        }

        public override int Age()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }

        public string GetSubjects()
        {
            return string.Join(",", Subjects.ToArray());
        }
    }
}
