using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Employee
    {
        public Employee()       //Parameterless or Default Constructor
        {
            this.Id = 10;
            this.Name = "Akshay";
            this.Salary = 10000;
        
        }
        public Employee(int id, string name, int salary)    //Parameterized Constructor
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;

        }

        public Employee(Employee emp)   //Copy Constructor
        {
            this.Id = emp.Id;
            this.Name = emp.Name;
            this.Salary = emp.Salary;
        }

        public void PutData()
        {
            Console.WriteLine("Id =" +this.Id);
            Console.WriteLine("Name =" + this.Name);
            Console.WriteLine("Salary =" + this.Salary);

        }

        #region Type Casting Demo
        public int GetNumber()
        {
            return 1;
        }

        public string GetName()
        {
            return "abc";
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        #endregion
    }
}
