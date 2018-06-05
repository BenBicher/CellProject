using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Cell.Models.Entities
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public string ClientId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public int ClientTypeId { get; set; }
        [DataMember]
        public ClientType ClientType { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int CallsToCenter { get; set; }
        [DataMember]
        public int? LineId { get; set; }

        [DataMember]
        public IEnumerable<Payment> Payments { get; set; }
        [DataMember]
        public IEnumerable<Line> Lines { get; set; }
    }
}
