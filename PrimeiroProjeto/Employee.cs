using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Employee
    {
    
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentagem)
        {
            Salary += Salary * percentagem / 100; 
        }

        public override string ToString()
        {
             return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}
