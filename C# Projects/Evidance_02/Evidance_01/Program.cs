using Evidance_01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee t = new Trainee();
            Console.Write("ID: ");
            t.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            t.Name = Console.ReadLine();
            Console.Write("Address: ");
            t.Address = Console.ReadLine();
            Console.Write("Date Of Birth: ");
            t.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write("Course [1-Web, 2-Programming, 3-Database, 4-Networking ]: ");
            t.Courese= (Course)int.Parse(Console.ReadLine());
            Console.Write("Subjects: ");
            string input = Console.ReadLine();
            t.AddSubjects(input.Split(','));
            Console.WriteLine();
            Console.WriteLine("=========OutPut==========");
            Console.WriteLine($"ID: {t.Id}, Name: {t.Name}, Address: {t.Address}, BirthDate: {t.DateOfBirth:dd-mm-yyyy}");
            Console.WriteLine($"Course: {t.GetSubjects()}");
            Console.ReadLine();
        }
    }
}
