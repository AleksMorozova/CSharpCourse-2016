using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_MauGau
{
    class Act : IAct
    {
        public string MakeAct(string cmd)
        {
            string result;
            if (cmd == "Gau") result = "Lets walk with the dog";
            else if (cmd == "Mau") result = "Lets feed the cat";
            else result = "Unknown command";
            return result;
        }
    }
}
