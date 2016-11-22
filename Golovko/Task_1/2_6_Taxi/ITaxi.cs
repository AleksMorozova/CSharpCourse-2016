using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_Taxi
{
    interface ITaxi
    {
        double Distance { get; set; }
        double Delay { get; set; }
        Tarif Tarif { get; }
        double Payment { get; }
    }
}
