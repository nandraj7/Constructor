using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }

        public static int NumbersOfDoctors { get; set; }
        static Doctor()
        {
            Doctor.NumbersOfDoctors = 5;
        }

        public Doctor()
        {
            Console.WriteLine(" ");
            this.Id = 01;
            this.Name = "Murliprasad Sharma";
            this.Degree = "MBBS";
        }
        public Doctor(int Id, string Name, string Degree)
        {
            Console.WriteLine(" ");
            this.Id = Id;
            this.Name = Name;
            this.Degree = Degree;
        }
        public Doctor(Doctor doctor)
        {
            Console.WriteLine(" ");
            this.Id = doctor.Id;
            this.Name = doctor.Name;
            this.Degree = doctor.Degree;

        }  
        public void ShowData()
        {
            Console.WriteLine("Id = " + this.Id);
            Console.WriteLine("Name = " + this.Name);
            Console.WriteLine("Degree = " + this.Degree);
        }
    }
}
