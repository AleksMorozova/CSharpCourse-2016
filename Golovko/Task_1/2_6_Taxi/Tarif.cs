using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_Taxi
{
    struct Tarif : ITarif
    {
        public double MaxPaidDistance { get; set; }
        public double MaxPaidTarif { get; set; }
        public double PaidTarif { get; set; }
        public double DelayTarif { get; set; }
        public Tarif(double maxPaidDistance, double maxPaidTarif, double paidTarif, double delayTarif)
        {
            this.MaxPaidDistance = maxPaidDistance;
            this.MaxPaidTarif = maxPaidTarif;
            this.PaidTarif = paidTarif;
            this.DelayTarif = delayTarif;
        }
    }
}
