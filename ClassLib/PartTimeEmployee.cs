using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_B
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string position) : base(position) {}

        public override void PrintFullName()
        {
            base.PrintFullName();
            Console.WriteLine(" is part time employee");
        }
    }
}
