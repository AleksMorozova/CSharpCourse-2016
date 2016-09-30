using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_Taxi
{
    interface ITarif
    {
        double MaxPaidDistance { get; set; }
        double MaxPaidTarif { get; set; }
        double PaidTarif { get; set; }
        double DelayTarif { get; set; }
    }
}
