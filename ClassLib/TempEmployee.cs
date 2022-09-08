using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_B
{
    public class TempEmployee : Employee
    {
        public TempEmployee(string position) : base(position)
        {
        }

        public override void PrintFullName()
        {
            base.PrintFullName();
            Console.WriteLine(" is a temp employee");
        }
    }
}
