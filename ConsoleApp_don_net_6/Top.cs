using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_don_net_6
{
    public class Top
    {
        public Menu Menu { get; set; }

        public void Print()
        {
            Console.WriteLine($"Header: {Menu.Header}");

            foreach (Item item in Menu.Items)
            {
                if (item != null)
                {
                    Console.Write("\t");
                    Console.Write(item.Id);
                    if (item.Label != null)
                    {
                        Console.Write($" {item.Label}");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("\tnull");
                }
            }
        }
    }
}
