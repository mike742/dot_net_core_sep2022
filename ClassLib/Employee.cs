using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_B
{
    public class Employee : Person
    {
        public double? Salary { get; set; }
        public string? Position { get; }

        public Employee(string position)
        {
            Position = position;
        }

        public virtual void PrintFullName()
        {
            Console.Write($"{FirstName} {LastName} ");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Position} and has ${Salary}";
        }
    }
}
