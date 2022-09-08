using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_B
{
    internal struct MyStruct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"{Id} {Name} {Email}");
        }
    }
}
