using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Evidance_02.Enums;

namespace Evidance_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees emp = new Employees();
            Console.WriteLine("INPUTS");
            Console.WriteLine("------");
            Console.WriteLine("------");
            Console.Write("ID: ");
            emp.ID = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            emp.Name = Console.ReadLine();
            Console.WriteLine("You have the following designation: ");
            Console.Write($"201-GM, 202-DGM, 203-AGM, 204-Manager, 205-Executive, 206-Assistant: ");
            emp.Designation = (Designations)int.Parse(Console.ReadLine());
            Console.Write("Date Of Birth: ");
            emp.BirthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Joining Date: ");
            emp.JoiningDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Roles [Separate by comma]: ");
            string input = Console.ReadLine();
            emp.AddRoles(input.Split(','));
            Console.WriteLine();
            Console.WriteLine("OUTPUTS");
            Console.WriteLine("------");
            Console.WriteLine("------");
            Console.WriteLine($"ID: {emp.ID}");
            Console.WriteLine($"Name: {emp.Name}");
            Console.WriteLine($"Designation: {emp.Designation}");
            Console.WriteLine($"BirthDate: {emp.BirthDate}");
            Console.WriteLine($"JoiningDate: {emp.JoiningDate}");
            Console.WriteLine("Role Plays: ");
            foreach (var r in emp.Roles)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();
        }
    }
}
