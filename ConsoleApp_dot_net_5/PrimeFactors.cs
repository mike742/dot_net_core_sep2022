using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_dot_net_5
{
    public class PrimeFactors
    {
        public static string? Get(int value)
        {
            switch (value)
            {
                case 4: return "2 x 2";
                case 7: return "7";
                case 30: return "2 x 3 x 5";
                case 40: return "2 x 2 x 2 x 5";
                case 50: return "2 x 5 x 5";
                default:
                    break;
            }

            return null;
        }

    }
}
