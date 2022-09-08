using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_don_net_6
{
    internal class Document : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("The document has been printed");
        }
    }
}
