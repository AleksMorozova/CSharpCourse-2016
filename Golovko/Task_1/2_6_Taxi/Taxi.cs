using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_Taxi
{
    class Taxi : ITaxi
    {
        public double Distance { get; set; }
        public double Delay { get; set; }
        public Tarif Tarif { get; }
        public double Payment
        {
            get
            {
                return Distance > Tarif.MaxPaidDistance ? 
                    Tarif.MaxPaidDistance * Tarif.MaxPaidTarif + (Distance - Tarif.MaxPaidDistance) * Tarif.PaidTarif + Delay * Tarif.DelayTarif :
                    Distance * Tarif.MaxPaidTarif + Delay * Tarif.DelayTarif;
            }
        }
        public Taxi(double distance, double delay, Tarif tarif)
        {
            this.Distance = distance;
            this.Delay = delay;
            this.Tarif = tarif;
        }
    }
}
