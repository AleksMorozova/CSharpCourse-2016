using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [DataContract]
    [Flags]
    public enum Location
    {
        [EnumMember]
        InStock,

        [EnumMember]
        Absent
    }
}
