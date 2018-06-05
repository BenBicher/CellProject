using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cell.Models.Entities
{
    [DataContract]
    public class SMS
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public double ExternalPrice { get; set; }
        [DataMember]
        public string DestinationNumber { get; set; }
        [DataMember]
        public int LineId { get; set; }
        [DataMember]
        public Line Line { get; set; }
    }
}
